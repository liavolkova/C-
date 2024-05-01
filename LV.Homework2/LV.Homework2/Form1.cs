namespace LV.Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Liana Volkova
        Homework 2
        */

        private void btnWI_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "Wisconsin";
            txtCity.Text = "Madison";
            
        }

        private void btnMI_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "Michigan";
            txtCity.Text = "Lansing";
        }

        private void btnMN_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "Minnesota";
            txtCity.Text = "Saint Paul";
        }

        private void btnIowa_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "Iowa";
            txtCity.Text = "Des Moines";
        }

        private void btnIL_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "Illinois";
            txtCity.Text = "Springfield";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "";
            txtCity.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}