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
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imageLink = openFileDialog1.FileName;
                    Image image = Image.FromFile(imageLink);
                    pictureBox1.Image = image;

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }
    }
}
