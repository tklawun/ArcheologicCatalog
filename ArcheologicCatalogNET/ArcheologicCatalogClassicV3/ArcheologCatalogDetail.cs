﻿using System;
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
        private ArcheoObjectViewCtl archeoObjectViewCtl;
        private Boolean IsChanged;
        internal ArcheologCatalogDetail(ArcheoObjectViewCtl archeoObjectViewCtl)
        {
            this.archeoObjectViewCtl = archeoObjectViewCtl;
            InitializeComponent();
        }

        internal void FillComboFields()
        {
            this.comboBoxRockTyp.Items.Clear();
            this.comboBoxTypeOfBuild.Items.Clear();
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
            SaveDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveArcheoObject();
        }

        private void SaveArcheoObject()
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
            openFileDialog1.InitialDirectory = new FilePaths().GetSelectPicturePath();
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
            this.IsChanged = true;
        }

        private void ArcheologCatalogDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDialog();
        }

        private int SaveDialog()
        {
            int NoCancel = 0;
            if (this.IsChanged)
            {
                string message = "Die Daten wurden nicht gespeichert, jetzt speichern?";
                string caption = "Daten nicht gespeichert!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.SaveArcheoObject();
                    this.Visible = false;
                    NoCancel = 1;
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Visible = true;
                    NoCancel = 2;
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Visible = false;
                    NoCancel = 3;
                }

            }
            return NoCancel;
        }

        private void buttonExportToWord_Click(object sender, EventArgs e)
        {
            int ResultSave = SaveDialog();
            if (ResultSave == 1)
            {
                this.SaveArcheoObject();
                this.archeoObjectViewCtl.exportToWord(this.textBoxCode.Text);
            }
            else if( ResultSave == 3)
            {
                this.archeoObjectViewCtl.exportToWord(this.textBoxCode.Text);
            }
            else if (ResultSave == 2)
            {
                
            }
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int ResultSave = SaveDialog();
            if (ResultSave == 1)
            {
                this.SaveArcheoObject();
                this.archeoObjectViewCtl.GetBeforArcheoObject(this.textBoxCode.Text);
            }
            else if (ResultSave == 3)
            {
                this.archeoObjectViewCtl.GetBeforArcheoObject(this.textBoxCode.Text);
            }
            else if (ResultSave == 2)
            {

            }
          
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int ResultSave = SaveDialog();
            if (ResultSave == 1)
            {
                this.SaveArcheoObject();
                this.archeoObjectViewCtl.GetNextArcheoObject(this.textBoxCode.Text);
            }
            else if (ResultSave == 3)
            {
                this.archeoObjectViewCtl.GetNextArcheoObject(this.textBoxCode.Text);
            }
            else if (ResultSave == 2)
            {

            }
        }

        private void textBoxCoordinate_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void textBoxDepth_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void comboBoxRockTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void textBoxSpecialFeatures_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }
    }
}
