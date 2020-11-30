using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV2
{
    public class ArcheoObjectViewCtl
    {
        List<ArcheoObject> archeoObjects;
        internal void CreateArcheoObjectsList(ArcheoObjectListForm archeoObjectListForm)
        {
            XmlData xmlData = new XmlData();
            archeoObjects = new List<ArcheoObject>();
            archeoObjects = xmlData.GetArcheoObjColFromXMLDoc(xmlData.ReadXMLDocumentFromFile(new XmlFilePath().getXmlFilePath()));
            
        }

        internal void CreateArcheoObjectDetailView(string archeObjectCode)
        {
            ArcheoObjectDetailForm archeoObjectDetailForm = new ArcheoObjectDetailForm(this);
            if (archeObjectCode != null)
            {
                archeoObjectDetailForm.Show();
            }
            else
            {
                foreach (ArcheoObject item in archeoObjects)
                {
                    if (item.GetCode().Equals(archeObjectCode))
                    {

                    }
                }
            }

        }

        internal IEnumerable<ArcheoObject> GetArcheoObjects()
        {
            throw new NotImplementedException();
        }
    }
}
