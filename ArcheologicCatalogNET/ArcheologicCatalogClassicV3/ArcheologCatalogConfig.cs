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
    public partial class ArcheologCatalogConfig : Form
    {
        private ArcheoObjectViewCtl archeoObjectViewCtl;

        public ArcheologCatalogConfig()
        {
            InitializeComponent();
        }

        public ArcheologCatalogConfig(ArcheoObjectViewCtl archeoObjectViewCtl)
        {
            this.archeoObjectViewCtl = archeoObjectViewCtl;
            InitializeComponent();
        }

        internal void SetConfigParameterInForm(string parameter, List<string> parameterList)
        {
            //Todo: setzte die Parameter in der Form. 
            string[] paramList = parameterList.ToArray();
            if (parameter.Equals("RockType"))
            {
                int i = 0;
                foreach (string param in paramList)
                {
                    dataGridViewRockType.Rows.Add();
                    dataGridViewRockType.Rows[i].Cells[0].Value = param;
                    i++;
                }
            }
            if (parameter.Equals("TypeOfBuild"))
            {
                int i = 0;
                foreach (string param in paramList)
                {
                    dataGridViewTypeOfBuild.Rows.Add();
                    dataGridViewTypeOfBuild.Rows[i].Cells[0].Value = param;
                    i++;
                }
            }
        }

        private void buttonNewRockTyp_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.NewConfigEntry("RockTyp");
        }

        private void buttonNewTypeOfBuild_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.NewConfigEntry("TypeOfBuild");
        }

        private void dataGridViewTypeOfBuild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ArcheologCatalogConfig_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<string> typeOfBuild = new List<string>();
            int j = dataGridViewTypeOfBuild.Rows.Count - 1;
            int i;

            for (i = 0; i < j; i++)
            {
                try
                {
                    if (dataGridViewTypeOfBuild.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    else
                    {
                        typeOfBuild.Add(dataGridViewTypeOfBuild.Rows[i].Cells[0].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }

            List<string> rockType = new List<string>();
            j = dataGridViewRockType.Rows.Count - 1;

            for (i = 0; i < j; i++)
            {
                try
                {
                    if (dataGridViewRockType.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    else
                    {
                        rockType.Add(dataGridViewRockType.Rows[i].Cells[0].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }

            archeoObjectViewCtl.ConfigViewFinish(typeOfBuild, rockType);

            this.Close();
        }
    }
}
