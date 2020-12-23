namespace ArcheologicCatalogClassicV3
{
    partial class ArcheologCatalogList
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcheologCatalogList));
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listViewArcheoObjects = new System.Windows.Forms.ListView();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(244, 289);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Dies ist ein Text";
            this.labelStatus.Visible = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(8, 282);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(50, 20);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // listViewArcheoObjects
            // 
            this.listViewArcheoObjects.GridLines = true;
            this.listViewArcheoObjects.HideSelection = false;
            this.listViewArcheoObjects.Location = new System.Drawing.Point(9, 8);
            this.listViewArcheoObjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewArcheoObjects.MultiSelect = false;
            this.listViewArcheoObjects.Name = "listViewArcheoObjects";
            this.listViewArcheoObjects.Size = new System.Drawing.Size(518, 265);
            this.listViewArcheoObjects.TabIndex = 3;
            this.listViewArcheoObjects.UseCompatibleStateImageBehavior = false;
            this.listViewArcheoObjects.View = System.Windows.Forms.View.List;
            this.listViewArcheoObjects.SelectedIndexChanged += new System.EventHandler(this.listViewArcheoObjects_SelectedIndexChanged);
            this.listViewArcheoObjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewArcheoObjects_MouseDoubleClick);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(389, 281);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(51, 23);
            this.buttonConfig.TabIndex = 6;
            this.buttonConfig.Text = "Konfig";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(452, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Beenden";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ArcheologCatalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 316);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listViewArcheoObjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArcheologCatalogList";
            this.Text = "Archäologischer Katalog - Objekt Liste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListView listViewArcheoObjects;
        internal System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonClose;
    }
}

