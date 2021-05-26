using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheologicCatalogClassicV3.Tests;
namespace ArcheologicCatalogClassicV3
{
    public partial class ArcheologCatalogList : Form
    {
        private ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheologCatalogList()
        {
            //Test Verknüpfung mit Azure Storage Tables
            //TestAzureTables testAzureTables = new TestAzureTables();
            //testAzureTables.RunSamples().Wait();

            archeoObjectViewCtl = new ArcheoObjectViewCtl(this);
            InitializeComponent();
            listViewArcheoObjects.View = View.SmallIcon;
            listViewArcheoObjects.FullRowSelect = true;
            archeoObjectViewCtl.SetArcheoObjectListInView();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //TODO: es die Combobox muss neu gefüllt werden. 
            archeoObjectViewCtl.CreateArcheoObjectDetailView(null);
        }

        internal void SetListView(Dictionary<string, ArcheoObject> archeoObjects)
        {
            this.listViewArcheoObjects.Items.Clear();

            this.listViewArcheoObjects.GridLines = true;
            ImageList imageListSmall = new ImageList
            {
                ImageSize = new Size(100, 100)
            };
            listViewArcheoObjects.SmallImageList = imageListSmall;
            listViewArcheoObjects.LargeImageList = imageListSmall;
            listViewArcheoObjects.BeginUpdate();
            foreach (ArcheoObject key in archeoObjects.Values)
            {
                ListViewItem item = new ListViewItem(key.CodeOut);
                item.SubItems.Add(key.IdOut);
                if (new FilePaths().IsFileExists(key.PictureLinkOut))
                {
                    imageListSmall.Images.Add(Bitmap.FromFile(key.PictureLinkOut));
                }
                this.listViewArcheoObjects.Items.Add(item);
                item.ImageIndex = listViewArcheoObjects.Items.IndexOf(item);
            }

            listViewArcheoObjects.EndUpdate();
            this.Controls.Add(listViewArcheoObjects);
            this.Refresh();
        }
        private void listViewArcheoObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewArcheoObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.labelStatus.Visible = false;
            this.labelStatus.ForeColor = Color.Black;
            ListView.SelectedListViewItemCollection archeoObjectCodeList = this.listViewArcheoObjects.SelectedItems;
            try
            {
                string archeObjectCode = archeoObjectCodeList[0].Text;
                string archeObjectId = archeoObjectCodeList[0].SubItems[1].Text;
                archeoObjectViewCtl.CreateArcheoObjectDetailView(archeObjectId);
            }
            catch (Exception)
            {
                this.labelStatus.Text = "Element not found!";
                this.labelStatus.Visible = true;
                this.labelStatus.ForeColor = Color.Red;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.CloseApplication();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.OpenConfigDialog();
        }
       
        private void ArcheologCatalogList_Load(object sender, EventArgs e)
        {

        }
    }
}
