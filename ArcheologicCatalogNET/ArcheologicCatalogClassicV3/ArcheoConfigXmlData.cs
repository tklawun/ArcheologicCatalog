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
        XmlDocument xmlDoc = new XmlDocument();

        public void InitializeXMLFile(string xmlFilePath)
        {
            XmlNode rootNode = xmlDoc.CreateElement("ArcheoConfig");
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
        
        public XmlDocument GenerateXMLDocumentFromList(string[] List, string Parameter)
        {
            XmlDocument xmlDoc = new XmlDocument();
            String ListName = Parameter + "List";
            XmlNode rootNode = xmlDoc.CreateElement(ListName);

            foreach (string TypeOfBuild in List)
            {
                XmlNode typeOfBuildNode = xmlDoc.CreateElement(Parameter);
                typeOfBuildNode.InnerText = TypeOfBuild;
                rootNode.AppendChild(typeOfBuildNode);
            }
            xmlDoc.AppendChild(rootNode);
            return xmlDoc;
        }

        public string[] GetListFromXMLDoc(string Parameter)
        {
            XmlDocument xmlDoc = this.ReadXMLDocumentFromFile(new FilePaths().getXmlConfigFilePath());
            String ListName = Parameter + "List";
            string xmlNodePath = "/" + ListName + "/" + Parameter;
            XmlNodeList elemList = xmlDoc.DocumentElement.SelectNodes("/ArcheoTypeOfBuildList/TypeOfBuild");
            string[] List = new string[elemList.Count];
            int i = 0;
            foreach (XmlNode node in elemList)
            {
                List[i] = node.InnerText;
                i++;
            }
            return List;
        }
    }
}
