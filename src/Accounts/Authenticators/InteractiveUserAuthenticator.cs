﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using Azure.Core;
using Azure.Identity;
using Azure.Identity.BrokeredAuthentication;

using Hyak.Common;

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace Microsoft.Azure.PowerShell.Authenticators
{
    /// <summary>
    /// Authenticator for user interactive authentication
    /// </summary>
    public class InteractiveUserAuthenticator : DelegatingAuthenticator
    {
        // possible ports for adfs: [8405, 8408)
        // worked with stack team to pre-configure this in their deployment
        private const int AdfsPortStart = 8405;
        private const int AdfsPortEnd = 8408;
        // possible ports for aad: [8400, 9000)
        private const int AadPortStart = 8400;
        private const int AadPortEnd = 9000;

        public override Task<IAccessToken> Authenticate(AuthenticationParameters parameters, CancellationToken cancellationToken)
        {
            var interactiveParameters = parameters as InteractiveParameters;
            var onPremise = interactiveParameters.Environment.OnPremise;
            //null instead of "organizations" should be passed to Azure.Identity to support MSA account
            var tenantId = onPremise ? AdfsTenant :
                (string.Equals(parameters.TenantId, OrganizationsTenant, StringComparison.OrdinalIgnoreCase) ? null : parameters.TenantId);
            var tokenCacheProvider = interactiveParameters.TokenCacheProvider;
            var resource = interactiveParameters.Environment.GetEndpoint(interactiveParameters.ResourceId) ?? interactiveParameters.ResourceId;
            var scopes = AuthenticationHelpers.GetScope(onPremise, resource);
            var clientId = AuthenticationHelpers.PowerShellClientId;

            var requestContext = new TokenRequestContext(scopes);
            var authority = interactiveParameters.Environment.ActiveDirectoryAuthority;

            var options = new InteractiveBrowserCredentialBrokerOptions(GetConsoleWindow())
            {
                ClientId = clientId,
                TenantId = tenantId,
                TokenCachePersistenceOptions = tokenCacheProvider.GetTokenCachePersistenceOptions(),
                AuthorityHost = new Uri(authority),
                // MSAL doesn't rely on redirect URI from user input,
                // it always calculate it as "ms-appx-web://microsoft.aad.brokerplugin/{clientId}",
                // so the below RedirectUri is not for WAM, but for browser fallback.
                RedirectUri = GetReplyUrl(onPremise, interactiveParameters),
                LoginHint = interactiveParameters.UserId
            };
            var browserCredential = new InteractiveBrowserCredential(options);

            TracingAdapter.Information($"{DateTime.Now:T} - [InteractiveUserAuthenticator] Calling InteractiveBrowserCredential.AuthenticateAsync with TenantId:'{options.TenantId}', Scopes:'{string.Join(",", scopes)}', AuthorityHost:'{options.AuthorityHost}', RedirectUri:'{options.RedirectUri}'");
            var authTask = browserCredential.AuthenticateAsync(requestContext, cancellationToken);

            return MsalAccessToken.GetAccessTokenAsync(
                authTask,
                browserCredential,
                requestContext,
                cancellationToken);
        }

        // todo: this causes the WAM login Window to self-close on PowerShell 7.0
        // need investigation
        private static IntPtr GetWindowHandle()
        {
            IntPtr psWindowHandle;
            Process process = null;
            try
            {
                process = ParentProcessUtilities.GetFirstParentProcessWithNoneZeroMainWindowHandle();
            }
            catch { }
            if (process == null)
            {
                psWindowHandle = (IntPtr)0;
            }
            else
            {
                psWindowHandle = process.MainWindowHandle;
            }

            return psWindowHandle;
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        private Uri GetReplyUrl(bool onPremise, InteractiveParameters interactiveParameters)
        {
            var port = GetReplyUrlPort(onPremise, interactiveParameters);
            return new Uri($"http://localhost:{port}");
        }

        private int GetReplyUrlPort(bool onPremise, InteractiveParameters interactiveParameters)
        {
            int portStart = onPremise ? AdfsPortStart : AadPortStart;
            int portEnd = onPremise ? AdfsPortEnd : AadPortEnd;

            int port = portStart;
            TcpListener listener = null;

            do
            {
                try
                {
                    listener = new TcpListener(IPAddress.Loopback, port);
                    listener.Start();
                    listener.Stop();
                    return port;
                }
                catch (Exception ex)
                {
                    interactiveParameters.PromptAction(string.Format("Port {0} is taken with exception '{1}'; trying to connect to the next port.", port, ex.Message));
                    listener?.Stop();
                }
            }
            while (++port < portEnd);

            throw new Exception("Cannot find an open port.");
        }

        public override bool CanAuthenticate(AuthenticationParameters parameters)
        {
            return (parameters as InteractiveParameters) != null;
        }
    }
}
