namespace Calculator_0._3
{
    public partial class Form1 : Form
    {
        string input;
        string operand1;
        string operand2;
        string sign;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
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

        private void equals_Click(object sender, EventArgs e)
        {
            double num1, num2;
            operand2 = input;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            richTextBox1.Text = string.Empty;

            if (sign == "+")
            {
                result = num1 + num2;
                richTextBox1.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }
            else if (sign == "/")
            {
                result = num1 / num2;
                richTextBox1.Text = result.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            sign = "+";
            operand1 = input;
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            sign = "-";
            operand1 = input;
            input = string.Empty;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            sign = "*";
            operand1 = input;
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            sign = "/";
            operand1 = input;
            input = string.Empty;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            double pow;
            double.TryParse(input, out pow);
            input = string.Empty;
            richTextBox1.Text = "";
            pow = Math.Pow(pow, 2);
            result = pow;
            richTextBox1.Text = pow.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double sqrt;
            double.TryParse(input, out sqrt);
            input = string.Empty;
            richTextBox1.Text = "";
            sqrt = Math.Sqrt(sqrt);
            result = sqrt;
            richTextBox1.Text = sqrt.ToString();
        }

        private void ce_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            sign = string.Empty;
            result = 0.0;
            richTextBox1.Text = "";
        }

        private void pm_Click(object sender, EventArgs e)
        {
            double inside;
            double.TryParse(input, out inside);
            inside = inside * -1;
            input = inside.ToString();
            richTextBox1.Text = inside.ToString();
        }


    }
}
