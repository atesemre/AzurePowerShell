// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>
    /// Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching
    /// to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringCachingBehaviorTypeConverter))]
    public partial struct QueryStringCachingBehavior :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "IgnoreQueryString".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'IgnoreQueryString'", "IgnoreQueryString", global::System.Management.Automation.CompletionResultType.ParameterValue, "IgnoreQueryString");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "BypassCaching".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'BypassCaching'", "BypassCaching", global::System.Management.Automation.CompletionResultType.ParameterValue, "BypassCaching");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UseQueryString".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UseQueryString'", "UseQueryString", global::System.Management.Automation.CompletionResultType.ParameterValue, "UseQueryString");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotSet".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'NotSet'", "NotSet", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotSet");
            }
        }
    }
}