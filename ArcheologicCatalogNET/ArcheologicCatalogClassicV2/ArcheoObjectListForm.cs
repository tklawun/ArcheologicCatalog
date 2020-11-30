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
        ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheoObjectListForm()
        {
            archeoObjectViewCtl = new ArcheoObjectViewCtl();
            archeoObjectViewCtl.CreateArcheoObjectsList(this);
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //archeoObjectDetailForm.Activate();
            //TODO: selectiertes ArcheologObject in der Form platzieren

            ListView.SelectedListViewItemCollection archeoObjectCodeList = this.listViewArcheoObjects.SelectedItems;

            string archeObjectCode = archeoObjectCodeList[0].Text;
            archeoObjectViewCtl.CreateArcheoObjectDetailView(archeObjectCode);
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
    }
}
