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
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            // Get the current form that contains this navigation control
            Form currentForm = FindForm();


            // Close the current form
            currentForm.Close();

            // Create a new instance of FormThree and pass the current form as the parent
            FormThree formThree = new FormThree(currentForm);
            formThree.Show();


            // Show FormThree and bring it to the front

            // formThree.BringToFront();
        }

        private void buttonLoginPage_Click(object sender, EventArgs e)
        {
           
            // Get the current form that contains this navigation control
            Form currentForm = FindForm();

            // Close the current form (FormOne)
            currentForm.Close();

            // Show the main form (FormMain)
            FormMain mainForm = new FormMain(); 
            mainForm.Show();

            
        }

      

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            Form currentForm = FindForm();

            currentForm.Close();
            

            FormTwo formTwo = new FormTwo(currentForm);
            formTwo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form currentForm = FindForm();

            currentForm.Close();


            FormCategory formCategory = new FormCategory(currentForm);
            formCategory.Show();
        }
    }
}
