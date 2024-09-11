﻿//#####################################################################################
//
//  STUDIO  2 - HANDCRAFTS HEAVEN
//
//AUTHOR : GROUP 1(VIKASH KUMAR, SATYAM KAMBOJ, PRATHAM ARORA, KOMALPREET KAUR)
//
//######################################################################################


// FORM TWO
// ========
// FormTwo has a child of its own called
// FormThree. FormThree is a grandchild of
// FormMain.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormTwo : Form {        

      Form FormParent; 
      Form FormThree;
      private int currentRecord;

        private Registerdb db;
        
        //----------------------
        // Constructor FormTwo
        //-----------------------
        public FormTwo(Form FormParent,Registerdb dbInstance) { 
            InitializeComponent();

            // The parent of this form is FormMain. A reference
            // to it was passed in via this Constructor. Save it
            // so we know where to go back to.
            this.FormParent = FormParent;
            this.db = dbInstance;
            // Form Two can also display Form Three ...
            FormThree = new FormThree(this);

          
        }

        //
        // FormTwo_Load()
        // ===============
        private void FormTwo_Load(object sender, EventArgs e) {        
        }

        //
        // buttonGoBack_Click()
        // ====================
        private void buttonGoBack_Click(object sender, EventArgs e) {

            // Hide FormTwo and go back to the parent form
            Hide();
            FormParent.Show();
        }

        //
        // buttonLoadFormThree_Click()
        // ===========================
        private void buttonLoadFormThree_Click(object sender, EventArgs e)
        {
            // Hide FormTwo now we have finished with it.
            //this.Hide();

            //Load Form Three.
            // FormThree.Show();

            // Add the new user to the dbDemo
            
           
                // Validate input (ensure fields are not empty)
                if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox2.Text, out int password))
                {
                    // Add the new user to the Registerdb
                    db.AddRecord(textBox1.Text, password);
                    MessageBox.Show("Signed up successfully!");

                    // Clear text boxes after successful sign-up
                    textBox1.Clear();
                    textBox2.Clear();

            }
                else
                {
                    MessageBox.Show("Please enter a valid username and password.");
                }
            
        }

        private void FormTwo_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
