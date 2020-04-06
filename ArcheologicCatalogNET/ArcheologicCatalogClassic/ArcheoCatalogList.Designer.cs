using System;
using System.Windows.Forms;

namespace ArcheologicCatalogClassic
{
    partial class ArcheoCatalogList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewArcheoObjects = new System.Windows.Forms.ListView();
            this.buttonChangeListView = new System.Windows.Forms.Button();
            this.buttonListViewDetails = new System.Windows.Forms.Button();
            this.buttonChangeSmallIcon = new System.Windows.Forms.Button();
            this.buttonChangeLargeIcon = new System.Windows.Forms.Button();
            this.buttonRefreshPic = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewArcheoObjects
            // 
            this.listViewArcheoObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewArcheoObjects.HideSelection = false;
            this.listViewArcheoObjects.Location = new System.Drawing.Point(21, 44);
            this.listViewArcheoObjects.MultiSelect = false;
            this.listViewArcheoObjects.Name = "listViewArcheoObjects";
            this.listViewArcheoObjects.ShowItemToolTips = true;
            this.listViewArcheoObjects.Size = new System.Drawing.Size(756, 373);
            this.listViewArcheoObjects.TabIndex = 0;
            this.listViewArcheoObjects.UseCompatibleStateImageBehavior = false;
            this.listViewArcheoObjects.View = System.Windows.Forms.View.List;
            this.listViewArcheoObjects.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewArcheoObjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewArcheoObjects_MouseDoubleClick);
            // 
            // buttonChangeListView
            // 
            this.buttonChangeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeListView.Location = new System.Drawing.Point(28, 421);
            this.buttonChangeListView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeListView.Name = "buttonChangeListView";
            this.buttonChangeListView.Size = new System.Drawing.Size(50, 21);
            this.buttonChangeListView.TabIndex = 1;
            this.buttonChangeListView.Text = "List";
            this.buttonChangeListView.UseVisualStyleBackColor = true;
            this.buttonChangeListView.Click += new System.EventHandler(this.buttonChangeListView_Click);
            // 
            // buttonListViewDetails
            // 
            this.buttonListViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonListViewDetails.Location = new System.Drawing.Point(82, 421);
            this.buttonListViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListViewDetails.Name = "buttonListViewDetails";
            this.buttonListViewDetails.Size = new System.Drawing.Size(50, 21);
            this.buttonListViewDetails.TabIndex = 2;
            this.buttonListViewDetails.TabStop = false;
            this.buttonListViewDetails.Text = "Details";
            this.buttonListViewDetails.UseVisualStyleBackColor = true;
            this.buttonListViewDetails.Visible = false;
            this.buttonListViewDetails.Click += new System.EventHandler(this.buttonListViewDetails_Click);
            // 
            // buttonChangeSmallIcon
            // 
            this.buttonChangeSmallIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeSmallIcon.Location = new System.Drawing.Point(136, 421);
            this.buttonChangeSmallIcon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeSmallIcon.Name = "buttonChangeSmallIcon";
            this.buttonChangeSmallIcon.Size = new System.Drawing.Size(65, 21);
            this.buttonChangeSmallIcon.TabIndex = 3;
            this.buttonChangeSmallIcon.TabStop = false;
            this.buttonChangeSmallIcon.Text = "Small-Icon";
            this.buttonChangeSmallIcon.UseVisualStyleBackColor = true;
            this.buttonChangeSmallIcon.Visible = false;
            this.buttonChangeSmallIcon.Click += new System.EventHandler(this.buttonChangeSmallIcon_Click);
            // 
            // buttonChangeLargeIcon
            // 
            this.buttonChangeLargeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeLargeIcon.Location = new System.Drawing.Point(205, 421);
            this.buttonChangeLargeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeLargeIcon.Name = "buttonChangeLargeIcon";
            this.buttonChangeLargeIcon.Size = new System.Drawing.Size(75, 21);
            this.buttonChangeLargeIcon.TabIndex = 4;
            this.buttonChangeLargeIcon.TabStop = false;
            this.buttonChangeLargeIcon.Text = "Large-Icon";
            this.buttonChangeLargeIcon.UseVisualStyleBackColor = true;
            this.buttonChangeLargeIcon.Visible = false;
            this.buttonChangeLargeIcon.Click += new System.EventHandler(this.buttonChangeLargeIcon_Click);
            // 
            // buttonRefreshPic
            // 
            this.buttonRefreshPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshPic.Location = new System.Drawing.Point(624, 424);
            this.buttonRefreshPic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshPic.Name = "buttonRefreshPic";
            this.buttonRefreshPic.Size = new System.Drawing.Size(59, 21);
            this.buttonRefreshPic.TabIndex = 5;
            this.buttonRefreshPic.Text = "Refresh Images";
            this.buttonRefreshPic.UseVisualStyleBackColor = true;
            this.buttonRefreshPic.Click += new System.EventHandler(this.buttonRefreshPic_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(742, 424);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 21);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(687, 424);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 21);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(294, 422);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 20);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ArcheoCatalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRefreshPic);
            this.Controls.Add(this.buttonChangeLargeIcon);
            this.Controls.Add(this.buttonChangeSmallIcon);
            this.Controls.Add(this.buttonListViewDetails);
            this.Controls.Add(this.buttonChangeListView);
            this.Controls.Add(this.listViewArcheoObjects);
            this.Name = "ArcheoCatalogList";
            this.Text = "Archeo Catalog List";
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Todo: Mit Click auf List Eintrag, Dialog Detail öffnen....oder? 
            foreach (ListViewItem item in listViewArcheoObjects.SelectedItems)
            {
                prgCtl.ShowArcheoCatalogDetail(item.Text);
            }
            


            //throw new NotImplementedException();
        }
      
        #endregion
        private System.Windows.Forms.Button buttonChangeListView;
        private System.Windows.Forms.Button buttonListViewDetails;
        private System.Windows.Forms.Button buttonChangeSmallIcon;
        private System.Windows.Forms.Button buttonChangeLargeIcon;
        private System.Windows.Forms.Button buttonRefreshPic;
        private Button buttonExit;
        private Button buttonClose;
        private Button buttonAdd;
        public ListView listViewArcheoObjects;
    }
}