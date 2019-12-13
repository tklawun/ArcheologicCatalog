using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ArcheologicCatalogClassic
{
    class ProgramCtl
    {
        private string applicationPath;
        private const string applicationDataXMLFile = "ArcheoCatalogData.xml";

        public void Start()
        {
            applicationPath = Environment.GetEnvironmentVariable("OneDriveConsumer") + "\\ArcheoCatalog";
            //create Application Pfad, wenn nicht vorhanden.
            try
            {
                if (!System.IO.Directory.Exists(applicationPath))
                {
                    System.IO.Directory.CreateDirectory(applicationPath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Alert: Failure by Application Path handling");
                throw;
            }
            
            ArrayList archeoObj = SetArcheoObjCol();

        }
        /// <summary>
        /// gibt als String den Pfad des XML File zurück
        /// </summary>
        /// <returns>Pfad, wenn XML File existiert, ansonsten "Null"</returns>
        public string GetApplicationDataXMLFile()
        {
            string appDataXMLFile = applicationPath + "\\" + applicationDataXMLFile;
            if (!System.IO.File.Exists(appDataXMLFile))
            {
                XmlData xmlDataObj = new XmlData();
                xmlDataObj.InitializeXMLFile(appDataXMLFile);
            }
            return appDataXMLFile;
        }

        /// <summary>
        /// liest das XML Data File aus und gibt ein ArrayList mit diesem zurück.
        /// </summary>
        /// <returns></returns>
        public ArrayList SetArcheoObjCol()
        {
            XmlData xmlData = new XmlData();

            ArrayList archeoObjCol = xmlData.GetArcheoObjColFromXMLDoc(xmlData.ReadXMLDocumentFromFile(GetApplicationDataXMLFile()));
            return archeoObjCol;
        }
    }
}
