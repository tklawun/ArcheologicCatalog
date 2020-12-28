﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ArcheologicCatalogClassicV3
{
    public class ArcheoObjectViewCtl
    {
        private ArcheoObjectCtl archeoObjectCtl;
        private ArcheoConfigParameter archeoConfigTypeOfBuild;
        private ArcheoConfigParameter archeoConfigRockType;
        private ArcheologCatalogDetail archeologCatalogDetail;
        private ArcheologCatalogList archeologCatalogList;
        private ArcheologCatalogConfig archeologCatalogConfig;
        private string paramRockType = "RockType";
        private string paramTypeOfBuild = "TypeOfBuild";


        public ArcheoObjectViewCtl(ArcheologCatalogList archeologCatalogList)
        {
            this.archeoObjectCtl = new ArcheoObjectCtl();
            this.archeoConfigTypeOfBuild = new ArcheoConfigParameter(paramTypeOfBuild);
            this.archeoConfigRockType = new ArcheoConfigParameter(paramRockType);
            this.archeologCatalogList = archeologCatalogList;
            this.archeologCatalogDetail = new ArcheologCatalogDetail(this);
            this.archeologCatalogConfig = new ArcheologCatalogConfig(this);
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

        internal void OpenConfigDialog()
        {
            if (this.archeologCatalogConfig.IsDisposed) { this.archeologCatalogConfig = new ArcheologCatalogConfig(this); }
            this.archeologCatalogConfig.SetConfigParameterInForm(paramRockType, archeoConfigRockType.Parameters);
            this.archeologCatalogConfig.SetConfigParameterInForm(paramTypeOfBuild, archeoConfigTypeOfBuild.Parameters);
            this.archeologCatalogConfig.Activate();
            this.archeologCatalogConfig.Visible = true;
            this.archeologCatalogConfig.Show();
        }

        internal void SaveConfigParameter(string parameter, string[] parameters)
        {

        }
        internal void CloseApplication()
        {
            //Todo: ApplicationExit. Speichern und schließen
        }

        internal void ReturnStatus()
        {
            archeologCatalogList.labelStatus.Text = "";
            archeologCatalogDetail.labelStatus.Text = "";
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