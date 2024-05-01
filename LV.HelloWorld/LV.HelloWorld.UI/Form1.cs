namespace LV.HelloWorld.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Visual Studio ~C#!";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit(); // this will also work
        }
    }
}