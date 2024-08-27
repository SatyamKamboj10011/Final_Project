//
// FORM THREE
// ==========
// FormThree is the child of FormTwo
// 
using System;
using System.Windows.Forms;
using Form_Loading.Resources;

namespace Form_Loading {
    public partial class FormThree : Form {
        
        // The parent of this form is FormMain. A reference
        // to it was passed in via this Constructor. Save it
        // so we know where to go back to.
        Form FormParent;

        //
        // Constructor FormThree
        // =====================
        public FormThree(Form FormParent) {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void FormThree_Load(object sender, EventArgs e) {
        }

        
        //
        // buttonGoBack_Click()
        // ====================
        private void buttonGoBack_Click(object sender, EventArgs e) {
            // Hide FormThree now we have finished with it.
            this.Hide();


            // Go back to the parent of this form. It is FormMain.
            FormParent.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageOnedes imageOnedes = new imageOnedes();    
            imageOnedes.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imageTwodes imageTwodes = new imageTwodes();    
            imageTwodes.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imageThreedes imageThreedes = new imageThreedes();
            imageThreedes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            imageFourdes imageFourdes = new imageFourdes(); 
            imageFourdes.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imageFivedes imageFivedes = new imageFivedes();
            imageFivedes.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
