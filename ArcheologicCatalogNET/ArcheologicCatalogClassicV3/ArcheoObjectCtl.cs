using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoObjectCtl
    {
        Dictionary<string, ArcheoObject> archeoObjects;
        XmlData xmlData;
        internal ArcheoObjectCtl()
        {
            this.xmlData = new XmlData();
            this.archeoObjects = this.xmlData.GetArcheoObjColFromXMLDoc();
        }

        internal Dictionary<string, ArcheoObject> GetArcheoObjects()
        {
            return archeoObjects;
        }
        
        internal ArcheoObject GetArcheoObject(string code)
        {
            ArcheoObject archeoObject;
            //Todo: Gebe das Object zurück.
            bool existObject = archeoObjects.TryGetValue(code, out archeoObject);
            if (existObject)
            {
                return archeoObject;
            }
            else { return null; }

        }

        internal string[] GetArcheoObjectsCode()
        {
            string[] archeoObjectsCode = new string[archeoObjects.Count-1];
            foreach (KeyValuePair<string, ArcheoObject> item in archeoObjects)
            {
                archeoObjectsCode.Append(item.Key);
            }
            return archeoObjectsCode;
        }

        internal void AddArcheoObject(ArcheoObject archeoObject)
        {
            archeoObjects.Add(archeoObject.CodeOut, archeoObject);
        }
        
        internal void SetArcheoObject(string code, ArcheoObject archeoObject)
        {
            //TODO: Suche das richtige ArcheoObject, wenn keins da, dann mach neuen Eintrag. 
            ArcheoObject archeo = GetArcheoObject(code);
            archeo = archeoObject;
            this.RemoveArcheoObject(code);
            this.AddArcheoObject(archeoObject);
            this.SaveArcheoObjects();
        }
        
        internal bool RemoveArcheoObject(string Code)
        {
            bool removed = archeoObjects.Remove(Code);
            return removed;
        }

        internal void CreateArcheoObjectDictionary()
        {
            XmlData xmlData = new XmlData();
            this.archeoObjects = xmlData.GetArcheoObjColFromXMLDoc();
        }

        internal void SaveArcheoObjects()
        {
           XmlData xmlData = new XmlData();
           xmlData.SaveXMLDocumentAsFile(xmlData.GenerateXMLDocumentFromArcheoObjectList(this.archeoObjects), new FilePaths().getXmlFilePath());
        }
    }
}

