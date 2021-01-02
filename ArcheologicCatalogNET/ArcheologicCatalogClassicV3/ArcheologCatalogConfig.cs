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
                listBoxRockType.Items.AddRange(paramList);
            }
            if (parameter.Equals("TypeOfBuild"))
            {
                listBoxTypeOfBuild.Items.AddRange(paramList);
            }
        }

        private void buttonNewRockTyp_Click(object sender, EventArgs e)
        {

            ArcheoCatalogNewEntryAddListEntry archeoCatalogNewEntryAddListEntry = new ArcheoCatalogNewEntryAddListEntry("RockTyp");
        }

        private void buttonNewTypeOfBuild_Click(object sender, EventArgs e)
        {
            ArcheoCatalogNewEntryAddListEntry archeoCatalogNewEntryAddListEntry = new ArcheoCatalogNewEntryAddListEntry("TypeOfBuild");

        }
    }
}
