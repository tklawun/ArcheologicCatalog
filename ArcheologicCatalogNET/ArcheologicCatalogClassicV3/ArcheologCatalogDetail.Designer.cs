using System;

namespace ArcheologicCatalogClassicV3
{
    partial class ArcheologCatalogDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcheologCatalogDetail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxTypeOfBuild = new System.Windows.Forms.ComboBox();
            this.textBoxSpecialFeatures = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelParticularities = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCoordinate = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelTypeOfBuild = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRockType = new System.Windows.Forms.Label();
            this.buttonChoisePicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonExportToWord = new System.Windows.Forms.Button();
            this.comboBoxRockTyp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(286, 823);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1378, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxTypeOfBuild
            // 
            this.comboBoxTypeOfBuild.FormattingEnabled = true;
            this.comboBoxTypeOfBuild.Items.AddRange(new object[] {
            "Aktroter QN20-A",
            "Architrav  QN20-AR",
            "Eckpilaster Voluten und Akanthusblätter QN20-EP",
            "Fußprofil und verschiedene Plinthe QN20-FP",
            "Ionische Eierstabkyma QN20-IK",
            "Kanellüren QN20-KA",
            "Konsolen QN20-KO",
            "Korintisches Kapitell und Pilaster QN20-K",
            "Säulen QN20-SÄ",
            "Säulenbasis QN20-SB",
            "Sofitenecken QN20-SE",
            "Treppen und Vorhalle QN20-T",
            "Treppenwange QN20-TW",
            "Tympanonecke QN20-TE",
            "Zahnstab QN20-ZS"});
            this.comboBoxTypeOfBuild.Location = new System.Drawing.Point(289, 98);
            this.comboBoxTypeOfBuild.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTypeOfBuild.Name = "comboBoxTypeOfBuild";
            this.comboBoxTypeOfBuild.Size = new System.Drawing.Size(522, 33);
            this.comboBoxTypeOfBuild.TabIndex = 71;
            this.comboBoxTypeOfBuild.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfBuild_SelectedIndexChanged);
            // 
            // textBoxSpecialFeatures
            // 
            this.textBoxSpecialFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpecialFeatures.Location = new System.Drawing.Point(288, 646);
            this.textBoxSpecialFeatures.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSpecialFeatures.Multiline = true;
            this.textBoxSpecialFeatures.Name = "textBoxSpecialFeatures";
            this.textBoxSpecialFeatures.Size = new System.Drawing.Size(1376, 137);
            this.textBoxSpecialFeatures.TabIndex = 69;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(286, 412);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(1378, 187);
            this.textBoxDescription.TabIndex = 68;
            // 
            // textBoxCoordinate
            // 
            this.textBoxCoordinate.Location = new System.Drawing.Point(288, 162);
            this.textBoxCoordinate.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCoordinate.Name = "textBoxCoordinate";
            this.textBoxCoordinate.Size = new System.Drawing.Size(228, 31);
            this.textBoxCoordinate.TabIndex = 67;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(950, 227);
            this.textBoxDepth.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(196, 31);
            this.textBoxDepth.TabIndex = 65;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(618, 225);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(196, 31);
            this.textBoxWidth.TabIndex = 64;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(288, 225);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(196, 31);
            this.textBoxHeight.TabIndex = 63;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(288, 35);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(228, 31);
            this.textBoxCode.TabIndex = 61;
            // 
            // labelParticularities
            // 
            this.labelParticularities.AutoSize = true;
            this.labelParticularities.Location = new System.Drawing.Point(54, 650);
            this.labelParticularities.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParticularities.Name = "labelParticularities";
            this.labelParticularities.Size = new System.Drawing.Size(163, 25);
            this.labelParticularities.TabIndex = 59;
            this.labelParticularities.Text = "Besonderheiten";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(54, 444);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(144, 25);
            this.labelDescription.TabIndex = 58;
            this.labelDescription.Text = "Beschreibung";
            // 
            // labelCoordinate
            // 
            this.labelCoordinate.AutoSize = true;
            this.labelCoordinate.Location = new System.Drawing.Point(54, 165);
            this.labelCoordinate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCoordinate.Name = "labelCoordinate";
            this.labelCoordinate.Size = new System.Drawing.Size(180, 25);
            this.labelCoordinate.TabIndex = 57;
            this.labelCoordinate.Text = "Koordinaten (Ko.)";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(868, 231);
            this.labelDepth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(60, 25);
            this.labelDepth.TabIndex = 55;
            this.labelDepth.Text = "Tiefe";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(540, 231);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(68, 25);
            this.labelWidth.TabIndex = 54;
            this.labelWidth.Text = "Breite";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(54, 229);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(63, 25);
            this.labelHeight.TabIndex = 53;
            this.labelHeight.Text = "Höhe";
            // 
            // labelTypeOfBuild
            // 
            this.labelTypeOfBuild.AutoSize = true;
            this.labelTypeOfBuild.Location = new System.Drawing.Point(54, 102);
            this.labelTypeOfBuild.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTypeOfBuild.Name = "labelTypeOfBuild";
            this.labelTypeOfBuild.Size = new System.Drawing.Size(173, 25);
            this.labelTypeOfBuild.TabIndex = 52;
            this.labelTypeOfBuild.Text = "Baubezeichnung";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(54, 38);
            this.labelCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(116, 25);
            this.labelCode.TabIndex = 51;
            this.labelCode.Text = "Code (Co.)";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(58, 1425);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 44);
            this.buttonSave.TabIndex = 72;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1534, 1425);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(132, 44);
            this.buttonClose.TabIndex = 73;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRockType
            // 
            this.labelRockType.AutoSize = true;
            this.labelRockType.Location = new System.Drawing.Point(54, 298);
            this.labelRockType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRockType.Name = "labelRockType";
            this.labelRockType.Size = new System.Drawing.Size(149, 25);
            this.labelRockType.TabIndex = 75;
            this.labelRockType.Text = "Gesteinstypus";
            // 
            // buttonChoisePicture
            // 
            this.buttonChoisePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoisePicture.Location = new System.Drawing.Point(58, 985);
            this.buttonChoisePicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChoisePicture.Name = "buttonChoisePicture";
            this.buttonChoisePicture.Size = new System.Drawing.Size(178, 44);
            this.buttonChoisePicture.TabIndex = 76;
            this.buttonChoisePicture.Text = "Bild auswählen";
            this.buttonChoisePicture.UseVisualStyleBackColor = true;
            this.buttonChoisePicture.Click += new System.EventHandler(this.buttonChoisePicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(54, 840);
            this.labelPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(108, 25);
            this.labelPicture.TabIndex = 77;
            this.labelPicture.Text = "Abbildung";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(1302, 1435);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(166, 25);
            this.labelStatus.TabIndex = 78;
            this.labelStatus.Text = "Dies ist ein Text";
            this.labelStatus.Visible = false;
            // 
            // buttonExportToWord
            // 
            this.buttonExportToWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExportToWord.Location = new System.Drawing.Point(286, 1425);
            this.buttonExportToWord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportToWord.Name = "buttonExportToWord";
            this.buttonExportToWord.Size = new System.Drawing.Size(250, 44);
            this.buttonExportToWord.TabIndex = 79;
            this.buttonExportToWord.Text = "Export nach Word";
            this.buttonExportToWord.UseVisualStyleBackColor = true;
            this.buttonExportToWord.Click += new System.EventHandler(this.buttonExportToWord_Click);
            // 
            // comboBoxRockTyp
            // 
            this.comboBoxRockTyp.FormattingEnabled = true;
            this.comboBoxRockTyp.Location = new System.Drawing.Point(288, 295);
            this.comboBoxRockTyp.Name = "comboBoxRockTyp";
            this.comboBoxRockTyp.Size = new System.Drawing.Size(523, 33);
            this.comboBoxRockTyp.TabIndex = 80;
            // 
            // ArcheologCatalogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1481);
            this.Controls.Add(this.comboBoxRockTyp);
            this.Controls.Add(this.buttonExportToWord);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.buttonChoisePicture);
            this.Controls.Add(this.labelRockType);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTypeOfBuild);
            this.Controls.Add(this.textBoxSpecialFeatures);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCoordinate);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelParticularities);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCoordinate);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelTypeOfBuild);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArcheologCatalogDetail";
            this.Text = "Archäologischer Katalog - Objekt Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArcheologCatalogDetail_FormClosing);
            this.Load += new System.EventHandler(this.ArcheologCatalogDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTypeOfBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTypeOfBuild;
        private System.Windows.Forms.TextBox textBoxSpecialFeatures;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCoordinate;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelParticularities;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCoordinate;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelTypeOfBuild;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRockType;
        private System.Windows.Forms.Button buttonChoisePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelPicture;
        internal System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonExportToWord;
        private System.Windows.Forms.ComboBox comboBoxRockTyp;
    }
}