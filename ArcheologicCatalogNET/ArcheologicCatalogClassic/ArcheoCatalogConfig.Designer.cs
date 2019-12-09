namespace ArcheologicCatalogClassic
{
    partial class ArcheoCatalogConfig
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
            this.labelChoiseImageDir = new System.Windows.Forms.Label();
            this.folderBrowserDialogImageDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxChoisedDirectory = new System.Windows.Forms.TextBox();
            this.buttonChoisPicDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoiseImageDir
            // 
            this.labelChoiseImageDir.AutoSize = true;
            this.labelChoiseImageDir.Location = new System.Drawing.Point(20, 20);
            this.labelChoiseImageDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChoiseImageDir.Name = "labelChoiseImageDir";
            this.labelChoiseImageDir.Size = new System.Drawing.Size(174, 20);
            this.labelChoiseImageDir.TabIndex = 0;
            this.labelChoiseImageDir.Text = "Choise Image Directory";
            // 
            // folderBrowserDialogImageDirectory
            // 
            this.folderBrowserDialogImageDirectory.HelpRequest += new System.EventHandler(this.FolderBrowserDialogImageDirectory_HelpRequest);
            // 
            // textBoxChoisedDirectory
            // 
            this.textBoxChoisedDirectory.Location = new System.Drawing.Point(202, 15);
            this.textBoxChoisedDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxChoisedDirectory.Name = "textBoxChoisedDirectory";
            this.textBoxChoisedDirectory.Size = new System.Drawing.Size(520, 26);
            this.textBoxChoisedDirectory.TabIndex = 1;
            this.textBoxChoisedDirectory.TextChanged += new System.EventHandler(this.TextBoxCoisedDirectory_TextChanged);
            // 
            // buttonChoisPicDir
            // 
            this.buttonChoisPicDir.Location = new System.Drawing.Point(730, 16);
            this.buttonChoisPicDir.Name = "buttonChoisPicDir";
            this.buttonChoisPicDir.Size = new System.Drawing.Size(216, 25);
            this.buttonChoisPicDir.TabIndex = 2;
            this.buttonChoisPicDir.Text = "Choise Picture Directory";
            this.buttonChoisPicDir.UseVisualStyleBackColor = true;
            this.buttonChoisPicDir.Click += new System.EventHandler(this.buttonChoisPicDir_Click);
            // 
            // ArcheoCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonChoisPicDir);
            this.Controls.Add(this.textBoxChoisedDirectory);
            this.Controls.Add(this.labelChoiseImageDir);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArcheoCatalogConfig";
            this.Text = "Archeo Catalog Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoiseImageDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImageDirectory;
        private System.Windows.Forms.TextBox textBoxChoisedDirectory;
        private System.Windows.Forms.Button buttonChoisPicDir;
    }
}