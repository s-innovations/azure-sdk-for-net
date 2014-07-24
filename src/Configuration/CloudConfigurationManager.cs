//
// Copyright Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//

using System;
using System.Globalization;

namespace Microsoft.WindowsAzure
{
     /// <summary>
    /// Configuration manager for accessing Microsoft Azure settings.
    /// </summary>
    public static class CloudConfigurationManager
    {
        private static object _lock = new object();
        private static AzureApplicationSettings _appSettings;

       
   

        /// <summary>
        /// Gets a setting with the given name using the provided <see cref="CloudConfigurationManagerSettingProviders"/> SettingProviders
        /// </summary>
        /// <param name="name">Setting name.</param>
        /// <param name="providers">Providers for where to look for settings</param>
        /// <returns>Setting value or null if not found.</returns>
        public static string GetSetting(string name, params string[] providers)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            else if (name.Length == 0)
            {
                string message = string.Format(CultureInfo.CurrentUICulture, Resources.ErrorArgumentEmptyString, "name");
                throw new ArgumentException(message);
            }

            if (providers == null)
            {
                throw new ArgumentNullException("providers");
            }
            else if(providers.Length == 0)
            {
                return null;
            }


            return AppSettings.GetSetting(name, providers);
        }

        /// <summary>
        /// Gets a setting with the given name.
        /// </summary>
        /// <param name="name">Setting name.</param>
        /// <returns>Setting value or null if not found.</returns>
        public static string GetSetting(string name)
        {
            return GetSetting(name, new string[]{ CloudConfigurationManagerSettingProviders.ServiceRuntime , CloudConfigurationManagerSettingProviders.ConfigurationManager});
        }

        /// <summary>
        /// Gets application settings.
        /// </summary>
        internal static AzureApplicationSettings AppSettings
        {
            get
            {
                if (_appSettings == null)
                {
                    lock (_lock)
                    {
                        if (_appSettings == null)
                        {
                            _appSettings = new AzureApplicationSettings();
                        }
                    }
                }

                return _appSettings;
            }
        }
    }
}
