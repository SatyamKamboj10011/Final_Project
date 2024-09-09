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
    public partial class FormPots : Form
    {
        public FormPots()
        {
            InitializeComponent();
        }

        private void FormPots_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            FormPotsdes1 FormPotsdes1Form = new FormPotsdes1();
            FormPotsdes1Form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPotsdes1 FormPotsdes1Form = new FormPotsdes1();
            FormPotsdes1Form.Show();
        }
    }
}
