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

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Config.Definitions;
using Microsoft.Azure.Commands.Common.Authentication.Config.Internal.Interfaces;
using Microsoft.Azure.Commands.Common.Authentication.Properties;
using Microsoft.Azure.Commands.Shared.Config;
using Microsoft.Azure.PowerShell.Common.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Microsoft.Azure.Commands.Common.Authentication.Config
{
    /// <summary>
    /// Initializes the config file and config manager.
    /// </summary>
    internal class ConfigInitializer
    {
        internal IDataStore DataStore { get; set; } = new DiskDataStore();
        private static readonly object _fsLock = new object();

        internal IEnvironmentVariableProvider EnvironmentVariableProvider { get; set; } = new DefaultEnvironmentVariableProvider();

        public string ConfigPath
        {
            get
            {
                if (_cachedConfigPath == null)
                {
                    _cachedConfigPath = GetPathToConfigFile(_configPathCandidates);
                }
                return _cachedConfigPath;
            }
        }
        private string _cachedConfigPath;
        private readonly IEnumerable<string> _configPathCandidates;

        public ConfigInitializer(IEnumerable<string> paths)
        {
            _configPathCandidates = paths ?? throw new ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Loop through the fallback list of paths of the config file. Returns the first usable one.
        /// </summary>
        /// <param name="paths">A list of paths to the config file. When one is not usable, it will fallback to the next.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException">When no one in the list is usable.</exception>
        private string GetPathToConfigFile(IEnumerable<string> paths)
        {
            // find first exist path and use it
            foreach (string path in paths)
            {
                if (DataStore.FileExists(path))
                {
                    return path;
                }
            }
            // if not found, use the first writable path
            foreach (string path in paths)
            {
                try
                {
                    DirectoryInfo dir = new FileInfo(path).Directory;
                    DataStore.CreateDirectory(dir.FullName); // create directory if not exists
                    DataStore.WriteFile(path, @"{}");
                    return path;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            throw new ApplicationException($"Failed to store the config file. Please make sure any one of the following paths is accessible: {string.Join(", ", paths)}");
        }

        internal IConfigManager GetConfigManager()
        {
            lock (_fsLock)
            {
                ValidateConfigFile();
            }
            return new ConfigManager(ConfigPath, DataStore, EnvironmentVariableProvider);
        }

        private void ValidateConfigFileContent()
        {
            string json = DataStore.ReadFileAsText(ConfigPath);

            bool isValidJson = true;
            try
            {
                JObject.Parse(json);
            }
            catch (Exception)
            {
                isValidJson = false;
            }

            if (string.IsNullOrEmpty(json) || !isValidJson)
            {
                Debug.Write($"[ConfigInitializer] Failed to parse the config file at {ConfigPath}. Clearing the file.");
                ResetConfigFileToDefault();
            }
        }

        private void ValidateConfigFile()
        {
            if (!DataStore.FileExists(ConfigPath))
            {
                ResetConfigFileToDefault();
            }
            else
            {
                ValidateConfigFileContent();
            }
        }

        private void ResetConfigFileToDefault()
        {
            try
            {
                DataStore.WriteFile(ConfigPath, @"{}");
            }
            catch (Exception ex)
            {
                // do not halt for IO exception
                Debug.WriteLine(ex.Message);
            }
        }

        // todo: tests initializes configs in a different way. Maybe there should be an abstraction IConfigInitializer and two concrete classes ConfigInitializer + TestConfigInitializer
        internal void InitializeForAzureSession(AzureSession session)
        {
            IConfigManager configManager = GetConfigManager();
            session.RegisterComponent(nameof(IConfigManager), () => configManager);
            RegisterConfigs(configManager);
            configManager.BuildConfig();
        }

        /// <summary>
        /// Migrates independent configs to the new config framework.
        /// </summary>
        /// <param name="profilePath">Path of session profile where old config files are stored.</param>
        internal void MigrateConfigs(string profilePath)
        {
            lock (_fsLock)
            {
                // Migrate data collection config
                string dataCollectionConfigPath = Path.Combine(profilePath, AzurePSDataCollectionProfile.DefaultFileName);
                const string legacyConfigKey = "enableAzureDataCollection";
                // Migrate only when:
                // 1. Old config file exists
                // 2. New config file does not exist
                if (DataStore.FileExists(dataCollectionConfigPath) && _configPathCandidates.All(path => !DataStore.FileExists(path)))
                {
                    try
                    {
                        string json = DataStore.ReadFileAsText(dataCollectionConfigPath);
                        JObject root = JObject.Parse(json);
                        if (root.TryGetValue(legacyConfigKey, out JToken jToken))
                        {
                            bool enabled = ((bool)jToken);
                            new JsonConfigWriter(ConfigPath, DataStore).Update(ConfigPathHelper.GetPathOfConfig(ConfigKeys.EnableDataCollection), enabled);
                        }
                    }
                    catch (Exception)
                    {
                        // do not throw for file IO exceptions
                    }
                }
            }
        }

        private void RegisterConfigs(IConfigManager configManager)
        {
            // simple configs
            configManager.RegisterConfig(new SimpleTypedConfig<string>(
                ConfigKeys.DefaultSubscriptionForLogin,
                Resources.HelpMessageOfDefaultSubscriptionForLogin,
                string.Empty,
                null,
                new[] { AppliesTo.Az }));
            configManager.RegisterConfig(new SimpleTypedConfig<bool>(
                ConfigKeys.EnableDataCollection,
                Resources.HelpMessageOfEnableDataCollection,
                true,
                AzurePSDataCollectionProfile.EnvironmentVariableName,
                new[] { AppliesTo.Az }));

            // configs with their own types
            // configManager.RegisterConfig(new EnableInterceptSurveyConfig()); // todo: uncomment after improvements are made to survey
            configManager.RegisterConfig(new DisplayBreakingChangeWarningsConfig());
        }
    }
}
