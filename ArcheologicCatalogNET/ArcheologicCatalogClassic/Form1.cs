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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArcheoCatalogConfig config = new ArcheoCatalogConfig();
            config.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArcheoCatalogDetail detail = new ArcheoCatalogDetail();
            XmlData xmld = new XmlData();
            ArcheoObject[] archeObjCol = new ArcheoObject[2];
            ArcheoObject archObj = new ArcheoObject();
            archObj.SetCode("Test1");
            archObj.SetTitle("Test1Titel");
            archObj.SetHeight(100);
            archObj.SetWidth(100);
            archObj.SetDepth(100);
            archObj.SetDescription("Teste das erste Object");

            archeObjCol.Append(archObj);
            xmld.generateXMLDocumentFromArcheoObjectList(archeObjCol);
            detail.setTitle(archObj.GetTitle());
            detail.setCode(archObj.GetCode());
            detail.setHeight(archObj.GetHeight().ToString());
            detail.setWidth(archObj.GetWidth().ToString());
            detail.setDescription(archObj.GetDescription());
            detail.Show();
        }
    }
}
