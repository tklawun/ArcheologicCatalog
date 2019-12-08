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
    /// <summary>
    /// gibt XmlDocument zurück
    /// </summary>
    /// <returns>XmlDocument</returns>
    public XmlDocument GetXmlDocument()
    {
        XmlDocument xmlDoc = new XmlDocument();
        return xmlDoc;
    }
    /// <summary>
    /// Setzt ein XMLDocument
    /// </summary>
    /// <param name="xmlDocument">XMLDocument</param>
    /// <returns>Setzt XmlDocument</returns>
    public Boolean  SetXmlData(XmlDocument xmlDocument)
    {
        return false;
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
 }
