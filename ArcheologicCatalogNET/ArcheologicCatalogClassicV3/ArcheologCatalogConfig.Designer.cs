
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
            this.listBoxTypeOfBuild = new System.Windows.Forms.ListBox();
            this.labelTypOfBuild = new System.Windows.Forms.Label();
            this.labelRockType = new System.Windows.Forms.Label();
            this.listBoxRockType = new System.Windows.Forms.ListBox();
            this.buttonNewRockTyp = new System.Windows.Forms.Button();
            this.buttonNewTypeOfBuild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTypeOfBuild
            // 
            this.listBoxTypeOfBuild.FormattingEnabled = true;
            this.listBoxTypeOfBuild.Location = new System.Drawing.Point(23, 49);
            this.listBoxTypeOfBuild.Name = "listBoxTypeOfBuild";
            this.listBoxTypeOfBuild.Size = new System.Drawing.Size(213, 368);
            this.listBoxTypeOfBuild.TabIndex = 0;
            // 
            // labelTypOfBuild
            // 
            this.labelTypOfBuild.AutoSize = true;
            this.labelTypOfBuild.Location = new System.Drawing.Point(39, 23);
            this.labelTypOfBuild.Name = "labelTypOfBuild";
            this.labelTypOfBuild.Size = new System.Drawing.Size(87, 13);
            this.labelTypOfBuild.TabIndex = 1;
            this.labelTypOfBuild.Text = "Baubezeichnung";
            // 
            // labelRockType
            // 
            this.labelRockType.AutoSize = true;
            this.labelRockType.Location = new System.Drawing.Point(307, 23);
            this.labelRockType.Name = "labelRockType";
            this.labelRockType.Size = new System.Drawing.Size(62, 13);
            this.labelRockType.TabIndex = 2;
            this.labelRockType.Text = "Gesteinstyp";
            // 
            // listBoxRockType
            // 
            this.listBoxRockType.FormattingEnabled = true;
            this.listBoxRockType.Location = new System.Drawing.Point(284, 49);
            this.listBoxRockType.Name = "listBoxRockType";
            this.listBoxRockType.Size = new System.Drawing.Size(221, 368);
            this.listBoxRockType.TabIndex = 3;
            // 
            // buttonNewRockTyp
            // 
            this.buttonNewRockTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRockTyp.Location = new System.Drawing.Point(511, 49);
            this.buttonNewRockTyp.Name = "buttonNewRockTyp";
            this.buttonNewRockTyp.Size = new System.Drawing.Size(21, 24);
            this.buttonNewRockTyp.TabIndex = 4;
            this.buttonNewRockTyp.Text = "*";
            this.buttonNewRockTyp.UseVisualStyleBackColor = true;
            this.buttonNewRockTyp.Click += new System.EventHandler(this.buttonNewRockTyp_Click);
            // 
            // buttonNewTypeOfBuild
            // 
            this.buttonNewTypeOfBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewTypeOfBuild.Location = new System.Drawing.Point(242, 49);
            this.buttonNewTypeOfBuild.Name = "buttonNewTypeOfBuild";
            this.buttonNewTypeOfBuild.Size = new System.Drawing.Size(21, 24);
            this.buttonNewTypeOfBuild.TabIndex = 5;
            this.buttonNewTypeOfBuild.Text = "*";
            this.buttonNewTypeOfBuild.UseVisualStyleBackColor = true;
            this.buttonNewTypeOfBuild.Click += new System.EventHandler(this.buttonNewTypeOfBuild_Click);
            // 
            // ArcheologCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.buttonNewTypeOfBuild);
            this.Controls.Add(this.buttonNewRockTyp);
            this.Controls.Add(this.listBoxRockType);
            this.Controls.Add(this.labelRockType);
            this.Controls.Add(this.labelTypOfBuild);
            this.Controls.Add(this.listBoxTypeOfBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcheologCatalogConfig";
            this.Text = "Archeolog Catalog Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTypeOfBuild;
        private System.Windows.Forms.Label labelTypOfBuild;
        private System.Windows.Forms.Label labelRockType;
        private System.Windows.Forms.ListBox listBoxRockType;
        private System.Windows.Forms.Button buttonNewRockTyp;
        private System.Windows.Forms.Button buttonNewTypeOfBuild;
    }
}