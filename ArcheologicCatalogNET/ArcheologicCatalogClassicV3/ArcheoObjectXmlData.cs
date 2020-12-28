using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Reflection;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoObjectXmlData
    {
        XmlDocument xmlDoc = new XmlDocument();

        public void InitializeXMLFile(string xmlFilePath)
        {
            XmlNode rootNode = xmlDoc.CreateElement("ArcheoObjectsList");
            xmlDoc.AppendChild(rootNode);
            try
            {
                xmlDoc.Save(xmlFilePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Failure: Application Datafile doesnt saved!");
                throw;
            }

        }

        /// <summary>
        /// Speichert das XmlDocument als File in das angebene Datei
        /// </summary>
        /// <param name="xmlDoc">XMLDocument</param>
        /// <param name="xmlFilePath">String "D:\Sample\Sample.xml"</param>
        public void SaveXMLDocumentAsFile(XmlDocument xmlDoc, String xmlFilePath)
        {
            try
            {
                xmlDoc.Save(xmlFilePath);
            }
            catch (Exception)
            {
                //todo: Ausnahme behandeln
                throw;
            }
        }

        public XmlDocument ReadXMLDocumentFromFile(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(xmlFilePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Failure: File not exists!");
                Console.WriteLine("File is created.");
                InitializeXMLFile(xmlFilePath);
                xmlDoc.Load(xmlFilePath);
            }
            return xmlDoc;
        }
        /// <summary>
        /// Baut aus der Liste von ArcheoObjecten ein XmlDocument
        /// </summary>
        /// <param name="archObj"></param>
        /// <returns>gibt das XmlDocument zurück</returns>
        public XmlDocument GenerateXMLDocumentFromArcheoObjectList(Dictionary<string, ArcheoObject> archObjCol)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("ArcheoObjectsList");

            foreach (KeyValuePair<string, ArcheoObject> archObject in archObjCol)
            {
                XmlNode archeoNode = xmlDoc.CreateElement("ArcheoObject");
                XmlAttribute codeAttribute = xmlDoc.CreateAttribute("code");
                codeAttribute.InnerText = archObject.Key;
                archeoNode.Attributes.Append(codeAttribute);
                ArcheoObject archeoObject = archObject.Value;
                Dictionary<string, string> PropertyList = archeoObject.GetArcheoObjectAsDictonary();

                foreach (KeyValuePair<string, string> item in PropertyList)
                {
                    XmlNode node = xmlDoc.CreateElement(item.Key);
                    node.InnerText = item.Value;
                    archeoNode.AppendChild(node);
                }

                rootNode.AppendChild(archeoNode);
            }
            xmlDoc.AppendChild(rootNode);
            return xmlDoc;
        }

        /// <summary>
        /// Gibt ein Liste von ArcheoObjects zurück
        /// </summary>
        /// <returns>Dictionary "string, ArcheoObject"</string></returns>
        public Dictionary<string, ArcheoObject> GetArcheoObjColFromXMLDoc()
        {
            Dictionary<string, ArcheoObject> archeoObjects = new Dictionary<string, ArcheoObject>();

            XmlDocument xmlDoc = this.ReadXMLDocumentFromFile(new FilePaths().getXmlDataFilePath());
            XmlNodeList elemList = xmlDoc.DocumentElement.SelectNodes("/ArcheoObjectsList/ArcheoObject");
            foreach (XmlNode node in elemList)
            {
                ArcheoObject archeoObject = new ArcheoObject();
                string[] PropertyList = archeoObject.GetObjectProperties();
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                string code = node.SelectSingleNode("Code").InnerText;
                foreach (string property in PropertyList)
                {
                    keyValuePairs.Add(property, node.SelectSingleNode(property).InnerText);
                    
                }
                archeoObject.SetArcheoObject(keyValuePairs);
                archeoObjects.Add(code, archeoObject);
            }
            return archeoObjects;
        }


    }
}
