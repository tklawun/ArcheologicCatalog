
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
            this.labelTypOfBuild = new System.Windows.Forms.Label();
            this.labelRockType = new System.Windows.Forms.Label();
            this.dataGridViewTypeOfBuild = new System.Windows.Forms.DataGridView();
            this.TypeOfBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRockType = new System.Windows.Forms.DataGridView();
            this.RockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeOfBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRockType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTypOfBuild
            // 
            this.labelTypOfBuild.AutoSize = true;
            this.labelTypOfBuild.Location = new System.Drawing.Point(32, 9);
            this.labelTypOfBuild.Name = "labelTypOfBuild";
            this.labelTypOfBuild.Size = new System.Drawing.Size(87, 13);
            this.labelTypOfBuild.TabIndex = 1;
            this.labelTypOfBuild.Text = "Baubezeichnung";
            // 
            // labelRockType
            // 
            this.labelRockType.AutoSize = true;
            this.labelRockType.Location = new System.Drawing.Point(422, 9);
            this.labelRockType.Name = "labelRockType";
            this.labelRockType.Size = new System.Drawing.Size(62, 13);
            this.labelRockType.TabIndex = 2;
            this.labelRockType.Text = "Gesteinstyp";
            // 
            // dataGridViewTypeOfBuild
            // 
            this.dataGridViewTypeOfBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypeOfBuild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTypeOfBuild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTypeOfBuild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeOfBuild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfBuild});
            this.dataGridViewTypeOfBuild.Location = new System.Drawing.Point(22, 25);
            this.dataGridViewTypeOfBuild.Name = "dataGridViewTypeOfBuild";
            this.dataGridViewTypeOfBuild.RowHeadersWidth = 82;
            this.dataGridViewTypeOfBuild.Size = new System.Drawing.Size(331, 375);
            this.dataGridViewTypeOfBuild.TabIndex = 7;
            
            // 
            // TypeOfBuild
            // 
            this.TypeOfBuild.HeaderText = "Type of build";
            this.TypeOfBuild.MinimumWidth = 10;
            this.TypeOfBuild.Name = "TypeOfBuild";
            this.TypeOfBuild.Width = 93;
            // 
            // dataGridViewRockType
            // 
            this.dataGridViewRockType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewRockType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRockType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RockType});
            this.dataGridViewRockType.Location = new System.Drawing.Point(398, 25);
            this.dataGridViewRockType.Name = "dataGridViewRockType";
            this.dataGridViewRockType.RowHeadersWidth = 82;
            this.dataGridViewRockType.Size = new System.Drawing.Size(326, 375);
            this.dataGridViewRockType.TabIndex = 8;
            // 
            // RockType
            // 
            this.RockType.HeaderText = "Rock Type";
            this.RockType.MinimumWidth = 10;
            this.RockType.Name = "RockType";
            this.RockType.Width = 200;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(681, 406);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(43, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ArcheologCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 441);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridViewRockType);
            this.Controls.Add(this.dataGridViewTypeOfBuild);
            this.Controls.Add(this.labelRockType);
            this.Controls.Add(this.labelTypOfBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcheologCatalogConfig";
            this.Text = "Archeolog Catalog Config";
            this.Load += new System.EventHandler(this.ArcheologCatalogConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeOfBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRockType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTypOfBuild;
        private System.Windows.Forms.Label labelRockType;
        private System.Windows.Forms.DataGridView dataGridViewTypeOfBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfBuild;
        private System.Windows.Forms.DataGridView dataGridViewRockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RockType;
        private System.Windows.Forms.Button buttonOk;
    }
}