//
// FORM ONE
// ========
// FormOne is a child of FormMain
//
using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormOne : Form {

        Form FormParent;
        Form FormThree;
       
        

        //
        // Constructor FormOne
        // ===================
        public FormOne(Form FormParent) {
            InitializeComponent();
           
            //textBoxTotalDistance.Text = totalDistance.ToString();   

            // The parent of this form is FormMain. A reference
            // to it was passed in via this Constructor. Save it
            // so we know where to go back to.
            this.FormParent = FormParent;

            // Form One can also display Form Three ...
            FormThree = new FormThree(this);

          

        }

        private void FormOne_Load(object sender, EventArgs e) {
        }

        private void navigation1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
