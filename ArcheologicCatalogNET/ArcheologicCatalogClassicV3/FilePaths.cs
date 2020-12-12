using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArcheologicCatalogClassicV3
{
    class FilePaths
    {
        internal String getXmlFilePath()
        {
            String xmlFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogData.xml";
            if (!File.Exists(xmlFilePath)){ 
                XmlData xmld = new XmlData();
                xmld.InitializeXMLFile(xmlFilePath);
            }
            return xmlFilePath;
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

        internal String getXmlFileForConfiguration()
        {
            String xmlFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogConfig.xml";
            if (!File.Exists(xmlFilePath))
            {
                XmlData xmld = new XmlData();
                xmld.InitializeXMLFile(xmlFilePath);
            }
            return xmlFilePath;
        }

    }
}
