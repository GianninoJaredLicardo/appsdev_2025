namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string lNamevalue = lastname.Text;
            MessageBox.Show($"Hello World {fNameValue} {lNamevalue}", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
    }
}
