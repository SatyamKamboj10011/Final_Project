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
    public partial class Navigation : UserControl
    {
        private Registerdb db;

        public Navigation()
        {
            InitializeComponent();
        }
        public Navigation(Registerdb dbInstance)
        {
            InitializeComponent();
            db = new Registerdb();
        }

        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            // Get the current form that contains this navigation control
            Form currentForm = FindForm();


            // Close the current form
           

            // Create a new instance of FormThree and pass the current form as the parent
          
            FormThree formThree = new FormThree(currentForm);
            formThree.Show();
           //formThree.BringToFront();

            // Show FormThree and bring it to the front

           //  formThree.BringToFront();
        }

        private void buttonLoginPage_Click(object sender, EventArgs e)
        {
           
            // Get the current form that contains this navigation control
            Form currentForm = FindForm();

            // Close the current form (FormOne)
            currentForm.Hide();

            // Show the main form (FormMain)
            FormMain mainForm = new FormMain(db); 
            mainForm.Show();
            mainForm.BringToFront();


        }

      

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            Form currentForm = FindForm();

            currentForm.Hide();
            

            FormTwo formTwo = new FormTwo(currentForm, db);
            formTwo.Show();
            formTwo.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the current form that contains this navigation control
            Form currentForm = FindForm();

            // Close the current form
            currentForm.Hide();

            // Create a new instance of FormCart and show it
            FormCart formCart = new FormCart();
            formCart.Show();
            formCart.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form currentForm = FindForm();

            currentForm.Hide();


            FormCategory formCategory = new FormCategory();
            formCategory.Show();
            formCategory.BringToFront();

        }
    }
}
