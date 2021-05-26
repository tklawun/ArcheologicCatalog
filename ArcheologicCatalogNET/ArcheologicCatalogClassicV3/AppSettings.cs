using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    class AppSettings
    {
        public string StorageConnectionString { get; set; }

        public static AppSettings LoadAppSettings()
        {
            IConfigurationRoot configRoot = new ConfigurationBuilder()
            .AddJsonFile("Settings.json")
            .Build();
            AppSettings appSettings = configRoot.Get<AppSettings>();
            return appSettings;

        }

    }
}
