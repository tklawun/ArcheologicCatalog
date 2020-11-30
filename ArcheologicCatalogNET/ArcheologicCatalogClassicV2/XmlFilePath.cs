using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArcheologicCatalogClassicV2
{
    class XmlFilePath
    {
        public String getXmlFilePath()
        {
            String xmlFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalog\\ArcheoCatalogData.xml";
            if (!File.Exists(xmlFilePath)){ 
                XmlData xmld = new XmlData();
                xmld.InitializeXMLFile(xmlFilePath);
            }
            return xmlFilePath;
        }
    }
}
