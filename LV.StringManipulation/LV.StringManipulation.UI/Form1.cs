using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.StringManipulation.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string s = txtInput.Text;  
            txtTrim.Text = s.Trim();
            txtLength.Text = s.Length.ToString();
            txtContains.Text = s.Contains("@").ToString();
            txtUpper.Text = s.ToUpper();
            txtLower.Text= s.ToLower(); 

            int index = s.IndexOf(" ");
            txtIndex.Text=index.ToString();

            if (index >= 0)
            txtSubstring.Text=s.Substring(0, index);

            //Exercise
            if (s.Length <3 )
            {
                txtExercise.Text = "";
            }
            else
            {
                string firstCh =s.Substring(0,1).ToLower(); //lower case first character
                string theRest = s.Substring(1).ToLower(); //rest of the string (lower case)
                int indexOf = theRest.IndexOf(firstCh);

                if (indexOf >= 0)
                {
                    string answer = s.Substring(1, indexOf);
                    txtExercise.Text= answer;
                }
                else
                {
                    txtExercise.Text = "";
                }
            }
        }
    }
}
