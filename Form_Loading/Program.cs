using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loading {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the Registerdb instance
            Registerdb db = new Registerdb();

            // Pass the Registerdb instance to FormMain
            Application.Run(new FormMain(db));
        }
    }
}
