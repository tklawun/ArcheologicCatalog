using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace ArcheologicCatalogClassic
{
    public partial class ArcheoObjectStart : Form
    {
        private ArrayList ArcheoObjCol;
        private ProgramCtl prgCtl;
        public ArcheoObjectStart()
        {
            prgCtl = new ProgramCtl();
            prgCtl.Start();
            ArcheoObjCol = prgCtl.GetArcheoObjCol();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Show List as form
            prgCtl.ViewArcheObjectList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArcheoCatalogDetail detail = new ArcheoCatalogDetail();
            XmlData xmld = new XmlData();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
            }
            catch (Exception)
            {
                throw;
            }

            ArcheoObject archeoObj = prgCtl.GetArcheoObjFirstFromCol();
            if (archeoObj == null)
            {
                detail.setCode("Your code");
                detail.setCoordinate("the coordinate");
                detail.setDepth("object depth");
                detail.setDescription("your description");
                detail.setHeight("object height");
                detail.setParticularities("your particularities");
                detail.setTitle("your title");
                detail.setTypeOfBuild("typ of build");
                detail.setTypeOfCoordinate("type of coordinate");
                detail.setWidth("object width");
            }
            else
            {
                detail.setCode(archeoObj.GetCode());
                detail.setCoordinate(archeoObj.GetCoordinate());
                detail.setDepth(archeoObj.GetDepth().ToString());
                detail.setDescription(archeoObj.GetDescription());
                detail.setHeight(archeoObj.GetHeight().ToString());
                detail.setParticularities(archeoObj.GetParticularities());
                detail.setTitle(archeoObj.GetTitle());
                detail.setTypeOfBuild(archeoObj.GetTypeOfBuild());
                detail.setTypeOfCoordinate(archeoObj.GetTypeOfCoordinate());
                detail.setWidth(archeoObj.GetWidth().ToString());
            }
            detail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prgCtl.SetArcheoObjCol();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ArcheoCatalogConfig config = new ArcheoCatalogConfig();
            config.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            prgCtl.ExitApplication();
        }

        //private void minimizeButton_Click(object sender, System.EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}

        //private void maximizeButton_Click(object sender, System.EventArgs e)
        //{
        //    WindowState = FormWindowState.Maximized;
        //}

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            prgCtl.ExitApplication();
        }
    }
}
