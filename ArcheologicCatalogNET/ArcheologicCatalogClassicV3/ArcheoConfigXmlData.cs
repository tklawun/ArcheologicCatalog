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
    class ArcheoConfigXmlData
    {
        private XmlDocument xmlDoc = new XmlDocument();
        private XmlNode rootNode;
        public void InitializeXMLFile(string xmlFilePath)
        {
            rootNode = xmlDoc.CreateElement("ArcheoConfig");
            xmlDoc.AppendChild(rootNode);
            XmlNode param1Node = xmlDoc.CreateElement("");
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

        public XmlDocument GenerateXMLDocumentFromList(List<string> List, string Parameter)
        {
            String ListName = Parameter + "List";
            
            //TODO: 
            //if not exist xmldocument, create new... 
            //if not exist rootnode, create them....

            XmlNode rootNode = xmlDoc.CreateElement("ArcheoConfig");
            XmlNode ListNode = xmlDoc.CreateElement(ListName);
            
            foreach (string entry in List)
            {
                XmlNode entryNode = xmlDoc.CreateElement(Parameter);
                entryNode.InnerText = entry;
                ListNode.AppendChild(entryNode);
            }
            rootNode.AppendChild(ListNode);
            xmlDoc.AppendChild(rootNode);
            return xmlDoc;
        }

        public List<string> GetListFromXMLDoc(string Parameter)
        {
            XmlDocument xmlDoc = this.ReadXMLDocumentFromFile(new FilePaths().getXmlConfigFilePath());
            String ListName = Parameter + "List";
            string xmlNodePath = "/ArcheoConfig/" + ListName + "/" + Parameter;
            XmlNodeList elemList = xmlDoc.DocumentElement.SelectNodes(xmlNodePath);
            List<string> ListOfElement;
            if (elemList.Count < 1)
            {
                ListOfElement = new List<string>
                {
                    "Kein Eintrag vorhanden."
                };
            }
            else
            {
                ListOfElement = new List<string>();
                foreach (XmlNode node in elemList)
                {
                    ListOfElement.Add(node.InnerText);
                }
            }
            return ListOfElement;
        }
    }
}
