using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.SwitchCase.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            if (double.TryParse(txtSubtotal.Text, out subtotal))
            {
                double percentOff = 0;
                double dollarsOff = 0;

                switch (txtCode.Text)
                {
                    case "$10off":
                        subtotal -= 10;
                        break;
                    case "5%off": subtotal *= .95; break;
                    case "$10or5%off":
                        percentOff = subtotal * .95;
                        dollarsOff = subtotal - 10;
                        if (percentOff < dollarsOff)
                        {
                            subtotal = percentOff;
                        }
                        else
                        {
                            subtotal = dollarsOff;
                        }
                        break;

                }

                if (subtotal < 0)
                {
                    subtotal = 0;
                }

                MessageBox.Show("Your total is: " + subtotal.ToString("c"));
            }
            
        }
    }
}
