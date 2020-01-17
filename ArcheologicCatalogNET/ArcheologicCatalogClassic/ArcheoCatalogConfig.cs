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
        ProgramCtl prgCtl; 
        public ArcheoCatalogConfig(ProgramCtl prgCtl)
        {
            InitializeComponent();
            //TODO: make this from ProgramCTL
            this.prgCtl = prgCtl;
            textBoxChoisedDirectory.Text = prgCtl.GetPicturesPath();
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
                //prgCtl.SetPathForPictureFolderIntoRegistry(textBoxChoisedDirectory.Text);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Todo: Set new pictures path and reload application with new data
            //read from registry new Folder-Information
            //load xml Application Data File
            //load PicturesList from folder
            //load ArcheoObjectCollection
            prgCtl.SetPathForPictureFolderIntoRegistry(textBoxChoisedDirectory.Text);
            prgCtl.LoadXMLDataAndPathAndMatchAndCreateNewArcheoObj(); 

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            prgCtl.ExitApplication();
        }
    }
}
