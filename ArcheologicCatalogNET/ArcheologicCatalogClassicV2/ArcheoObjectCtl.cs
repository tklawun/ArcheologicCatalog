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
            SetArcheoObjectsFromDatabase();
        }
        
        public List<ArcheoObject> GetArcheoObjects()
        {
            return archeoObjects;
        }

        //das ist die Schnittstelle zwischen der Datensammlung und dem Programm. Derzeit als XML Doc definiert.
        public void SetArcheoObjectsFromDatabase()
        {
           XmlData xmlData = new XmlData();
           archeoObjects = xmlData.GetArcheoObjColFromXMLDoc(xmlData.ReadXMLDocumentFromFile(new XmlFilePath().getXmlFilePath()));
        }

        public ArcheoObject NewArcheoObject() {
            ArcheoObject archeoObject = new ArcheoObject();
            archeoObjects.Add(archeoObject);
            return archeoObject;
        }

        public void SetArcheoObject(ArcheoObject archeoObject)
        {
            ArcheoObject archeoObject1 = GetArcheoObject(this.archeoObjects, archeoObject.GetCode());
        }

        public ArcheoObject GetArcheoObject (List<ArcheoObject> archeoObjects, String code)
        {
            this.archeoObjects = archeoObjects;
            ArcheoObject archeoObject = null;
            foreach (ArcheoObject item in this.archeoObjects)
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
