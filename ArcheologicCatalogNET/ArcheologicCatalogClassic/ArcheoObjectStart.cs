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
