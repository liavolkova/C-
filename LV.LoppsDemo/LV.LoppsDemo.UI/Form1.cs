using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.LoppsDemo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private bool isOdd(int i)
        {
            return i % 2 == 1;
        }

        private bool isEven(int i)
        {
            return !isOdd(i);
        }
        */
        private void btnShow_Click(object sender, EventArgs e)
        {
            lstReps.Items.Clear();

            int reps =(int) nudReps.Value;

            for (int i=1; i<=reps; i++)
            {
                if ((i&1)==0)
                {
                  lstReps.Items.Add(i.ToString()+". Hi");
                }
                else
                {
                    lstReps.Items.Add(i.ToString() + ". Ryan");
                }
                
            }
        }
    }
}
