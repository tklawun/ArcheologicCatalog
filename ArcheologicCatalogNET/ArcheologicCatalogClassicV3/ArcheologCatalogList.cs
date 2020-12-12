using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassicV3
{
    public partial class ArcheologCatalogList : Form
    {
        ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheologCatalogList()
        {
            archeoObjectViewCtl = new ArcheoObjectViewCtl(this);
            InitializeComponent();
            archeoObjectViewCtl.SetArcheoObjectListInView();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

            archeoObjectViewCtl.CreateArcheoObjectDetailView(null);
        }

        internal void SetListView(Dictionary<string, ArcheoObject>.KeyCollection keys)
        {
            this.listViewArcheoObjects.Items.Clear();
            foreach (string key in keys)
            {
                this.listViewArcheoObjects.Items.Add(key);
            }
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
           // try
            //{
                string archeObjectCode = archeoObjectCodeList[0].Text;
                archeoObjectViewCtl.CreateArcheoObjectDetailView(archeObjectCode);
            //}
            //catch (Exception)
            //{
            //    this.labelStatus.Text = "Element not found!";
            //    this.labelStatus.Visible = true;
            //    this.labelStatus.ForeColor = Color.Red;
            //}
        }
    }
}
