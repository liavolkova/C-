namespace LV.Demo1.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            //lblWelcome.Text = "World";
            lblWelcome.Text = txtInput.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Hello";
            txtInput.Text = "";            
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit(); // this also works 
        }
    }
}