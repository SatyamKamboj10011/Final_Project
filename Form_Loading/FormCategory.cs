﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loading
{
    public partial class FormCategory : Form
    {
        Form FormParent;
        public FormCategory(Form FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
           

           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigation1_Load(object sender, EventArgs e)
        {

        }
    }
}
