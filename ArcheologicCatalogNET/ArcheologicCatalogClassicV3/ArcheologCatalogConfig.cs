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
        }

        internal void SetConfigParameterInForm(string parameter, string[] parameterList)
        {
           //Todo: setzte die Parameter in der Form. 
           if (parameter.Equals("RockType"))
            {
                listBoxRockType.Items.AddRange(parameterList);
            }
           if (parameter.Equals("TypOfBuild"))
            {
                listBoxTypOfBuild.Items.AddRange(parameterList);
            }
        }
        
    }
}
