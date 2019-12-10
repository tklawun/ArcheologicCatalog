using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using ArcheologicCatalogClassic;
using System.Collections;

class XmlData
{
    public void InitializeXMLFile(string xmlFilePath)
    {
        XmlDocument xmlDoc = new XmlDocument();
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
    public void SaveXMLDocumentAsFile (XmlDocument xmlDoc, String xmlFilePath)
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

    public XmlDocument ReadXMLDocumentFromFile (string xmlFilePath)
    {
        XmlDocument xmlDoc = new XmlDocument();

        try
        {
            xmlDoc.Load(xmlFilePath);
        }
        catch (Exception)
        {
            Console.WriteLine("Failure: File not exists!");
            throw;
        }

        return xmlDoc;
    }
    /// <summary>
    /// Baut aus der Liste von ArcheoObjecten ein XmlDocument
    /// </summary>
    /// <param name="archObj"></param>
    /// <returns>gibt das XmlDocument zurück</returns>
    public XmlDocument GenerateXMLDocumentFromArcheoObjectList(ArrayList archObjCol)
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("ArcheoObjectsList");
              
        foreach (ArcheoObject archObject in archObjCol)
        {
            XmlNode archeoNode = xmlDoc.CreateElement("ArcheoObject");
                             
            XmlAttribute codeAttribute = xmlDoc.CreateAttribute("code");
            codeAttribute.InnerText = archObject.GetCode();
            archeoNode.Attributes.Append(codeAttribute);
            XmlNode title = xmlDoc.CreateElement("title");
            title.InnerText = archObject.GetTitle();
            archeoNode.AppendChild(title);

            XmlNode code = xmlDoc.CreateElement("code");
            code.InnerText = archObject.GetCode();
            archeoNode.AppendChild(code);

            XmlNode coordinate = xmlDoc.CreateElement("coordinate");
            coordinate.InnerText = archObject.GetCoordinate();
            archeoNode.AppendChild(coordinate);

            XmlNode depth = xmlDoc.CreateElement("depth");
            depth.InnerText = archObject.GetDepth().ToString();
            archeoNode.AppendChild(depth);

            XmlNode description = xmlDoc.CreateElement("description");
            description.InnerText = archObject.GetDescription();
            archeoNode.AppendChild(description);

            XmlNode height = xmlDoc.CreateElement("height");
            height.InnerText = archObject.GetHeight().ToString();
            archeoNode.AppendChild(height);

            XmlNode width = xmlDoc.CreateElement("width");
            width.InnerText = archObject.GetWidth().ToString();
            archeoNode.AppendChild(width);

            XmlNode imageLink = xmlDoc.CreateElement("imageLink");
            imageLink.InnerText = archObject.GetImagelink();
            archeoNode.AppendChild(imageLink);

            XmlNode typeOfBuild = xmlDoc.CreateElement("typeOfBuild");
            typeOfBuild.InnerText = archObject.GetTypeOfBuild();
            archeoNode.AppendChild(typeOfBuild);

            XmlNode typeOfCoordinate = xmlDoc.CreateElement("typeOfCoordinate");
            typeOfCoordinate.InnerText = archObject.GetTypeOfCoordinate();
            archeoNode.AppendChild(typeOfCoordinate);

            XmlNode particularities = xmlDoc.CreateElement("particularities");
            particularities.InnerText = archObject.GetParticularities();
            archeoNode.AppendChild(particularities);

            rootNode.AppendChild(archeoNode);
        }
        xmlDoc.AppendChild(rootNode);
        return xmlDoc;
    }

    public ArrayList GetArcheoObjColFromXMLDoc(XmlDocument xmlDoc)
    {
        ArrayList archeoObjCol = new ArrayList();
        
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("ArcheoObject");
        for (int i = 0; i < elemList.Count; i++)
        {
            
            Console.WriteLine(elemList[i].InnerXml);
        }

        return archeoObjCol;
    }
 }
