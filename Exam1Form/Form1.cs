using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1Volkova
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblFVTC.Text = "Liana Volkova"; //To change the FVTC button to the name
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFVTC.Text = "Fox Valley Technical College"; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
