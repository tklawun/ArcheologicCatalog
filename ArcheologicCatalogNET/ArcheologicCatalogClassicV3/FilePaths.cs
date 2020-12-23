using System;
using System.IO;

namespace ArcheologicCatalogClassicV3
{
    class FilePaths
    {
        internal String getXmlDataFilePath()
        {
            String xmlDataFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogData.xml";
            if (!File.Exists(xmlDataFilePath)){ 
                ArcheoObjectXmlData xmld = new ArcheoObjectXmlData();
                xmld.InitializeXMLFile(xmlDataFilePath);
            }
            return xmlDataFilePath;
        }
        internal String getTemplatePath()
        {
            String templatePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogTemplate.dotx";
            if (!File.Exists(templatePath))
            {
                templatePath = null;
            }
            return templatePath;
        }
        internal String getWordExportPath()
        {
            String WordExportPath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\WordExport\\";
            if (!Directory.Exists(WordExportPath))
            {
                Directory.CreateDirectory(WordExportPath);
            }
            return WordExportPath;
        }
        internal String getSelectPicturePath()
        {
            String templatePath = Environment.GetEnvironmentVariable("OneDrive");

            if (!Directory.Exists(templatePath))
            {
                templatePath = "C:\\";
            }
            return templatePath;
        }

        internal String getXmlConfigFilePath()
        {
            String xmlFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogConfig.xml";
            if (!File.Exists(xmlFilePath))
            {
                ArcheoObjectXmlData xmld = new ArcheoObjectXmlData();
                xmld.InitializeXMLFile(xmlFilePath);
            }
            return xmlFilePath;
        }

    }
}
