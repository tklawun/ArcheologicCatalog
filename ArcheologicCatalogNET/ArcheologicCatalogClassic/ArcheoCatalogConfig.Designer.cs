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
            this.textBoxCoisedDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelChoiseImageDir
            // 
            this.labelChoiseImageDir.AutoSize = true;
            this.labelChoiseImageDir.Location = new System.Drawing.Point(13, 13);
            this.labelChoiseImageDir.Name = "labelChoiseImageDir";
            this.labelChoiseImageDir.Size = new System.Drawing.Size(116, 13);
            this.labelChoiseImageDir.TabIndex = 0;
            this.labelChoiseImageDir.Text = "Choise Image Directory";
            // 
            // folderBrowserDialogImageDirectory
            // 
            this.folderBrowserDialogImageDirectory.HelpRequest += new System.EventHandler(this.FolderBrowserDialogImageDirectory_HelpRequest);
            // 
            // textBoxCoisedDirectory
            // 
            this.textBoxCoisedDirectory.Location = new System.Drawing.Point(135, 10);
            this.textBoxCoisedDirectory.Name = "textBoxCoisedDirectory";
            this.textBoxCoisedDirectory.Size = new System.Drawing.Size(348, 20);
            this.textBoxCoisedDirectory.TabIndex = 1;
            this.textBoxCoisedDirectory.TextChanged += new System.EventHandler(this.TextBoxCoisedDirectory_TextChanged);
            // 
            // ArcheoCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCoisedDirectory);
            this.Controls.Add(this.labelChoiseImageDir);
            this.Name = "ArcheoCatalogConfig";
            this.Text = "Archeo Catalog Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoiseImageDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImageDirectory;
        private System.Windows.Forms.TextBox textBoxCoisedDirectory;
    }
}