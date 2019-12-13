using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ArcheologicCatalogClassic
{
    public partial class ArcheoCatalogConfig : Form
    {
        public ArcheoCatalogConfig()
        {
            InitializeComponent();
            RegCtl regctl = new RegCtl();
            textBoxChoisedDirectory.Text = regctl.GetPathForPictureFolderIntoRegistry();
        }

        private void TextBoxCoisedDirectory_DoubleClick(object sender, EventArgs e)
        {
            buttonChoisPicDir_Click(null, null);
        }

        private void buttonChoisPicDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogImageDirectory.ShowDialog() == DialogResult.OK)
            {
                textBoxChoisedDirectory.Text = folderBrowserDialogImageDirectory.SelectedPath;
                //Todo: Write to Registry
                RegCtl regctl = new RegCtl();
                regctl.SetPathForPictureFolderIntoRegistry(textBoxChoisedDirectory.Text);
            }
        }
    }
}
