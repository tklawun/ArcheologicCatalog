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
    public partial class ArcheoObjectDetailForm : Form
    {
        ArcheoObjectViewCtl archeoObjectViewCtl;
        ArcheoObject archeoObject;
        public ArcheoObjectDetailForm(ArcheoObjectViewCtl archeoObjectViewCtl)
        {
            this.archeoObjectViewCtl = archeoObjectViewCtl;
            
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            archeoObject = new ArcheoObject();
            archeoObject.SetCode(this.textBoxCode.Text);
            archeoObject.SetCoordinate(this.textBoxCoordinate.Text);
            try
            {
                archeoObject.SetDepth(int.Parse(this.textBoxDepth.Text));
            }
            catch
            {
                this.textBoxDepth.Text = "000";
                this.labelExamDepth.BackColor = Color.Red;
            }
            archeoObject.SetDescription(this.textBoxDescription.Text);
            try
            {
                archeoObject.SetHeight(int.Parse(this.textBoxHeight.Text));
            }
            catch
            {
                this.textBoxHeight.Text = "000";
                this.labelExamHeight.BackColor = Color.Red;
            }
            archeoObject.SetImagelink(this.textBoxPicturePath.Text);
            archeoObject.SetParticularities(this.textBoxParticularities.Text);
            archeoObject.SetTitle(this.textBoxTitle.Text);
            archeoObject.SetTypOfBuild(this.textBoxTypeOfBuild.Text);
            archeoObject.SetTypOfCoordinate(this.textBoxTypeOfCoordinate.Text);
            try
            {
                archeoObject.SetWidth(int.Parse(this.textBoxWidth.Text));
            }
            catch
            {
                this.textBoxWidth.Text = "000";
                this.labelExamWidth.BackColor = Color.Red;
            }
            ArcheoObjectCtl archeoObjectCtl = new ArcheoObjectCtl();
            archeoObjectCtl.SetArcheoObject(archeoObject);
            this.buttonSave.Enabled = false;
        }

        internal void SetArcheoObjectInForm(ArcheoObject archeoObject)
        {
            this.archeoObject = archeoObject;
            this.textBoxCode.Text = archeoObject.GetCode();
            this.textBoxCoordinate.Text = archeoObject.GetCoordinate();
            this.textBoxDepth.Text = archeoObject.GetDepth().ToString();
            this.textBoxDescription.Text = archeoObject.GetDescription();
            this.textBoxHeight.Text = archeoObject.GetHeight().ToString();
            this.textBoxParticularities.Text = archeoObject.GetParticularities();
            this.textBoxPicturePath.Text = archeoObject.GetShortPath();
            this.textBoxTitle.Text = archeoObject.GetTitle();
            this.textBoxTypeOfBuild.Text = archeoObject.GetTypeOfBuild();
            this.textBoxTypeOfCoordinate.Text = archeoObject.GetTypeOfCoordinate();
            this.textBoxWidth.Text = archeoObject.GetWidth().ToString();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxTypeOfBuild_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(this.textBoxHeight.Text, out int number)))
            {
                this.textBoxHeight.Text = "000";
                this.labelExamHeight.BackColor = Color.Red;
            }
            else
            {
                this.labelExamHeight.BackColor = this.BackColor;
            }
            this.buttonSave.Enabled = true;
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(this.textBoxWidth.Text, out int number)))
            {
                this.textBoxHeight.Text = "000";
                this.labelExamHeight.BackColor = Color.Red;
            }
            else
            {
                this.labelExamWidth.BackColor = this.BackColor;
            }
            this.buttonSave.Enabled = true;
        }

        private void textBoxDepth_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(this.textBoxDepth.Text, out int number)))
            {
                this.textBoxDepth.Text = "000";
                this.labelExamDepth.BackColor = Color.Red;
            }
            else
            {
                this.labelExamDepth.BackColor = this.BackColor;
            }
            this.buttonSave.Enabled = true;
        }

        private void textBoxTypeOfCoordinate_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxCoordinate_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxPicturePath_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxParticularities_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void ArcheoObjectDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTypeOfBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxTypeOfBuild.Text = this.comboBoxTypeOfBuild.SelectedItem.ToString();
            
            this.buttonSave.Enabled = true;

        }
    }
}
