using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoObjectCtl
    {
        Dictionary<string, ArcheoObject> archeoObjects = new Dictionary<string, ArcheoObject>();
        
        public Dictionary<string, ArcheoObject> GetArcheoObjects()
        {
            return archeoObjects;
        }
        
        public ArcheoObject GetArcheoObject(string code)
        {
            ArcheoObject archeoObject = new ArcheoObject();

            //Todo: Gebe das Object zurück.
            bool existObject = archeoObjects.TryGetValue(code, out archeoObject);
            if (existObject)
            {
                return archeoObject;
            }
            else { return null; }

        }
        
        public void AddArcheoObject(ArcheoObject archeoObject)
        {
            archeoObjects.Add(archeoObject.CodeOut, archeoObject);
        }
        
        public void SetArcheoObject(string code, ArcheoObject archeoObject)
        {
            ArcheoObject archeo = GetArcheoObject(code);
            archeo = archeoObject;
            this.RemoveArcheoObject(code);
            this.AddArcheoObject(archeoObject);
        }
        
        public bool RemoveArcheoObject(string Code)
        {
            bool removed = archeoObjects.Remove(Code);
            return removed;
        }

        public void createArcheoObjectDictionary()
        {
            XmlData xmlData = new XmlData();
            this.archeoObjects = xmlData.GetArcheoObjColFromXMLDoc();

        }
    }
}

