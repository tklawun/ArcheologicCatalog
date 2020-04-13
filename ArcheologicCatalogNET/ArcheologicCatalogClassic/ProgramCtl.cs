using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using MessageBox = System.Windows.MessageBox;

namespace ArcheologicCatalogClassic
{
    public class ProgramCtl
    {
        private string pathOfPictures;
        private const string constDataXMLFile = "ArcheoCatalogData.xml";
        private ArrayList archeoObjectCol;
        private ArcheoCatalogList archeoListView;
        private XmlData XmlDataObj;
        private RegCtl reg;
        private CodeGenerator codeGen;
        //private string[] picturesPath;

        internal void choisPic(ArcheoCatalogAddNewPic archeoCatalogAddNewPic)
        {
            //throw new NotImplementedException();
            //string fileDir = prgCtl.GetPicturesPath();
            //openFileDialog1.InitialDirectory = fileDir;
            //openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 1;
            //openFileDialog1.RestoreDirectory = true;
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        string imageLink = openFileDialog1.FileName;
            //        Image image = Image.FromFile(imageLink);
            //        pictureBox1.Image = image;
            //        linkLabel1.Text = imageLink;

            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }

            //}
        }

        internal void copyFileToPictureFolder(string picPath)
        {
            int last = picPath.LastIndexOf("\\") + 2;

            string fileName = picPath.Substring(last);
            string destFile = pathOfPictures + "\\"+ fileName;
            if (System.IO.File.Exists(destFile))
            {
                string messageBoxText = "Do you want to overwrite the picture?";
                string caption = "Picture exists warning!";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);

                // Process message box results
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        // User pressed Yes button
                        System.IO.File.Copy(picPath, destFile, true);
                        break;
                    case MessageBoxResult.No:
                        // User pressed No button
                        // ...
                        break;
          
                }
            }
            else
            {
                System.IO.File.Copy(picPath, destFile);
            }
            

        }

        //TODO: Singleton Pattern

        public void Start()
        {
            XmlDataObj = new XmlData();
            reg = new RegCtl(this);
            codeGen = new CodeGenerator(this);
            //TODO: ist es der erste Start muss das Bild Verzeichnis ausgewählt werden. 
            LoadXMLDataAndPathAndCreateNewArcheoObj();
        }

        public void LoadXMLDataAndPathAndCreateNewArcheoObj()
        {
            //Todo: Bau es um, damit nur gespeicherte Bilder geladen werden. Alle anderen per PicUp Funktion hinzufügen.
            
            pathOfPictures = GetPicturesPath();
            //listOfPics = GetAllPicturesPathInDirectory(true);
            archeoObjectCol = new ArrayList();
            archeoObjectCol = SetArcheoObjCol();
        }

        internal void startConfigDialog()
        {
            ArcheoCatalogConfig config = new ArcheoCatalogConfig(this);
            string path = reg.GetPathForPictureFolderFromRegistry();
            if (path == "null")
            {
                config.SetPathInTextField(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            }
            else
            {
                config.SetPathInTextField(path);
            }
            config.Activate();
            config.Show();
        }

        internal void SetPathForPictureFolderIntoRegistry(string text)
        {
            reg.SetPathForPictureFolderIntoRegistry(text);
            LoadXMLDataAndPathAndCreateNewArcheoObj();
            SaveArcheoObjIntoXML();
        }

        public void ViewArcheObjectList()
        {
            archeoListView = new ArcheoCatalogList(this);
            RefreshArcheoListView();
            archeoListView.Show();

        }
        //private void MatchImageListWithArcheoObjectList()
        //{
        //    int i = 0;
        //    Boolean ifPicInArcheoObjList = false;
        //    foreach (string imageLink in listOfPics)
        //    {
        //        ifPicInArcheoObjList = false;
        //        foreach (ArcheoObject archeoObj in archeoObjectCol)
        //        {
        //            if (imageLink == archeoObj.GetImagelink())
        //            {
        //                ifPicInArcheoObjList = true;
        //                break;
        //            }
        //        }
        //        if (!ifPicInArcheoObjList)
        //        {
        //            string code = i.ToString() + " --> Type new code";
        //            string title = i.ToString() + "--> New";
        //            //Todo: Wie baue ich das am besten den ShortPath Wert zusammen? 
        //            string shortPath = GetShortPathFromLongPath(imageLink);
        //            AddArcheoObjectToCol("New", code, "Typ of build", "0", "0", "0", "Typ of coordinate", "Coordinate", "Description", imageLink, shortPath, "Particularities");
        //        }
        //        i++;
        //    }
        //    //throw new NotImplementedException();
        //}

        public string GetApplicationDataXMLFile()
        {
            string appDataXMLFile = pathOfPictures + "\\" + constDataXMLFile;
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
            System.Windows.Forms.Application.Exit();
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

        internal void SaveArcheoObjIntoXML()
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

        internal void addNewPictureIntoList()
        {
            ArcheoCatalogAddNewPic archeoNewPic = new ArcheoCatalogAddNewPic(this);
            archeoNewPic.Show();
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
            try
            {
                ArcheoObject archeoObj = (ArcheoObject)archeoObjectCol[x];
                SetArcheoDetail(archeoObj.GetCode(), archeoDetail);
            }
            catch (Exception)
            {
                //TODO: Ausnahmefehler OutOIndex Warum erscheinen die Bilder zwei mal in der Liste?
                Console.WriteLine("Fehler im Index. Element wird nicht gefunden, da die Bilder zwei Mal ");
                //throw;
            }

        }

        internal void GetArcheObjFromColByPath(ArcheoCatalogDetail archeoDetail)
        {

            for (int i = 0; i < archeoObjectCol.Count; i++)
            {

            }
        }

        internal void GetBackArcheObjFromCol(ArcheoCatalogDetail archeoDetail)
        {
            int x = archeoObjectCol.LastIndexOf(GetArcheoObjFromCol(archeoDetail.getCode())) - 1;
            try
            {
                ArcheoObject archeoObj = (ArcheoObject)archeoObjectCol[x];
                SetArcheoDetail(archeoObj.GetCode(), archeoDetail);
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler im Index. Element wird nicht gefunden, da die Bilder zwei Mal ");
                //throw;
            }

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

        public void SetArcheoObjInCol(ArcheoObject archeoObj)
        {
            //TODO: suche das Object in der Collection. 
            // am Besten nach dem ImageLink Pfad.
            int i = 0;
            foreach (ArcheoObject item in archeoObjectCol)
            {
                if (item.GetImagelink().Equals(archeoObj.GetImagelink()))
                {
                    //Todo: Wie aktualisiere ich ein Object in einer Collection? Best Practise? 
                    archeoObjectCol.RemoveAt(i);
                    archeoObjectCol.Insert(i, archeoObj);
                    break;
                }
                i++;
            }
            // Speicher das Object neu ab und am Besten gleich in das XML File

            //aktuallisiere die Ansichten

        }
        public void SetArcheoObjInCol(int choiseSearch, string title, string code, string typOfBuild, string height, string width, string depth, string typOfCoordinate, string coordinate, string description, string imagelink, string shortPath, string particularities)
        {
            ArcheoObject archeoObj = new ArcheoObject();
            archeoObj.SetCode(code);
            archeoObj.SetCoordinate(coordinate);
            archeoObj.SetDepth(int.Parse(depth));
            archeoObj.SetDescription(description);
            archeoObj.SetHeight(int.Parse(height));
            archeoObj.SetImagelink(imagelink);
            archeoObj.SetParticularities(particularities);
            archeoObj.SetShortPath(shortPath);
            archeoObj.SetTitle(title);
            archeoObj.SetTypOfBuild(typOfBuild);
            archeoObj.SetTypOfCoordinate(typOfCoordinate);
            archeoObj.SetWidth(int.Parse(width));
            SetArcheoObjInCol(choiseSearch, archeoObj);
        }
        public void SetArcheoObjInCol(int choiseSearch, ArcheoObject archeoObj)
        {
            //TODO:  Verschiedene Suchfelder verwenden? Wie nach Code, ImagePfad, Title? 
            switch (choiseSearch)
            {
                //0 nach Code, 1 nach Title, 2 nach Pfad
                //Suche nach Code: 
                case 0:
                    int i = 0;
                    foreach (ArcheoObject item in archeoObjectCol)
                    {
                        if (item.GetCode().Equals(archeoObj.GetCode()))
                        {
                            //Todo: Setze die Eigenschaft des Objektes und gebe das in die Collection... überschreiben? .. Habe da noch keine Idee. 
                            archeoObjectCol.RemoveAt(i);
                            archeoObjectCol.Insert(i, archeoObj);
                        }
                        i++;
                    }
                    break;
                //suche nach Title: 
                case 1:
                    i = 0;
                    foreach (ArcheoObject item in archeoObjectCol)
                    {
                        if (item.GetTitle().Equals(archeoObj.GetTitle()))
                        {
                            //Todo: Setze die Eigenschaft des Objektes und gebe das in die Collection... überschreiben? .. Habe da noch keine Idee. 
                            archeoObjectCol.RemoveAt(i);
                            archeoObjectCol.Insert(i, archeoObj);
                        }
                        i++;
                    }
                    break;
                //Suche nach ImagePfad:
                case 2:
                    i = 0;
                    foreach (ArcheoObject item in archeoObjectCol)
                    {
                        if (item.GetImagelink().Equals(archeoObj.GetImagelink()))
                        {
                            //Todo: Setze die Eigenschaft des Objektes und gebe das in die Collection... überschreiben? .. Habe da noch keine Idee. 
                            archeoObjectCol.RemoveAt(i);
                            archeoObjectCol.Insert(i, archeoObj);
                            break;
                        }
                        i++;
                    }
                    break;
                default:
                    break;
            }
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

        public string[] GetAllPicturesPathInDirectory(String directory)
        {
            String[] picturesInPath;
            picturesInPath = Directory.GetFiles(directory, "*.jpg");
            return picturesInPath;
        }
        public string[] GetAllPicturesPathInDirectory(String directory, Boolean AsShortPath)
        {

            string[] picturesPath = GetAllPicturesPathInDirectory(directory);
            string[] shortPicturesPath = new string[picturesPath.Length];
            int i = 0;
            foreach (string item in picturesPath)
            {
                shortPicturesPath[i] = GetShortPathFromLongPath(item);
                i++;
            }
            return shortPicturesPath;
        }

        public void RefreshArcheoListView()
        {
            //archeoListView.clearListView();
            archeoListView.listViewArcheoObjects = SetListView();
        }
        public string GetShortPathFromLongPath(string longPath)
        {
            string shortPath = longPath.Substring(longPath.LastIndexOf("\\") + 1);
            return shortPath;
        }

        //public string[,] GetAllPicturesPathInDirectoryWithShortAndLongPath()
        //{
        //    string[] longpath = GetAllPicturesPathInDirectory(picturesPath);
        //    string[,] Paths = new string[longpath.Length, 2];

        //    for (int i = 0; i < longpath.Length; i++)
        //    {
        //        string shortpath = longpath[i].Substring(longpath[i].LastIndexOf("\\") + 1);

        //        Paths[i, 0] = longpath[i];
        //        Paths[i, 1] = shortpath;
        //    }

        //    return Paths;
        //}
        public ArrayList GetArcheoObjectCollection()
        {
            return archeoObjectCol;
        }
        internal string GetPicturesPath()
        {
            string picturePath;
            picturePath = reg.GetPathForPictureFolderFromRegistry();
            if (picturePath == "null")
            {
                startConfigDialog();
                picturePath = reg.GetPathForPictureFolderFromRegistry();
            }
            return picturePath;
        }

        internal string GetCodePattern()
        {
            string codePattern;
            codePattern = reg.GetCodePatternFromRegistry();
            if (codePattern == "null")
            {
                startConfigDialog();
                codePattern = reg.GetPathForPictureFolderFromRegistry();
            }
            return codePattern;
        }

        internal ArrayList GetArcheoObjCol()
        {
            return archeoObjectCol;
        }
        public void SetPicPathInRegistry(string path)
        {
            reg.SetPathForPictureFolderIntoRegistry(path);
        }
        public void SetCodePatternInRegistry(string codePattern)
        {
            reg.SetCodePatternIntoRegistry(codePattern);
        }


        public ListView SetListView()
        {
            //ListView archeoObjectsListView = new ListView();
            int i = 0;
           
            //ImageList archeoObjectsImageList = new ImageList();
            foreach (ArcheoObject archObj in archeoObjectCol)
            {

                //TODO: Die Bilder können auch angezeigt werden, allerdings braucht man dazu ein Resize Image Funktion, die muss noch gebaut werden.
                string archeoObjCode = archObj.GetCode();
                string archeoObjImageLink = archObj.GetImagelink();
                ListViewItem item = new ListViewItem(archeoObjCode);
                archeoListView.listViewArcheoObjects.Items.Add(item);
                //
                //Image img = Image.FromFile(pathOfPictures + "\\" + archObj.GetImagelink());
                //archeoObjectsImageList.Images.Add(img);
                //archeoObjectsListView.Items.Add(item);
                i++;
            }
            //archeoObjectsListView.StateImageList = archeoObjectsImageList;
            
            return archeoListView.listViewArcheoObjects;
        }

        //TODO: Resizing Image
        public Image resizeImg(Image img) { 

            Image imgResize = img;
            
            //System.Drawing.Imaging

            return imgResize;
        }

        
    }
}
