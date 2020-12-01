using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassicV2
{
    public partial class ArcheoObjectListForm : Form
    {
        private ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheoObjectListForm()
        {
            archeoObjectViewCtl = new ArcheoObjectViewCtl();
            archeoObjectViewCtl.CreateArcheoObjectsList(this);
            InitializeComponent();
            SetListViewArcheoObjects();
        }

        
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.CreateArcheoObjectDetailView(null);
        }

        public void SetListViewArcheoObjects()
        {
            foreach (ArcheoObject item in archeoObjectViewCtl.GetArcheoObjects())
            {
                this.listViewArcheoObjects.Items.Add(item.GetCode());
                this.listViewArcheoObjects.View = View.List;
            }
        }

        private void listViewArcheoObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //archeoObjectDetailForm.Activate();
            //TODO: selectiertes ArcheologObject in der Form platzieren
            this.labelStatus.Visible = false;
            this.labelStatus.ForeColor = Color.Black;
            ListView.SelectedListViewItemCollection archeoObjectCodeList = this.listViewArcheoObjects.SelectedItems;
            try
            {
                string archeObjectCode = archeoObjectCodeList[0].Text;
                archeoObjectViewCtl.CreateArcheoObjectDetailView(archeObjectCode);
            }
            catch (Exception)
            {
                this.labelStatus.Text = "Element not found!";
                this.labelStatus.Visible = true;
                this.labelStatus.ForeColor = Color.Red;
            }

        }
    }
}
