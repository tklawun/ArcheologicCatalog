using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using ArcheologicCatalogClassic;

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
        xmlDoc.Save(xmlFilePath);
    }
    /// <summary>
    /// Baut aus der Liste von ArcheoObjecten ein XmlDocument
    /// </summary>
    /// <param name="archObj"></param>
    /// <returns>gibt das XmlDocument zurück</returns>
    public XmlDocument generateXMLDocumentFromArcheoObjectList(ArcheologicCatalogClassic.ArcheoObject[] archObjCol)
    {
        //todo: archObjCol XML Elements --> XMLDocument
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("ArcheoObjectsList");
        xmlDoc.AppendChild(rootNode);
        
        foreach (ArcheoObject archeoObject in archObjCol)
        {
            XmlNode archeoNode = xmlDoc.CreateElement("ArcheoObject");
            XmlAttribute codeAttribute = xmlDoc.CreateAttribute("code");
            
            codeAttribute.InnerText = archeoObject.GetCode();
            archeoNode.Attributes.Append(codeAttribute);
            XmlNode title = xmlDoc.CreateElement("titel");
            title.InnerText = archeoObject.GetTitle();
            rootNode.AppendChild(archeoNode);

        }

        
        return xmlDoc;
    }
 }
