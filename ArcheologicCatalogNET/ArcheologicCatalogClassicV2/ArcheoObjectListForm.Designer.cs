namespace ArcheologicCatalogClassicV2
{
    partial class ArcheoObjectListForm
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
            this.listViewArcheoObjects = new System.Windows.Forms.ListView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewArcheoObjects
            // 
            this.listViewArcheoObjects.HideSelection = false;
            this.listViewArcheoObjects.Location = new System.Drawing.Point(13, 13);
            this.listViewArcheoObjects.Name = "listViewArcheoObjects";
            this.listViewArcheoObjects.Size = new System.Drawing.Size(775, 406);
            this.listViewArcheoObjects.TabIndex = 0;
            this.listViewArcheoObjects.UseCompatibleStateImageBehavior = false;
            this.listViewArcheoObjects.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(13, 435);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 31);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // ArcheoObjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listViewArcheoObjects);
            this.Name = "ArcheoObjectListForm";
            this.Text = "Archeo Object List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewArcheoObjects;
        private System.Windows.Forms.Button buttonNew;
    }
}