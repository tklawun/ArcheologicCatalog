﻿using System;

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
            this.SuspendLayout();
            // 
            // listViewArcheoObjects
            // 
            this.listViewArcheoObjects.HideSelection = false;
            this.listViewArcheoObjects.Location = new System.Drawing.Point(32, 97);
            this.listViewArcheoObjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewArcheoObjects.MultiSelect = false;
            this.listViewArcheoObjects.Name = "listViewArcheoObjects";
            this.listViewArcheoObjects.ShowItemToolTips = true;
            this.listViewArcheoObjects.Size = new System.Drawing.Size(1132, 542);
            this.listViewArcheoObjects.TabIndex = 0;
            this.listViewArcheoObjects.UseCompatibleStateImageBehavior = false;
            this.listViewArcheoObjects.View = System.Windows.Forms.View.List;
            this.listViewArcheoObjects.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewArcheoObjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewArcheoObjects_MouseDoubleClick);
            // 
            // buttonChangeListView
            // 
            this.buttonChangeListView.Location = new System.Drawing.Point(42, 648);
            this.buttonChangeListView.Name = "buttonChangeListView";
            this.buttonChangeListView.Size = new System.Drawing.Size(75, 32);
            this.buttonChangeListView.TabIndex = 1;
            this.buttonChangeListView.Text = "List";
            this.buttonChangeListView.UseVisualStyleBackColor = true;
            this.buttonChangeListView.Click += new System.EventHandler(this.buttonChangeListView_Click);
            // 
            // buttonListViewDetails
            // 
            this.buttonListViewDetails.Location = new System.Drawing.Point(123, 648);
            this.buttonListViewDetails.Name = "buttonListViewDetails";
            this.buttonListViewDetails.Size = new System.Drawing.Size(75, 32);
            this.buttonListViewDetails.TabIndex = 2;
            this.buttonListViewDetails.Text = "Details";
            this.buttonListViewDetails.UseVisualStyleBackColor = true;
            this.buttonListViewDetails.Click += new System.EventHandler(this.buttonListViewDetails_Click);
            // 
            // buttonChangeSmallIcon
            // 
            this.buttonChangeSmallIcon.Location = new System.Drawing.Point(204, 648);
            this.buttonChangeSmallIcon.Name = "buttonChangeSmallIcon";
            this.buttonChangeSmallIcon.Size = new System.Drawing.Size(113, 32);
            this.buttonChangeSmallIcon.TabIndex = 3;
            this.buttonChangeSmallIcon.Text = "Small-Icon";
            this.buttonChangeSmallIcon.UseVisualStyleBackColor = true;
            this.buttonChangeSmallIcon.Click += new System.EventHandler(this.buttonChangeSmallIcon_Click);
            // 
            // buttonChangeLargeIcon
            // 
            this.buttonChangeLargeIcon.Location = new System.Drawing.Point(323, 647);
            this.buttonChangeLargeIcon.Name = "buttonChangeLargeIcon";
            this.buttonChangeLargeIcon.Size = new System.Drawing.Size(113, 32);
            this.buttonChangeLargeIcon.TabIndex = 4;
            this.buttonChangeLargeIcon.Text = "Large-Icon";
            this.buttonChangeLargeIcon.UseVisualStyleBackColor = true;
            this.buttonChangeLargeIcon.Click += new System.EventHandler(this.buttonChangeLargeIcon_Click);
            // 
            // ArcheoCatalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonChangeLargeIcon);
            this.Controls.Add(this.buttonChangeSmallIcon);
            this.Controls.Add(this.buttonListViewDetails);
            this.Controls.Add(this.buttonChangeListView);
            this.Controls.Add(this.listViewArcheoObjects);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArcheoCatalogList";
            this.Text = "Archeo Catalog List";
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Todo: Mit Click auf List Eintrag, Dialog Detail öffnen....oder? 
             


            //throw new NotImplementedException();
        }
      
        #endregion

        private System.Windows.Forms.ListView listViewArcheoObjects;
        private System.Windows.Forms.Button buttonChangeListView;
        private System.Windows.Forms.Button buttonListViewDetails;
        private System.Windows.Forms.Button buttonChangeSmallIcon;
        private System.Windows.Forms.Button buttonChangeLargeIcon;
    }
}