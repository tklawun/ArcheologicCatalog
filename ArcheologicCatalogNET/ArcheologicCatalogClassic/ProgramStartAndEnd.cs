using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ArcheologicCatalogClassic
{
    class ProgramStartAndEnd
    {
        private string applicationPath = Environment.GetEnvironmentVariable(applicationData) + "\\ArcheoCatalog";
        private const string applicationData = "ArcheoCatalogData.xml";
        private XmlDocument xmlSettings;
        public void ReadData()
        {
            //TODO: Das Ganze Problem Change and Save Directory Setting muss noch gemacht werden. 

        }

        public Boolean CheckApplicationPath(string applicationPath)
        {

            //Todo checke den Application Pfad
            return false;
        }
        public void WriteData()
        {

        }
    }
}
