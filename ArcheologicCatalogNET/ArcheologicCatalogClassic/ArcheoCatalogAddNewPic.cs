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
    public partial class ArcheoCatalogAddNewPic : Form
    {
        ProgramCtl prgCtl;
        public ArcheoCatalogAddNewPic(ProgramCtl prgCtl)
        {
            InitializeComponent();
            //TODO: make this from ProgramCTL
            this.prgCtl = prgCtl;
        }

        private void buttonSelectPicture_Click(object sender, EventArgs e)
        {
            string fileDir = prgCtl.GetPicturesPath();
            openFileDialog1.InitialDirectory = fileDir;
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imageLink = openFileDialog1.FileName;
                    Image image = Image.FromFile(imageLink);
                    pictureBox1.Image = image;
                    linkLabel1.Text = imageLink;

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
