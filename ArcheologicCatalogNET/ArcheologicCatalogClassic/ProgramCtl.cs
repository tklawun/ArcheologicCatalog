using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ArcheologicCatalogClassic
{
    public class ProgramCtl
    {
        private string applicationPath;
        private string pathOfPictures;
        private string[] listOfPics;
        private const string applicationDataXMLFile = "ArcheoCatalogData.xml";
        private ArrayList archeoObjectCol;
        XmlData xmlDataObj;
        private RegCtl reg;
        public ProgramCtl()
        {
            Start();
        }
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
            pathOfPictures = reg.GetPathForPictureFolderIntoRegistry();
            listOfPics = GetAllPicturesPathInDirectory();
            archeoObjectCol = SetArcheoObjCol();
            xmlDataObj = new XmlData();
            reg = new RegCtl();
            //TODO: Matchen der Liste der Bilder mit den schon vorhandenen Einträgen in dem Objektkatalog Idee ist: den Dateinamen zu verwenden.
        }

        public string GetApplicationDataXMLFile()
        {
            string appDataXMLFile = applicationPath + "\\" + applicationDataXMLFile;
            if (!System.IO.File.Exists(appDataXMLFile))
            {
                xmlDataObj.InitializeXMLFile(appDataXMLFile);
            }
            return appDataXMLFile;
        }

        public ArrayList SetArcheoObjCol()
        {
            archeoObjectCol = xmlDataObj.GetArcheoObjColFromXMLDoc(xmlDataObj.ReadXMLDocumentFromFile(GetApplicationDataXMLFile()));
            return archeoObjectCol;
        }
        public void AddArcheoObjectToCol(ArcheoObject archeoObj)
        {
            archeoObjectCol.Add(archeoObj);
        }

        public void AddArcheoObjectToCol(string title, string code, string typOfBuild, string height, string width, string depth, string typOfCoordinate, string coordinate, string description, string imagelink, string particularities)
        {
            ArcheoObject archeoObj = new ArcheoObject();
            archeoObj.SetTitle(title);
            archeoObj.SetCode(code);
            archeoObj.SetTypOfBuild(typOfBuild);
            archeoObj.SetHeight(int.Parse(height));
            archeoObj.SetWidth(int.Parse(width));
            archeoObj.SetDepth(int.Parse(depth));
            archeoObj.SetTypOfCoordinate(typOfCoordinate);
            archeoObj.SetCoordinate(coordinate);
            archeoObj.SetDescription(description);
            archeoObj.SetImagelink(imagelink);
            archeoObj.SetParticularities(particularities);
            archeoObjectCol.Add(archeoObj);
        }

        internal void ShowArcheoCatalogDetail(string code)
        {
            ArcheoCatalogDetail archeoDetail = new ArcheoCatalogDetail(this, code);
            ArcheoObject archeoObj = GetArcheoObjFromCol(code);
            //Todo: Select das Element mit dem Code
            archeoDetail.setTitle(archeoObj.GetTitle());
            archeoDetail.setCode(archeoObj.GetCode());
            archeoDetail.setWidth(archeoObj.GetWidth().ToString());
            archeoDetail.setHeight(archeoObj.GetHeight().ToString());
            archeoDetail.setDepth(archeoObj.GetDepth().ToString());
            archeoDetail.setDescription(archeoObj.GetDescription());
            archeoDetail.setCoordinate(archeoObj.GetCoordinate());
            archeoDetail.setParticularities(archeoObj.GetParticularities());
            archeoDetail.setTypeOfBuild(archeoObj.GetTypeOfBuild());
            archeoDetail.setTypeOfCoordinate(archeoObj.GetTypeOfCoordinate());
            archeoDetail.Show();
            //throw new NotImplementedException();
        }

        public ArcheoObject GetArcheoObjFromCol(string code)
        {
            foreach (ArcheoObject item in archeoObjectCol)
            {
                if (item.GetCode().Equals(code))
                {
                    return item;
                }
            }
            return null;
        }

        public ArcheoObject GetArcheoObjFirstFromCol()
        {
            //Todo Das erste Element aus dem ArrayList zurückgeben
            int anzahl = archeoObjectCol.Count;
            if (anzahl < 1)
            {
                return null;
            }
            //gibt das erste Element zurück
            ArcheoObject archeoObj = (ArcheoObject)archeoObjectCol[0];
            return archeoObj;
            //throw new NotImplementedException();
        }

        public string[] GetAllPicturesPathInDirectory()
        {
            string pathToPictures = pathOfPictures;
            string[] picturesPath;
            picturesPath = Directory.GetFiles(pathToPictures, "*.jpg");
            if (picturesPath.Length < 1 )
            {
                picturesPath[0] = "no pictures found in " + pathToPictures;
            }
            return picturesPath;
        }
    }
}
