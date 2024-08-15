//
// FORM FIVE
// =========
// This is a project created by another team
// member that will be imported into the
// Form_Loading project.
//
// Revision History
// ================
// 26.02.2024 BRD Original version for Studio 2
//                team.
// 27.02.2024 BRD Revised with additional documentation.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFive {
    public partial class FormFive : Form {

        //
        // Constructor
        // ===========
        public FormFive() {
            InitializeComponent();            
        }

        //
        // buttonClose_Click
        // =================
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Visible = false;
        }

    }
}
