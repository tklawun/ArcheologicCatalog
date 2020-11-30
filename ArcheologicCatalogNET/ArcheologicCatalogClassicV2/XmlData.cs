using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ArcheologicCatalogClassicV2 { 
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
    public XmlDocument GenerateXMLDocumentFromArcheoObjectList(List<ArcheoObject> archObjCol)
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

            XmlNode currentNumber = xmlDoc.CreateElement("currentNumber");
            currentNumber.InnerText = archObject.GetCurrentNumber().ToString();
            archeoNode.AppendChild(currentNumber);

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

            XmlNode shortPath = xmlDoc.CreateElement("shortPath");
            imageLink.InnerText = archObject.GetShortPath();
            archeoNode.AppendChild(shortPath);

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

    public List<ArcheoObject> GetArcheoObjColFromXMLDoc(XmlDocument xmlDoc)
    {
        List<ArcheoObject> archeoObjCol = new List<ArcheoObject>();
        //TODO: Das Laden bestehender XML Daten funktioniert nicht korrekt. 
        XmlNodeList elemList = xmlDoc.DocumentElement.SelectNodes("/ArcheoObjectsList/ArcheoObject");
        foreach (XmlNode node in elemList)
        {
            ArcheoObject archeoObj = new ArcheoObject();
            archeoObj.SetTitle(node.SelectSingleNode("title").InnerText);
            archeoObj.SetCode(node.SelectSingleNode("code").InnerText);
            //try { archeoObj.SetCurrentNumber(int.Parse(node.SelectSingleNode("currentNumber").InnerText)); }
            //catch (Exception) { Console.WriteLine("Value currentNumber: Error by parse to int"); throw; }
            archeoObj.SetCoordinate(node.SelectSingleNode("coordinate").InnerText);
            try { archeoObj.SetDepth(int.Parse(node.SelectSingleNode("depth").InnerText)); }
            catch (Exception) {Console.WriteLine("Value depth: Error by parse to int"); throw; }
            try { archeoObj.SetWidth(int.Parse(node.SelectSingleNode("width").InnerText)); }
            catch (Exception) {Console.WriteLine("Value width: Error by parse to int"); throw; }
            try { archeoObj.SetHeight(int.Parse(node.SelectSingleNode("height").InnerText)); }
            catch (Exception) {Console.WriteLine("Value height: Error by parse to int"); throw; }
            archeoObj.SetTypOfCoordinate(node.SelectSingleNode("typeOfCoordinate").InnerText);
            archeoObj.SetTypOfBuild(node.SelectSingleNode("typeOfBuild").InnerText);
            archeoObj.SetCoordinate(node.SelectSingleNode("coordinate").InnerText);
            archeoObj.SetDescription(node.SelectSingleNode("description").InnerText);
            archeoObj.SetImagelink(node.SelectSingleNode("imageLink").InnerText);
            archeoObj.SetShortPath(node.SelectSingleNode("shortPath").InnerText);
            archeoObj.SetParticularities(node.SelectSingleNode("particularities").InnerText);
            archeoObjCol.Add((ArcheoObject)archeoObj);
        }
        return archeoObjCol;
    }
    //public int lastEntryCode(XmlDocument xmlDoc)
    //{
    //    int lastCode = 0;
    //    XmlNodeList elemList = xmlDoc.DocumentElement.SelectNodes("/ArcheoObjectsList/ArcheoObject");
    //    int anzahl = elemList.Count;
    //    int[] listOfCurrentNumbers = new int[anzahl]; 
    //    int i = 0;
    //    foreach (XmlNode node in elemList)
    //    {
    //        listOfCurrentNumbers[i] = int.Parse(node.SelectSingleNode("currentNumber").InnerText);
    //        i++;            
    //    }
    //    Array.Sort(listOfCurrentNumbers);
    //    lastCode = listOfCurrentNumbers[listOfCurrentNumbers.Length];

    //    return lastCode;
        
    //}
 }
}
