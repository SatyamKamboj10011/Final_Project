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
    public partial class FormCategory : Form
    {
        //Form FormParent;

       // public FormThree FormThree { get; private set; }

        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
           

           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPots formPots = new FormPots();
            formPots.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FormThree formThree = new FormThree();
            formThree.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            FormJewellery FormJewellery = new FormJewellery();
            FormJewellery.Show();
         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormDecoration  FormDecoration = new FormDecoration();
            FormDecoration.Show();
        }
    }
}
