using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassic
{
    public partial class ArcheoCatalogConfig : Form
    {
        public ArcheoCatalogConfig()
        {
            InitializeComponent();
        }

        private void TextBoxCoisedDirectory_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
                    }

        private void TextBoxCoisedDirectory_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void FolderBrowserDialogImageDirectory_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
