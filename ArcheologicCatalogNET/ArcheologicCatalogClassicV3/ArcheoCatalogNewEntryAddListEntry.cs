﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassicV3
{
    public partial class ArcheoCatalogNewEntryAddListEntry : Form
    {
        public ArcheoCatalogNewEntryAddListEntry(string labelText)
        {
            InitializeComponent();
            this.labelTyp.Text = labelText;
            this.Text = "New " + labelText;
        }

        internal object getTextBoxText()
        {
            throw new NotImplementedException();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
    }
}
