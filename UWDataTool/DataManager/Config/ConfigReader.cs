using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Config
{
    class ConfigReader
    {
        const string BASE_CONFIG_PATH = "./appsettings.json";
        const string BASE_CONFIG_TEMPLATE = "./appsettings.{0}.json";
        private string appSettingsFilePath;

        ConfigReader(string enviornment)
        {
            if (string.IsNullOrEmpty(enviornment))
            {
                appSettingsFilePath = BASE_CONFIG_PATH;
            } else
            {
                appSettingsFilePath = string.Format(BASE_CONFIG_TEMPLATE, enviornment);
            }
        }

        public T GetConfig<T>(string configSection) where T:BaseModelConfig {
            return new BaseModelConfig() as T;
        }

    }
}
