namespace LV.Project2._2.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblRyan.Text = "FVTC";
            lblClass.Text = "Liana Volkova";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblRyan.Text = "Ryan is the best";
            lblClass.Text = "C# is awesome";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
       
        }
    }
}