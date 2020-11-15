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
        public ArcheoObjectListForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ArcheoObjectDetailForm archeoObjectDetail = new ArcheoObjectDetailForm();
            archeoObjectDetail.Show();
        }
    }
}
