using System;

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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCodeTemplate = new System.Windows.Forms.Label();
            this.textBoxCodeTemplate = new System.Windows.Forms.TextBox();
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
            // textBoxChoisedDirectory
            // 
            this.textBoxChoisedDirectory.Location = new System.Drawing.Point(135, 10);
            this.textBoxChoisedDirectory.Name = "textBoxChoisedDirectory";
            this.textBoxChoisedDirectory.Size = new System.Drawing.Size(348, 20);
            this.textBoxChoisedDirectory.TabIndex = 1;
            this.textBoxChoisedDirectory.TextChanged += new System.EventHandler(this.TextBoxCoisedDirectory_TextChanged);
            // 
            // buttonChoisPicDir
            // 
            this.buttonChoisPicDir.Location = new System.Drawing.Point(486, 8);
            this.buttonChoisPicDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChoisPicDir.Name = "buttonChoisPicDir";
            this.buttonChoisPicDir.Size = new System.Drawing.Size(144, 23);
            this.buttonChoisPicDir.TabIndex = 2;
            this.buttonChoisPicDir.Text = "Choise Picture Directory";
            this.buttonChoisPicDir.UseVisualStyleBackColor = true;
            this.buttonChoisPicDir.Click += new System.EventHandler(this.buttonChoisPicDir_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(624, 423);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 19);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(678, 423);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(58, 19);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(740, 423);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 19);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCodeTemplate
            // 
            this.labelCodeTemplate.AutoSize = true;
            this.labelCodeTemplate.Location = new System.Drawing.Point(13, 45);
            this.labelCodeTemplate.Name = "labelCodeTemplate";
            this.labelCodeTemplate.Size = new System.Drawing.Size(112, 13);
            this.labelCodeTemplate.TabIndex = 6;
            this.labelCodeTemplate.Text = "Change Codetemplate";
            // 
            // textBoxCodeTemplate
            // 
            this.textBoxCodeTemplate.Location = new System.Drawing.Point(135, 43);
            this.textBoxCodeTemplate.Name = "textBoxCodeTemplate";
            this.textBoxCodeTemplate.Size = new System.Drawing.Size(348, 20);
            this.textBoxCodeTemplate.TabIndex = 7;
            this.textBoxCodeTemplate.Text = "KN.2020-HT.XXX";
            this.textBoxCodeTemplate.TextChanged += new System.EventHandler(this.textBoxCodeTemplate_TextChanged);
            // 
            // ArcheoCatalogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCodeTemplate);
            this.Controls.Add(this.labelCodeTemplate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonChoisPicDir);
            this.Controls.Add(this.textBoxChoisedDirectory);
            this.Controls.Add(this.labelChoiseImageDir);
            this.Name = "ArcheoCatalogConfig";
            this.Text = "Archeo Catalog Config";
            this.Load += new System.EventHandler(this.ArcheoCatalogConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FolderBrowserDialogImageDirectory_HelpRequest(object sender, EventArgs e)
        {
            //Todo: Not implemented
        }

        private void TextBoxCoisedDirectory_TextChanged(object sender, EventArgs e)
        {
            prgCtl.SetPicPathInRegistry(textBoxChoisedDirectory.Text);
        }

        #endregion

        private System.Windows.Forms.Label labelChoiseImageDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImageDirectory;
        private System.Windows.Forms.TextBox textBoxChoisedDirectory;
        private System.Windows.Forms.Button buttonChoisPicDir;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCodeTemplate;
        private System.Windows.Forms.TextBox textBoxCodeTemplate;
    }
}