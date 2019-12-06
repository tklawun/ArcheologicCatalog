using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

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
    public XmlDocument generateXMLDocumentFromArcheoObjectList(ArcheologicCatalogClassic.ArcheoObject[] archObj)
    {
        //todo: archObj XML Elements --> XMLDocument
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("ArcheoObjectsList");
        


        return xmlDoc;
    }
 }
