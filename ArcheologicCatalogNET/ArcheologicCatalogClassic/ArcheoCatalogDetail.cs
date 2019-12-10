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
    public partial class ArcheoCatalogDetail : Form
    {
        public ArcheoCatalogDetail()
        {
            InitializeComponent();
        }

        private void ArcheoCatalogDetail_Load(object sender, EventArgs e)
        {

        }

        private void labelCode_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelCoordinate_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeOfCoordinate_Click(object sender, EventArgs e)
        {

        }

        private void labelDepth_Click(object sender, EventArgs e)
        {

        }

        private void labelWidth_Click(object sender, EventArgs e)
        {

        }

        private void labelHeight_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeOfBuild_Click(object sender, EventArgs e)
        {

        }

        private void labelParticularities_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

public void setTitle (string title)
        {
            textBoxTitle.Text = title;
          }
  public  string getTitle()
        {
            return textBoxTitle.Text;
        }
        public void setCode(string code)
        {
            textBoxCode.Text = code;
        }
        public string getCode()
        {
            return textBoxCode.Text;
        }

        public void setTypeOfBuild(string typeOfBuild)
        {
            textBoxTypeOfBuild.Text = typeOfBuild;
        }
        public string getTypeOfBuild()
        {
            return textBoxTypeOfBuild.Text;
        }
        public void setHeight(string Height)
        {
            textBoxHeight.Text = Height;
        }
        public string getHeight()
        {
            return textBoxHeight.Text;
        }
        public void setWidth(string Width)
        {
            textBoxWidth.Text = Width;
        }
        public string getWidth()
        {
            return textBoxWidth.Text;
        }
        public void setDepth(string Depth)
        {
            textBoxDepth.Text = Depth;
        }
        public string getDepth()
        {
            return textBoxDepth.Text;
        }
        public void setTypeOfCoordinate(string TypeOfCoordinate)
        {
            textBoxTypeOfCoordinate.Text = TypeOfCoordinate;
        }
        public string getTypeOfCoordinate()
        {
            return textBoxTypeOfCoordinate.Text;
        }
        public void setCoordinate(string Coordinate)
        {
            textBoxCoordinate.Text = Coordinate;
        }
        public string getCoordinate()
        {
            return textBoxCoordinate.Text;
        }
        public void setDescription(string Description)
        {
            textBoxDescription.Text = Description;
        }
        public string getDescription()
        {
            return textBoxDescription.Text;
        }
        public void setParticularities(string Particularities)
        {
            textBoxParticularities.Text = Particularities;
        }
        public string getParticularities()
        {
            return textBoxParticularities.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
