using System.Windows.Forms;

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fNameValue = firstName.Text;
            String mNameValue = middleName.Text;
            String lNameValue = lastName.Text;
            String SuffixValue = Suffix.Text;
            
            
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello! {fNameValue} {mNameValue} {lNameValue} {SuffixValue}!", "Good Day!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
 
                                                              
                                                              

        }
    }
}
