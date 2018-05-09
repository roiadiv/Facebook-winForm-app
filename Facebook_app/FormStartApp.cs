using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facebook_app
{
    public partial class FormStartApp : Form
    {
        public FormStartApp()
        {
            InitializeComponent();
        }

        ////main form enter window
        private void buttonEnterToApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new FormMain();
            mainForm.ShowDialog();
        }
    }
}
