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
    public partial class ArcheologCatalogDetail : Form
    {
        ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheologCatalogDetail(ArcheoObjectViewCtl archeoObjectViewCtl)
        {
            this.archeoObjectViewCtl = archeoObjectViewCtl;
            InitializeComponent();
        }

        internal void SetArcheoObjectInForm(ArcheoObject archeoObject)
        {
            this.textBoxCode.Text = archeoObject.CodeOut;
            this.textBoxCoordinate.Text = archeoObject.CoordinatesOut;
            this.textBoxDepth.Text = archeoObject.DepthOut;
            this.textBoxDescription.Text = archeoObject.DesignationOut;
            this.textBoxHeight.Text = archeoObject.HeightOut;
            this.textBoxSpecialFeatures.Text = archeoObject.SpecialFeaturesOut;
            this.textBoxWidth.Text = archeoObject.WidthOut;
            this.textBoxDepth.Text = archeoObject.DepthOut;
            this.textBoxRockType.Text = archeoObject.RockTypeOut;
            this.pictureBox1.ImageLocation = archeoObject.PicturelinkOut;
        }

        private void ArcheologCatalogDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ArcheoObject archeoObject = new ArcheoObject
            {
                CodeOut = this.textBoxCode.Text,
                CoordinatesOut = this.textBoxCoordinate.Text,
                DepthOut = this.textBoxDepth.Text,
                DesignationOut = this.textBoxDescription.Text,
                HeightOut = this.textBoxHeight.Text,
                SpecialFeaturesOut = this.textBoxSpecialFeatures.Text,
                WidthOut = this.textBoxWidth.Text,
                RockTypeOut = this.textBoxRockType.Text,
                PicturelinkOut = this.pictureBox1.ImageLocation
            };

            this.archeoObjectViewCtl.SaveArcheoObjectInList(archeoObject);
        }

        private void buttonChoisePicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
