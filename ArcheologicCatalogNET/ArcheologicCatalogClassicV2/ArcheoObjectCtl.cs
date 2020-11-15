using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV2
{
    class ArcheoObjectCtl
    {
        List<ArcheoObject> archeoObjects;
        public void ArcheoObject()
        {
            archeoObjects = new List<ArcheoObject>();
            //load ArcheoObjects from XML File, if exists
            XmlData xmlData = new XmlData();
            String xmlFilePath = (new XmlFilePath().getXmlFilePath() );
            xmlData.ReadXMLDocumentFromFile(xmlFilePath);

        }
        

        public ArcheoObject newArcheoObject() {

            ArcheoObject archeoObject = new ArcheoObject();
            return archeoObject;
        
        }

        public void SetArcheoObject(ArcheoObject archeoObject)
        {
            
        }

        public ArcheoObject GetArcheoObject (String code)
        {
            ArcheoObject archeoObject = null;
            foreach (ArcheoObject item in archeoObjects)
            {
                if (item.GetCode().Equals(code))
                {
                    archeoObject = item;
                    break;
                }
            }
            return archeoObject;
        }


    }
}
