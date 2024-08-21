namespace Calculator_0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        double chng;

        private void change()
        {
            //double a = input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "0";
            richTextBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "1";
            richTextBox1.Text += input;

        }

        private void two_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "2";
            richTextBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "3";
            richTextBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "4";
            richTextBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "5";
            richTextBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "6";
            richTextBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "7";
            richTextBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "8";
            richTextBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += "9";
            richTextBox1.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += ".";
            richTextBox1.Text += input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            richTextBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    richTextBox1.Text = result.ToString();
                }
                else
                {
                    richTextBox1.Text = "Can't divide by zero";
                }

            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void pm_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "-";
            input = input;
            richTextBox1.Text += input;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
    }
}
