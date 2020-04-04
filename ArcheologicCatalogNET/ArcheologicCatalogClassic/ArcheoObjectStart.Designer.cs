using System;

namespace ArcheologicCatalogClassic
{
    partial class ArcheoObjectStart
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
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(60, 49);
            this.buttonList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(112, 35);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(60, 111);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(112, 34);
            this.buttonConfig.TabIndex = 2;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(60, 181);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 29);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ArcheoObjectStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 257);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArcheoObjectStart";
            this.Text = "Archeo Object Start";
            this.Load += new System.EventHandler(this.ArcheoObjectStart_Load);
            this.ResumeLayout(false);

        }

        private void ArcheoObjectStart_Load(object sender, EventArgs e)
        {
         //   throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonExit;
    }
}

