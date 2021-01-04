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
         internal ArcheologCatalogDetail(ArcheoObjectViewCtl archeoObjectViewCtl)
        {
            this.archeoObjectViewCtl = archeoObjectViewCtl;
            InitializeComponent();
            this.comboBoxTypeOfBuild.Items.AddRange(this.archeoObjectViewCtl.GetItemsTypeOfBuild());
            this.comboBoxRockTyp.Items.AddRange(this.archeoObjectViewCtl.GetItemsRockType());
        }

        internal void SetArcheoObjectInForm(ArcheoObject archeoObject)
        {
            this.textBoxCode.Text = archeoObject.CodeOut;
            this.textBoxCoordinate.Text = archeoObject.CoordinatesOut;
            this.comboBoxTypeOfBuild.Text = archeoObject.TypOfBuildOut;
            this.textBoxDepth.Text = archeoObject.DepthOut;
            this.textBoxDescription.Text = archeoObject.DescriptionOut;
            this.textBoxHeight.Text = archeoObject.HeightOut;
            this.textBoxSpecialFeatures.Text = archeoObject.SpecialFeaturesOut;
            this.textBoxWidth.Text = archeoObject.WidthOut;
            this.textBoxDepth.Text = archeoObject.DepthOut;
            this.comboBoxRockTyp.Text = archeoObject.RockTypeOut;
            this.pictureBox1.ImageLocation = archeoObject.PictureLinkOut;
        }

        internal void ClearArcheoObjectInForm()
        {
            this.textBoxCode.Text = "";
            this.textBoxCoordinate.Text = "";
            this.comboBoxTypeOfBuild.Text = "";
            this.textBoxDepth.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxSpecialFeatures.Text = "";
            this.textBoxWidth.Text = "";
            this.textBoxDepth.Text = "";
            this.comboBoxRockTyp.Text = "";
            this.pictureBox1.ImageLocation = "";
        }

        private void ArcheologCatalogDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ArcheoObject archeoObject = new ArcheoObject
            {
                CodeOut = this.textBoxCode.Text,
                CoordinatesOut = this.textBoxCoordinate.Text,
                TypOfBuildOut = this.comboBoxTypeOfBuild.Text,
                DepthOut = this.textBoxDepth.Text,
                DescriptionOut = this.textBoxDescription.Text,
                HeightOut = this.textBoxHeight.Text,
                SpecialFeaturesOut = this.textBoxSpecialFeatures.Text,
                WidthOut = this.textBoxWidth.Text,
                RockTypeOut = this.comboBoxRockTyp.Text,
                PictureLinkOut = this.pictureBox1.ImageLocation
            };

            this.archeoObjectViewCtl.SaveArcheoObjectInList(archeoObject);
            
            archeoObjectViewCtl.SetStatus(archeoObject.CodeOut + " gespeichert.", false);
        }

        private void buttonChoisePicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = new FilePaths().getSelectPicturePath();
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

        private void ArcheologCatalogDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonExportToWord_Click(object sender, EventArgs e)
        {
            this.archeoObjectViewCtl.exportToWord(this.textBoxCode.Text);
        }
    }
}
