namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CardNumber = this.textBox1.Text;
            string ExpiryDate = this.textBox2.Text;
            string SecurityCode = this.textBox3.Text;

            bool wasValid = true;

            if (IsInputValid(CardNumber) == false)
            {
                MessageBox.Show("Pwease give me the card number >~<");
                wasValid = false;
            }

            if (IsInputValid(ExpiryDate) == false)
            {
                MessageBox.Show("Pwease give me the expiry date >~<");
                wasValid = false;
            }

            if (IsInputValid(SecurityCode) == false)
            {
                MessageBox.Show("Pwease give me the security code >~<");
                wasValid = false;
            }

            if (wasValid == true)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private bool IsInputValid(string input)
        {
            return input.Length >= 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
