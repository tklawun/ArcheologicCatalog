﻿using System;
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
        private ProgramCtl prgCtl;
        public ArcheoObjectStart()
        {
            InitializeComponent();

            prgCtl = new ProgramCtl();
            prgCtl.Start();
            //ArcheoObjCol = prgCtl.GetArcheoObjCol();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            //Show List as form
            prgCtl.ViewArcheObjectList();

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            //Start Config Form
           prgCtl.startConfigDialog();
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
