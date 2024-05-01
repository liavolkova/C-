using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.MethodsDemo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int AddIntegers(int num1, int num2)
        {
            /*int sum = num1 + num2;
            return sum;*/

            return num1+num2;
        }
        //method overloading...(more than 1 method with the same name)
        private int AddIntegers(int num1, int num2, int num3)
        {
            return num1 + num2+num3;
        }

        
        private bool IsOdd(int number)
        {
            return number % 2 == 1;
        }

         

        //access-modifier(private/public), return type(void), name,(parameters)
        private void ChangePanelColors(Color color)
        {
            pnl1.BackColor = color;
            pnl2.BackColor = color;
            pnl3.BackColor = color;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ChangePanelColors(Color.Red);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ChangePanelColors(Color.Blue);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ChangePanelColors(Color.Green);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);

            Color color = Color.FromArgb(r, g, b);
            ChangePanelColors(color);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();  
            frmAbout.Show();//non-modal
            //frmAbout.ShowDialog();modal
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
