using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassic
{
    public partial class ArcheoCatalogDetail : Form
    {

        private ProgramCtl prgCtl;
        private ArcheoObject archeoObj;
        public ArcheoCatalogDetail()
        {
            InitializeComponent();
        }

        public ArcheoCatalogDetail(ProgramCtl programControl, string code)
        {
            InitializeComponent();
            prgCtl = programControl;

            archeoObj = prgCtl.GetArcheoObjFromCol(code);
            //Todo: Select das Element mit dem Code
            //setTitle(archeoObj.GetTitle());
            //setCode(archeoObj.GetCode());
            //setWidth(archeoObj.GetWidth().ToString());
            //setHeight(archeoObj.GetHeight().ToString());
            //setDepth(archeoObj.GetDepth().ToString());
            //setDescription(archeoObj.GetDescription());
            //setCoordinate(archeoObj.GetCoordinate());
            //setParticularities(archeoObj.GetParticularities());
            //setTypeOfBuild(archeoObj.GetTypeOfBuild());
            //SetPictureBox(archeoObj.GetImagelink());
            //setTypeOfCoordinate(archeoObj.GetTypeOfCoordinate());
        }
        private void ArcheoCatalogDetail_Load(object sender, EventArgs e)
        {

        }

        private void labelCode_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelCoordinate_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeOfCoordinate_Click(object sender, EventArgs e)
        {

        }

        private void labelDepth_Click(object sender, EventArgs e)
        {

        }

        private void labelWidth_Click(object sender, EventArgs e)
        {

        }

        private void labelHeight_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeOfBuild_Click(object sender, EventArgs e)
        {

        }

        private void labelParticularities_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        public void setTitle(string title)
        {
            textBoxTitle.Text = title;
        }
        public string getTitle()
        {
            return textBoxTitle.Text;
        }
        public void setCode(string code)
        {
            textBoxCode.Text = code;
        }
        public string getCode()
        {
            return textBoxCode.Text;
        }

        public void setTypeOfBuild(string typeOfBuild)
        {
            textBoxTypeOfBuild.Text = typeOfBuild;
        }
        public string getTypeOfBuild()
        {
            return textBoxTypeOfBuild.Text;
        }
        public void setHeight(string Height)
        {
            textBoxHeight.Text = Height;
        }
        public string getHeight()
        {
            return textBoxHeight.Text;
        }
        public void setWidth(string Width)
        {
            textBoxWidth.Text = Width;
        }
        public string getWidth()
        {
            return textBoxWidth.Text;
        }
        public void setDepth(string Depth)
        {
            textBoxDepth.Text = Depth;
        }
        public string getDepth()
        {
            return textBoxDepth.Text;
        }
        public void setTypeOfCoordinate(string TypeOfCoordinate)
        {
            textBoxTypeOfCoordinate.Text = TypeOfCoordinate;
        }
        public string getTypeOfCoordinate()
        {
            return textBoxTypeOfCoordinate.Text;
        }
        public void setCoordinate(string Coordinate)
        {
            textBoxCoordinate.Text = Coordinate;
        }
        public string getCoordinate()
        {
            return textBoxCoordinate.Text;
        }
        public void setDescription(string Description)
        {
            textBoxDescription.Text = Description;
        }
        public string getDescription()
        {
            return textBoxDescription.Text;
        }
        public void setParticularities(string Particularities)
        {
            textBoxParticularities.Text = Particularities;
        }
        public string getParticularities()
        {
            return textBoxParticularities.Text;
        }
        public string getImageLink()
        {
            return linkLabelImagePath.Text;
        }
        public string getShortPath()
        {
            //Todo: Link irgendwie reinbringen
            return prgCtl.GetShortPathFromLongPath(linkLabelImagePath.Text);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Todo: Das ist ja falsch.. man muss das bestehende Object verändern. 
            //Es fehlt wie nach dem Objekt gesucht werden soll. 0 nach Code, 1 nach Title, 2 nach Pfad????
            prgCtl.SetArcheoObjInCol(2, getTitle(), getCode(), getTypeOfBuild(), getHeight(), getWidth(), getDepth(), getTypeOfCoordinate(), getCoordinate(), getDescription(), getImageLink(), getShortPath(), getParticularities());
            prgCtl.SaveArcheoObjIntoXML();
        }

        private void pictureBoxObject_Click(object sender, EventArgs e)
        {

        }
        public void SetPictureBox(string ImageLink)
        {
            try
            {
                //TODO: Image Link mit fullpath setzen
                string fullImageLink = prgCtl.GetPicturesPath() + "\\" + ImageLink;
                Image image = Image.FromFile(fullImageLink);
                pictureBoxObject.Image = image;
                pictureBoxObject.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                Image image = Properties.Resources.ImageCantLoad;
                pictureBoxObject.Image = image;
                pictureBoxObject.SizeMode = PictureBoxSizeMode.Zoom;
                Console.WriteLine(ImageLink + " cannot load");
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void setImageLink(string ImageLink)
        {
            linkLabelImagePath.Text = ImageLink;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            prgCtl.ExitApplication();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //TODO: gehe zum vorherigen Bild
            prgCtl.GetBackArcheObjFromCol(this);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //TODO: Gehe zum nächsten Bild-
            prgCtl.GetNextArcheObjFromCol(this);
        }
    }
}
