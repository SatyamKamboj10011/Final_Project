//
// FORM SWITCHING EXAMPLE
// ======================
// Demonstrates how to switch between different
// forms connected in the same application.
//
// FormMain is the main form. It has two children
// and one grandchild:
//
//          FormMain--> FormOne    
//                 '--> FormTwo --> FormThree
//
// Look at the code to understand why Form One
// cannot show Form Two but it can go back to
// FormMain.
//
// Look at the code to understand why FormTwo
// can go back to FormMain or show FormThree.
//
// Revision History
// ================
// 21.05.2023 BRD Original version.
//
using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormMain : Form {
       
       
     

        private Registerdb db;

        Form formOne;
        Form FormThree;
        Form FormTwo;
        Form formFive;

        //--------------------------------------------------
        // FormFive is within a separate project so we
        // need an object reference to it. This is created
        // as an object of type Form. Later on in the
        // constructor, the link to the real FormFive
        // will be created
        //-------------------------------------------------
        Form FormFive;

        //----------------------
        // Constructor FormMain
        // --------------------
        public FormMain(Registerdb dbInstance) { 
            InitializeComponent();
            db = dbInstance;

            //Initializing Forms
            formOne = new FormOne(this);
            FormTwo = new FormTwo(this, dbInstance);
            FormThree = new FormThree(this);


            // FormFive is just like the other forms,
            // but it is not in this project. It is
            // in a separate project created by another
            // team member. So to access it, we need
            // to create a reference to it using the
            // Form object created earlier.
            // To reach over to FormFive, we also need
            // to say which project it is located in.
            //
            FormFive = new FormFive.FormFive();            
        }

        //-----------------
        // FormMain_Load()
        //-----------------
        private void FormMain_Load(object sender, EventArgs e) {
        }

        //--------------------------
        // buttonLoadFormOne_Click()
        //--------------------------
        private void buttonLoadFormOne_Click(object sender, EventArgs e) {
        //----------------------------------------------------------------
            // Check if the username and password match any record
            //------------------------------------------------------------
            if (int.TryParse(textBox2.Text, out int password))
            {
                if (db.ValidateUser(textBox1.Text, password))
                {
                    MessageBox.Show("Login successful!");
                    formOne.ShowDialog(); // Show the next form if login is successful
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid password.");
            }
        }

        // ---------------------------
        // buttonLoadFormTwo_Click()
        // ---------------------------
        private void buttoLoadFormTwo_Click(object sender, EventArgs e) {
            //----------------------------------
            // Make FormMain invisible
            // Now tell FormTwo to show itself.
            //-----------------------------------
            Hide();

            
            FormTwo.Show();
        }
                
        //
        // buttonShowFormFive_Click
        // ========================
        // This uses the reference created earlier for FormFive to load
        // show it.
        private void buttonShowFormFive_Click(object sender, EventArgs e) {
            FormFive.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
