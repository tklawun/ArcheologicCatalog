using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            if (this.archeologCatalogDetail.IsDisposed) { this.archeologCatalogDetail = new ArcheologCatalogDetail(this); }
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

        internal void SetStatus(string Status, bool important)
        {
            string status = Status;
            archeologCatalogList.labelStatus.Visible = true;
            archeologCatalogDetail.labelStatus.Visible = true;

            archeologCatalogList.labelStatus.Text = status;
            archeologCatalogDetail.labelStatus.Text = status;
            if (important)
            {
                archeologCatalogList.labelStatus.ForeColor = Color.Red;
                archeologCatalogDetail.labelStatus.ForeColor = Color.Red;
            }
            {
                archeologCatalogList.labelStatus.ForeColor = Color.Black;
                archeologCatalogDetail.labelStatus.ForeColor = Color.Black;
            }
        }
        internal void ReturnStatus()
        {
            archeologCatalogList.labelStatus.Visible = false;
            archeologCatalogDetail.labelStatus.Visible = false;
            archeologCatalogList.labelStatus.ForeColor = Color.Black;
            archeologCatalogDetail.labelStatus.ForeColor = Color.Black;
        }

        internal void exportToWord(string archeoObjectCode)
        {
            archeoObjectCtl.ExportToWord(archeoObjectCode);
        }
    }
}
