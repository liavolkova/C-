namespace LV.project2.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            /*
            lblDisplay.Text = "Bla";
            txtInput.BackColor = Color.LightCoral;
            txtInput.Text = lblDisplay.Text;
            */
            lblAnswer.Text = "Ryan";
            txtAnswer.Text = "Ryan";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Beige;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           txtInput.BackColor = Color.Green;
        }

    }
}
