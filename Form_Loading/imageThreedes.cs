//#####################################################################################
//
//  STUDIO  2 - HANDCRAFTS HEAVEN
//
//AUTHOR : GROUP 1(VIKASH KUMAR, SATYAM KAMBOJ, PRATHAM ARORA, KOMALPREET KAUR)
//
//######################################################################################

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
    public partial class imageThreedes : Form
    {
        public imageThreedes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormThree formThree = new FormThree(this);
            formThree.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageThreedes_Load(object sender, EventArgs e)
        {

        }
    }
}
