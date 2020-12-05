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
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listViewArcheoObjects = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(366, 445);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(120, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Dies ist ein Text";
            this.labelStatus.Visible = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 434);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 31);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // listViewArcheoObjects
            // 
            this.listViewArcheoObjects.HideSelection = false;
            this.listViewArcheoObjects.Location = new System.Drawing.Point(13, 12);
            this.listViewArcheoObjects.Name = "listViewArcheoObjects";
            this.listViewArcheoObjects.Size = new System.Drawing.Size(775, 406);
            this.listViewArcheoObjects.TabIndex = 3;
            this.listViewArcheoObjects.UseCompatibleStateImageBehavior = false;
            // 
            // ArcheologCatalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listViewArcheoObjects);
            this.Name = "ArcheologCatalogList";
            this.Text = "Archäologischer Katalog - Objekt Liste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListView listViewArcheoObjects;
    }
}

