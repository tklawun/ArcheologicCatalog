using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassic
{
    public partial class ArcheoCatalogList : Form
    {
        private ProgramCtl prgCtl;

        public ArcheoCatalogList()
        {
            InitializeComponent();
        }

        public ArcheoCatalogList(ProgramCtl programControl)
        {
            InitializeComponent();
            prgCtl = programControl;
        }

        internal void SetListView()
        {
            listViewArcheoObjects = prgCtl.SetListView();
            Refresh();
        }
        internal void clearListView()
        {
            listViewArcheoObjects.Clear();
        }
        private void buttonChangeListView_Click(object sender, EventArgs e)
        {
            listViewArcheoObjects.View = View.List;
        }

        private void buttonListViewDetails_Click(object sender, EventArgs e)
        {
            listViewArcheoObjects.View = View.Details;
        }

        private void buttonChangeSmallIcon_Click(object sender, EventArgs e)
        {
            listViewArcheoObjects.View = View.SmallIcon;
        }

        private void buttonChangeLargeIcon_Click(object sender, EventArgs e)
        {
            listViewArcheoObjects.View = View.LargeIcon;
        }

        private void listViewArcheoObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewArcheoObjects.IsHandleCreated)
            {
                prgCtl.ShowArcheoCatalogDetail(listViewArcheoObjects.SelectedItems[0].Text);
            }
            
        }

        private void buttonRefreshPic_Click(object sender, EventArgs e)
        {
            prgCtl.RefreshArcheoListView();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            prgCtl.ExitApplication();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            prgCtl.addNewPictureIntoList();
        }
    }
}


