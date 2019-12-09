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

        private void buttonChoisPicDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogImageDirectory.ShowDialog() == DialogResult.OK)
            {
                textBoxChoisedDirectory.Text = folderBrowserDialogImageDirectory.SelectedPath;
                //Write to Registry
                string wiesolldasgehen = textBoxChoisedDirectory.Text;

                
            }
        }
    }
}
