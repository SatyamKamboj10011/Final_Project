using System;
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
    public partial class FormJewellery : Form
    {
        public FormJewellery()
        {
            InitializeComponent();
        }

        private void navigation1_Load(object sender, EventArgs e)
        {

        }

        private void FormJewellery_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormJewdes1 FormJewdes1Form = new FormJewdes1();
            FormJewdes1Form.Show();
        }
    }
}
