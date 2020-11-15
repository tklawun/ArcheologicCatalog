using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV2
{
    class XmlFilePath
    {
        public String getXmlFilePath()
        {
            String xmlFilePath = Environment.GetEnvironmentVariable("OneDrive") + "\\ArcheoCatalogData\\ArcheoCatalogData.xml";
            return xmlFilePath;
        }
    }
}
