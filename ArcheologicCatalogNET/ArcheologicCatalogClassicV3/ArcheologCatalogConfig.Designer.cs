
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTypOfBuild
            // 
            this.listBoxTypOfBuild.FormattingEnabled = true;
            this.listBoxTypOfBuild.ItemHeight = 25;
            this.listBoxTypOfBuild.Location = new System.Drawing.Point(46, 94);
            this.listBoxTypOfBuild.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxTypOfBuild.Name = "listBoxTypOfBuild";
            this.listBoxTypOfBuild.Size = new System.Drawing.Size(422, 704);
            this.listBoxTypOfBuild.TabIndex = 0;
            // 
            // labelTypOfBuild
            // 
            this.labelTypOfBuild.AutoSize = true;
            this.labelTypOfBuild.Location = new System.Drawing.Point(78, 44);
            this.labelTypOfBuild.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTypOfBuild.Name = "labelTypOfBuild";
            this.labelTypOfBuild.Size = new System.Drawing.Size(173, 25);
            this.labelTypOfBuild.TabIndex = 1;
            this.labelTypOfBuild.Text = "Baubezeichnung";
            // 
            // labelRockType
            // 
            this.labelRockType.AutoSize = true;
            this.labelRockType.Location = new System.Drawing.Point(614, 44);
            this.labelRockType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRockType.Name = "labelRockType";
            this.labelRockType.Size = new System.Drawing.Size(126, 25);
            this.labelRockType.TabIndex = 2;
            this.labelRockType.Text = "Gesteinstyp";
            // 
            // listBoxRockType
            // 
            this.listBoxRockType.FormattingEnabled = true;
            this.listBoxRockType.ItemHeight = 25;
            this.listBoxRockType.Location = new System.Drawing.Point(568, 94);
            this.listBoxRockType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxRockType.Name = "listBoxRockType";
            this.listBoxRockType.Size = new System.Drawing.Size(438, 704);
            this.listBoxRockType.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNewRockTyp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(484, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ArcheologCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 865);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRockType);
            this.Controls.Add(this.labelRockType);
            this.Controls.Add(this.labelTypOfBuild);
            this.Controls.Add(this.listBoxTypOfBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}