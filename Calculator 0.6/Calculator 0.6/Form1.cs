namespace Calculator_0._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //richTextBox1; ----> vinput for example: 123 + 432
            //richTextBox2; ----> input as 123 or 432
            richTextBox1.Text = "0";
        }

        string vinput;
        string operand;
        string sign;
        double result = 0.0;

        private void zero_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vinput))
            {
                richTextBox1.Text = "0";
            }
            else if (richTextBox1.Text == "0")
            {

            }
            else
            {
                vinput += "0";
                richTextBox1.Text = vinput;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            vinput += "1";
            richTextBox1.Text = vinput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            vinput += "2";
            richTextBox1.Text = vinput;
        }

        private void three_Click(object sender, EventArgs e)
        {
            vinput += "3";
            richTextBox1.Text = vinput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            vinput += "4";
            richTextBox1.Text = vinput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            vinput += "5";
            richTextBox1.Text = vinput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            vinput += "6";
            richTextBox1.Text = vinput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            vinput += "7";
            richTextBox1.Text = vinput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            vinput += "8";
            richTextBox1.Text = vinput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            vinput += "9";
            richTextBox1.Text = vinput;
        }

        private void pm_Click(object sender, EventArgs e)
        {

        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            vinput += " + ";
            richTextBox1.Text = vinput;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            vinput += " - ";
            richTextBox1.Text = vinput;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            vinput += " * ";
            richTextBox1.Text = vinput;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            vinput += " / ";
            richTextBox1.Text = vinput;
        }

        private void pow_Click(object sender, EventArgs e)
        {

        }

        private void pown_Click(object sender, EventArgs e)
        {

        }

        private void sqrt_Click(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {

        }

        private void factorial_Click(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {
            vinput = string.Empty;
            sign = string.Empty;
            result = 0.0;
            richTextBox1.Text = "0";
            richTextBox2.Text = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(vinput, null);
                richTextBox2.Text = result.ToString();
            }
            catch (Exception ex)
            {
                richTextBox2.Text = "Błąd";
            }
        }
    }
}
