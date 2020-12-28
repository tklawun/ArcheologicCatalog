
namespace ArcheologicCatalogClassicV3
{
    partial class ArcheologCatalogConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcheologCatalogConfig));
            this.listBoxTypOfBuild = new System.Windows.Forms.ListBox();
            this.labelTypOfBuild = new System.Windows.Forms.Label();
            this.labelRockType = new System.Windows.Forms.Label();
            this.listBoxRockType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxTypOfBuild
            // 
            this.listBoxTypOfBuild.FormattingEnabled = true;
            this.listBoxTypOfBuild.ItemHeight = 20;
            this.listBoxTypOfBuild.Location = new System.Drawing.Point(34, 75);
            this.listBoxTypOfBuild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTypOfBuild.Name = "listBoxTypOfBuild";
            this.listBoxTypOfBuild.Size = new System.Drawing.Size(317, 564);
            this.listBoxTypOfBuild.TabIndex = 0;
            // 
            // labelTypOfBuild
            // 
            this.labelTypOfBuild.AutoSize = true;
            this.labelTypOfBuild.Location = new System.Drawing.Point(58, 35);
            this.labelTypOfBuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypOfBuild.Name = "labelTypOfBuild";
            this.labelTypOfBuild.Size = new System.Drawing.Size(129, 20);
            this.labelTypOfBuild.TabIndex = 1;
            this.labelTypOfBuild.Text = "Baubezeichnung";
            // 
            // labelRockType
            // 
            this.labelRockType.AutoSize = true;
            this.labelRockType.Location = new System.Drawing.Point(427, 35);
            this.labelRockType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRockType.Name = "labelRockType";
            this.labelRockType.Size = new System.Drawing.Size(94, 20);
            this.labelRockType.TabIndex = 2;
            this.labelRockType.Text = "Gesteinstyp";
            // 
            // listBoxRockType
            // 
            this.listBoxRockType.FormattingEnabled = true;
            this.listBoxRockType.ItemHeight = 20;
            this.listBoxRockType.Location = new System.Drawing.Point(399, 75);
            this.listBoxRockType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRockType.Name = "listBoxRockType";
            this.listBoxRockType.Size = new System.Drawing.Size(330, 564);
            this.listBoxRockType.TabIndex = 3;
            // 
            // ArcheologCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 692);
            this.Controls.Add(this.listBoxRockType);
            this.Controls.Add(this.labelRockType);
            this.Controls.Add(this.labelTypOfBuild);
            this.Controls.Add(this.listBoxTypOfBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArcheologCatalogConfig";
            this.Text = "Archeolog Catalog Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTypOfBuild;
        private System.Windows.Forms.Label labelTypOfBuild;
        private System.Windows.Forms.Label labelRockType;
        private System.Windows.Forms.ListBox listBoxRockType;
    }
}