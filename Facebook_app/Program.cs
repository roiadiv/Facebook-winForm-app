using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facebook_app
{

    // $G$ THE-001 (-15) Your grade on diagrams document - 85. Please see comments inside the document.

    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStartApp());
        }
    }
}
