using System;
using System.IO;
using System.Reflection;

namespace ArcheologicCatalogClassicV3
{
    class FilePaths
    {
        private string appPath;
        internal FilePaths()
        {
            this.appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        internal string GetXmlDataFilePath()
        {
            String xmlDataFilePath = appPath + "\\Data\\ArcheoCatalogData.xml";
            String xmlDataFileDirectory = appPath + "\\Data";
            if (!File.Exists(xmlDataFilePath)){
                if (!Directory.Exists(xmlDataFileDirectory))
                {   
                    Directory.CreateDirectory(xmlDataFileDirectory);
                }
                ArcheoObjectXmlData xmld = new ArcheoObjectXmlData();
                xmld.InitializeXMLFile(xmlDataFilePath);
            }
            return xmlDataFilePath;
        }
        internal string GetTemplatePath()
        {
            String templatePath = appPath + "\\Data\\ArcheoCatalogTemplate.dotx";
            if (!File.Exists(templatePath))
            {
                templatePath = null;
            }
            return templatePath;
        }
        internal string GetWordExportPath()
        {
            String WordExportPath = appPath + "\\Data\\WordExport\\";
            if (!Directory.Exists(WordExportPath))
            {
                Directory.CreateDirectory(WordExportPath);
            }
            return WordExportPath;
        }
        internal string GetSelectPicturePath()
        {
            String templatePath = appPath + "\\Data";

            if (!Directory.Exists(templatePath))
            {
                templatePath = "C:\\";
            }
            return templatePath;
        }

        internal String GetXmlConfigFilePath(string ConfigType)
        {
            String xmlFilePath = appPath + "\\Data\\ArcheoCatalogConfig" + ConfigType + ".xml";
            if (!File.Exists(xmlFilePath))
            {
                ArcheoObjectXmlData xmld = new ArcheoObjectXmlData();
                xmld.InitializeXMLFile(xmlFilePath);
            }
            return xmlFilePath;
        }
        internal Boolean IsFileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
