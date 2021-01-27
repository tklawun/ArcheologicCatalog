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
        ArcheoObjectXmlData xmlData;
        internal ArcheoObjectCtl()
        {
            this.xmlData = new ArcheoObjectXmlData();
            this.archeoObjects = this.xmlData.GetArcheoObjColFromXMLDoc();
        }

        internal Dictionary<string, ArcheoObject> GetArcheoObjects()
        {
            return archeoObjects;
        }
        
        internal ArcheoObject GetArcheoObject(string Id)
        {
            ArcheoObject archeoObject;
            //Todo: Gebe das Object zurück.
            bool existObject = archeoObjects.TryGetValue(Id, out archeoObject);
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
            archeoObjects.Add(archeoObject.IdOut, archeoObject);
        }
        
        internal void SetArcheoObject(string Id, ArcheoObject archeoObject)
        {
            //TODO: Suche das richtige ArcheoObject, wenn keins da, dann mach neuen Eintrag. 
            
            ArcheoObject archeo = GetArcheoObject(Id);
            
            archeo = archeoObject;
            this.RemoveArcheoObject(Id);
            this.AddArcheoObject(archeoObject);
            this.SaveArcheoObjects();
        }
        
        internal bool RemoveArcheoObject(string Id)
        {
            bool removed = archeoObjects.Remove(Id);
            return removed;
        }

        internal void CreateArcheoObjectDictionary()
        {
            ArcheoObjectXmlData xmlData = new ArcheoObjectXmlData();
            this.archeoObjects = xmlData.GetArcheoObjColFromXMLDoc();
        }

        internal void SaveArcheoObjects()
        {
           ArcheoObjectXmlData xmlData = new ArcheoObjectXmlData();
           xmlData.SaveXMLDocumentAsFile(xmlData.GenerateXMLDocumentFromArcheoObjectList(this.archeoObjects), new FilePaths().GetXmlDataFilePath());
        }

        internal void ExportToWord(string archeoObjectId)
        {
            Export exportCtl = new Export();
            exportCtl.ExportToWord(this.GetArcheoObject(archeoObjectId), new FilePaths().GetWordExportPath());

        }

        internal string GetRandomId()
        {
            //TODO generate RandomID (Vielleicht aus dem Zeitstempel... )
           
            string randomId = DateTime.UtcNow.ToString();
            return randomId;
        }
    }
}

