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
        ArrayList archeoObjColl = new ArrayList();

        internal ProgramCtl prgCtl { get; private set; }

        public ArcheoCatalogList()
        {
            InitializeComponent();
        }

        public ArcheoCatalogList(ArrayList archeoObjCol)
        {
            archeoObjColl = archeoObjCol;
            InitializeComponent();
        }
        public ArcheoCatalogList(ProgramCtl programControl)
        {
            prgCtl = programControl;
            InitializeComponent();
        }

        public void AddListWithEntries(string code, string imagePath)
        {
            //ImageList imageList1 = new ImageList();
            DirectoryInfo dir = new DirectoryInfo(imagePath);

            listViewArcheoObjects.Items.Add(code);

        }

        internal void SetListView(ArrayList archeoObjCol)
        {
            int ListLenght = archeoObjCol.Count;
            //todo: Generiere die ListView mit Images..... 
            int i = 0;
            foreach(ArcheoObject archObj in archeoObjCol)
            {
                listViewArcheoObjects.Items.Add(archObj.GetCode(),i);
                i++;
            }
            //throw new NotImplementedException();
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
            ListViewItem selectedItem = listViewArcheoObjects.SelectedItems[0];
            string code = selectedItem.Text;
            
            ArcheoCatalogDetail archeoDetail = new ArcheoCatalogDetail(this.prgCtl, code);
          
            archeoDetail.Show();
        }
    }
}
