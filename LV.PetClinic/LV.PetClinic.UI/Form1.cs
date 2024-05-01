using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.PetClinic.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare variables
        double total = 0;
        double grooming = 60;
        double visit = 35;
        double allergy = 90;
        double wash = 45;
        double teeth = 30;
        double ear = 25;
        double vax = 50;
        double brushing = 40;

        private void chkVisit_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = string.Empty;
            if(chkVisit.Checked == true)
            {
                total = total + visit;
                lblVisit.Text = "$35";
            }
            else
            {
                total = total - visit;
                lblVisit.Text = "";

            }
            txtTotal.Text = total.ToString("c");
        }

        private void chkGrooming_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text=string.Empty;
            if (chkGrooming.Checked == true)
            {
                total += grooming;
                lblGrooming.Text = "$60";
            }
            else
            {
                total -= grooming;
                lblGrooming.Text = "";
            }
            txtTotal.Text = total.ToString("c");
        }

        private void chkWash_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = string.Empty;
            if(chkWash.Checked == true)
            {
                total += wash;
                lblWash.Text = "$45";
            }
            else
            {
                total -= wash;
                lblWash.Text = "";
            }
            txtTotal.Text=total.ToString("c");
        }

        private void chkAllergy_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text=string.Empty;
           if(chkAllergy.Checked==true)
            {
                total += allergy;
                lblAllergy.Text = "$90";
            }
            else
            {
                total -= allergy;
                lblAllergy.Text = "";
            }
           txtTotal.Text=total.ToString("C");
        }

        private void chkTeeth_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = string.Empty;
            if (chkTeeth.Checked == true)
            {
                total += teeth;
                lblTeeth.Text = "$30";
            }
            else
            {
                total -= teeth;
                lblTeeth.Text = "";
            }
                txtTotal.Text = total.ToString("c");
        }

        private void chkEar_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = String.Empty;
            if(chkEar.Checked == true)
            {
                total += ear;
                lblEar.Text = "$25";
            }
            else
            {
                total -= ear;
                lblEar.Text = "";
            }
            txtTotal.Text = total.ToString("c");
        }

        private void chkVax_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = string.Empty;
            if (chkVax.Checked == true)
            {
                total += vax;
                lblVax.Text = "$50";
            }
            else
            {
                total -= vax;
                lblVax.Text = "";
            }
            txtTotal.Text=total.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
            chkVisit.Checked = false;
            chkGrooming.Checked = false;
            chkWash.Checked = false;
            chkAllergy.Checked = false;
            chkTeeth.Checked = false;
            chkEar.Checked = false;
            chkVax.Checked = false;
            chkBrushing.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkBrushing_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text=string.Empty; 
            if(chkBrushing.Checked == true)
            {
                total += brushing;
                lblBrushing.Text = "$40";
            }
            else
            {
                total -= brushing;
                lblBrushing.Text = "";
            }
            txtTotal.Text = total.ToString("c");
        }

    }
}
