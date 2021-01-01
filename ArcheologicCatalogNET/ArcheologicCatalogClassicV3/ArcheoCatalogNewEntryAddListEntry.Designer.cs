
namespace ArcheologicCatalogClassicV3
{
    partial class ArcheoCatalogNewEntryAddListEntry
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
            this.textBoxNewEntry = new System.Windows.Forms.TextBox();
            this.labelTyp = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewEntry
            // 
            this.textBoxNewEntry.Location = new System.Drawing.Point(23, 56);
            this.textBoxNewEntry.Name = "textBoxNewEntry";
            this.textBoxNewEntry.Size = new System.Drawing.Size(251, 20);
            this.textBoxNewEntry.TabIndex = 0;
            this.textBoxNewEntry.Text = "New entry";
            // 
            // labelTyp
            // 
            this.labelTyp.AutoSize = true;
            this.labelTyp.Location = new System.Drawing.Point(34, 25);
            this.labelTyp.Name = "labelTyp";
            this.labelTyp.Size = new System.Drawing.Size(62, 13);
            this.labelTyp.TabIndex = 1;
            this.labelTyp.Text = "label of Typ";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(280, 53);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(33, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ArcheoCatalogNewEntryAddListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 88);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTyp);
            this.Controls.Add(this.textBoxNewEntry);
            this.Name = "ArcheoCatalogNewEntryAddListEntry";
            this.Text = "AddListEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewEntry;
        private System.Windows.Forms.Label labelTyp;
        private System.Windows.Forms.Button buttonOK;
    }
}