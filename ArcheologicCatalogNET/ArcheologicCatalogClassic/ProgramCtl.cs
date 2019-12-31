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
        private string pathOfPictures;
        private string[] listOfPics;
        private const string applicationDataXMLFile = "ArcheoCatalogData.xml";
        private ArrayList archeoObjectCol;
        private ArcheoCatalogList archeoListView;
        private XmlData XmlDataObj;
        private RegCtl reg;

        internal string GetPicturesPath()
        {
            throw new NotImplementedException();
        }

        internal ArrayList GetArcheoObjCol()
        {
            return archeoObjectCol;
        }

        //TODO: Singleton Pattern

        public void Start()
        {
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
            archeoListView = new ArcheoCatalogList(this);
            archeoListView.SetListView();
            archeoListView.Show();
        }
        private void MatchImageListWithArcheoObjectList()
        {
            int i = 0;
            foreach (string imageLink in listOfPics)
            {
                foreach (ArcheoObject archeoObj in archeoObjectCol)
                {
                    if (imageLink == archeoObj.GetImagelink())
                    {
                        break;

                    }
                }
                string code = i.ToString() + " --> Type new code";
                string title = i.ToString() + "--> New";
                //Todo: Wie baue ich das am besten den ShortPath Wert zusammen? 
                string shortPath = "Muss noch gebaut werden";
                AddArcheoObjectToCol("New", code, "Typ of build", "0", "0", "0", "Typ of coordinate", "Coordinate", "Description", imageLink, shortPath, "Particularities");
                i++;
            }

            //throw new NotImplementedException();
        }

        public string GetApplicationDataXMLFile()
        {
            string appDataXMLFile = pathOfPictures + "\\" + applicationDataXMLFile;
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

        internal void ExitApplication()
        {
            //Todo: Application Exist Handling
            Application.Exit();
            //throw new NotImplementedException();
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
        public void AddArcheoObjectToCol(string title, string code, string typOfBuild, string height, string width, string depth, string typOfCoordinate, string coordinate, string description, string imagelink, string shortPath, string particularities)
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
            archeoObj.SetShortPath(shortPath);
            archeoObj.SetParticularities(particularities);
            archeoObjectCol.Add(archeoObj);
        }

        internal void SaveArcheoObjToXML()
        {
            //Todo: Speichern der ArcheoObjectCollection into xml File.
            XmlData xmld = new XmlData();
            XmlDocument xmldoc = xmld.GenerateXMLDocumentFromArcheoObjectList(archeoObjectCol);
            xmld.SaveXMLDocumentAsFile(xmldoc, GetApplicationDataXMLFile());
            //throw new NotImplementedException();
        }

        internal void ShowArcheoCatalogDetail(string code)
        {
            ArcheoCatalogDetail archeoDetail = new ArcheoCatalogDetail(this, code);
            
            SetArcheoDetail(code, archeoDetail);
            //throw new NotImplementedException();
        }

        private void SetArcheoDetail(string code, ArcheoCatalogDetail archeoDetail)
        {
            ArcheoObject archeoObj = GetArcheoObjFromCol(code);
            //Todo: Select das Element mit dem Code, better 
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
            archeoDetail.SetPictureBox(archeoObj.GetImagelink());
            archeoDetail.setImageLink(archeoObj.GetImagelink());

            archeoDetail.Show();
            archeoDetail.BringToFront();
            archeoDetail.Focus();
            archeoDetail.Activate();
        }

        internal void GetNextArcheObjFromCol(ArcheoCatalogDetail archeoDetail)
        {
            int x = archeoObjectCol.LastIndexOf(GetArcheoObjFromCol(archeoDetail.getCode())) + 1;
            ArcheoObject archeoObj = (ArcheoObject)archeoObjectCol[x];
            SetArcheoDetail(archeoObj.GetCode(), archeoDetail);
        }

        internal void GetBackArcheObjFromCol(ArcheoCatalogDetail archeoDetail)
        {
            int x = archeoObjectCol.LastIndexOf(GetArcheoObjFromCol(archeoDetail.getCode())) - 1;
            ArcheoObject archeoObj = (ArcheoObject)archeoObjectCol[x];
            SetArcheoDetail(archeoObj.GetCode(), archeoDetail);
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

        public string[,] GetAllPicturesPathInDirectoryWithShortAndLongPath()
        {
            string[] longpath = GetAllPicturesPathInDirectory();
            string[,] Paths = new string[longpath.Length, 2];

            for (int i = 0; i < longpath.Length; i++)
            {
                string shortpath = longpath[i].Substring(longpath[i].LastIndexOf("\\") + 1);

                Paths[i, 0] = longpath[i];
                Paths[i, 1] = shortpath;
            }

            return Paths;
        }
        public ArrayList GetArcheoObjectCollection()
        {
            return archeoObjectCol;
        }

    }
}
