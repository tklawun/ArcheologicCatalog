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
        XmlData XmlDataObj;
        private RegCtl reg;

        //TODO: Singleton Pattern
       
        public void Start()
        {
            applicationPath = Environment.GetEnvironmentVariable("OneDriveConsumer") + "\\ArcheoCatalog";
            //create Application Pfad, if dosnt exists
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
            reg = new RegCtl();
            XmlDataObj = new XmlData();
            pathOfPictures = reg.GetPathForPictureFolderIntoRegistry();
            listOfPics = GetAllPicturesPathInDirectory();
            archeoObjectCol = new ArrayList();
            archeoObjectCol = SetArcheoObjCol();
            //TODO: Matchen der Liste der Bilder mit den schon vorhandenen Einträgen in dem Objektkatalog Idee ist: den Dateinamen zu verwenden.
            MatchImageListWithArcheoObjectList();
            
        }
        public void ViewArcheObjectList()
        {
            ArcheoCatalogList archeoListView = new ArcheoCatalogList(this);
            archeoListView.SetListView();
            archeoListView.Show();
        }
        private void MatchImageListWithArcheoObjectList()
        {

            foreach (string imageLink in listOfPics)
            {
                foreach (ArcheoObject archeoObj in archeoObjectCol)
                {
                    if (imageLink == archeoObj.GetImagelink())
                    {
                        break;
                    }
                }

                AddArcheoObjectToCol("New", "type new code", "Typ of build", "0", "0", "0", "Typ of coordinate", "Coordinate", "Description", imageLink, "Particularities");
            }

            //throw new NotImplementedException();
        }

        public string GetApplicationDataXMLFile()
        {
            string appDataXMLFile = applicationPath + "\\" + applicationDataXMLFile;
            if (!System.IO.File.Exists(appDataXMLFile))
            {
                XmlDataObj.InitializeXMLFile(appDataXMLFile);
            }

            return appDataXMLFile;
        }

        public ArrayList SetArcheoObjCol()
        {
            string xmlFile = GetApplicationDataXMLFile();
            archeoObjectCol = XmlDataObj.GetArcheoObjColFromXMLDoc(XmlDataObj.ReadXMLDocumentFromFile(xmlFile));
            return archeoObjectCol;
        }
        public void AddArcheoObjectToCol(ArcheoObject archeoObj)
        {
            archeoObjectCol.Add(archeoObj);
        }
        /// <summary>
        /// create new Archeo Object
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="code">Code</param>
        /// <param name="typOfBuild">Type of Build</param>
        /// <param name="height">height of object</param>
        /// <param name="width">width of object</param>
        /// <param name="depth">dept of object</param>
        /// <param name="typOfCoordinate">Typ of coordinate</param>
        /// <param name="coordinate">coordinate</param>
        /// <param name="description">Description</param>
        /// <param name="imagelink">image in filesystem</param>
        /// <param name="particularities">particularities</param>
        public void AddArcheoObjectToCol(string title, string code, string typOfBuild, string height, string width, string depth, string typOfCoordinate, string coordinate, string description, string imagelink, string particularities)
        {
            ArcheoObject archeoObj = new ArcheoObject();
            archeoObj.SetTitle(title);
            archeoObj.SetCode(code);
            archeoObj.SetTypOfBuild(typOfBuild);
            //todo Wenn nicht umwandelbarer String, dann 0!
            try
            {
                archeoObj.SetHeight(int.Parse(height));
            }
            catch (Exception)
            {
                archeoObj.SetHeight(0);
            }
            try
            {
                archeoObj.SetWidth(int.Parse(width));
            }
            catch (Exception)
            {
                archeoObj.SetWidth(0);
            }
            try
            {
                archeoObj.SetDepth(int.Parse(depth));
            }
            catch (Exception)
            {

                archeoObj.SetDepth(0);
            }
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
            if (picturesPath.Length < 1)
            {
                picturesPath[0] = "no pictures found in " + pathToPictures;
            }
            return picturesPath;
        }

        public ArrayList getArcheoObjectCollection()
        {
            return archeoObjectCol;
        }

    }
}
