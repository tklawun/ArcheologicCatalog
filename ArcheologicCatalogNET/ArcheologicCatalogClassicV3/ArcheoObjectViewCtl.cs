using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    public class ArcheoObjectViewCtl
    {
        ArcheoObjectCtl archeoObjectCtl;
        ArcheologCatalogDetail archeologCatalogDetail;
        ArcheologCatalogList archeologCatalogList;

        public ArcheoObjectViewCtl(ArcheologCatalogList archeologCatalogList)
        {
            this.archeoObjectCtl = new ArcheoObjectCtl();
            this.archeologCatalogList = archeologCatalogList;
            this.archeologCatalogDetail = new ArcheologCatalogDetail(this);
            this.archeologCatalogDetail.Visible = false;
        }

        internal void CreateArcheoObjectDetailView(string archeoObjectCode)
        {
            ArcheologCatalogDetail ArcheologCatalogDetail = new ArcheologCatalogDetail(this);
            if (archeoObjectCode != null)
            {
                ArcheoObject archeoObject = this.archeoObjectCtl.GetArcheoObject(archeoObjectCode);
                this.archeologCatalogDetail.SetArcheoObjectInForm(archeoObject);
                this.archeologCatalogDetail.Activate();
                this.archeologCatalogDetail.Visible = true;
                this.archeologCatalogDetail.Show();
            }
            else
            {
                //Clear the textboxes....
                this.archeologCatalogDetail.ClearArcheoObjectInForm();
                this.archeologCatalogDetail.Show();
            }
        }

        internal void SetArcheoObjectListInView()
        {
            archeologCatalogList.SetListView(archeoObjectCtl.GetArcheoObjects().Keys);

        }

        internal void SaveArcheoObjectInList(ArcheoObject archeoObject)
        {
            this.archeoObjectCtl.SetArcheoObject(archeoObject.CodeOut, archeoObject);
            this.RefreshListInListView();
        }

        private void RefreshListInListView()
        {
            SetArcheoObjectListInView();

        }
    }
}
