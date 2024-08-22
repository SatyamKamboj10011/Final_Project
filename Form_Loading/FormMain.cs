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
        // FormOne is another form we have already created.
        // This is an object of type Form that will allows us
        // to control FormOne when we want to after we create
        // it in this forms constructor.
       
        private string username = "satyam";
        private int password = 1234;

        Form formOne;
        Form FormThree;
        // FormTwo can be accessed from FormMain
        Form FormTwo;

        Form formFive;

        // FormFive is within a separate project so we
        // need an object reference to it. This is created
        // as an object of type Form. Later on in the
        // constructor, the link to the real FormFive
        // will be created
        Form FormFive;

        //
        // Constructor FormMain
        // ====================
        public FormMain() {
            InitializeComponent();

            // This creates FormOne and FormTwo. The this command
            // tells each form who its parent is.
            //totalDistance = 1024;
            formOne = new FormOne(this);
            
            FormTwo = new FormTwo(this); 
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

        //
        // FormMain_Load()
        // ===============
        private void FormMain_Load(object sender, EventArgs e) {
        }

        //
        // buttonLoadFormOne_Click()
        // =========================
        private void buttonLoadFormOne_Click(object sender, EventArgs e) {
            // FormMain is the current visible form. It can be referenced with
            // the this keyword. Make FormMain invisible
            //this.Visible = false;

            // Now tell FormOne to show itself
                textBox2.Text = password.ToString();
            if (textBox1.Text == username)
            {
                formOne.ShowDialog();
            }
            else if (textBox1.Text=="")
            {
                MessageBox.Show("PLEASE ENTER A USERNAME");
            }
            else
            {
                MessageBox.Show("SORRY INCORRECT USERNAME");
            }
        }

        //
        // buttonLoadFormTwo_Click()
        // =========================
        private void buttoLoadFormTwo_Click(object sender, EventArgs e) {
            // Make FormMain invisible
           this.Hide();

            // Now tell FormTwo to show itself.
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

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = username;
            textBox2.Text=password.ToString();
            this.Hide();
            formOne.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
