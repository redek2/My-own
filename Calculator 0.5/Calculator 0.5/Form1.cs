namespace Calculator_0._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "0";
        }

        string input;
        string operand1;
        string operand2;
        string sign;
        double result = 0.0;
        double pos = 0;



        private void zero_Click(object sender, EventArgs e)
        {
            // Sprawdza, czy input jest pusty lub zawiera tylko "0"
            if (string.IsNullOrEmpty(input))
            {
                richTextBox1.Text = "0";
            }
            else if(richTextBox1.Text == "0")
            {

            }
            else
            {
                // Je�li input zawiera ju� inn� cyfr�, dodaj zero normalnie
                input += "0";
                richTextBox1.Text = input;
            }
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

        private void pm_Click(object sender, EventArgs e)
        {
            double inside;
            double.TryParse(input, out inside);
            inside = inside * -1;
            input = inside.ToString();
            richTextBox1.Text = inside.ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            int p = 0;
            foreach (char a in input)
            {
                if (char.IsPunctuation(a))
                {
                    p = 1;
                }
            }

            if(p == 0)
            {
                richTextBox1.Text = "";
                input += ",";
                richTextBox1.Text += input;
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            sign = "+";
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            sign = "-";
            input = string.Empty;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operand1 = input;
            sign = "*";
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            sign = "/";
            input = string.Empty;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            richTextBox1.Text = string.Empty;

            result = Math.Pow(num1, 2);
            richTextBox1.Text = result.ToString();
        }

        private void pown_Click(object sender, EventArgs e)
        {
            operand1 = input;
            sign = "^";
            input = string.Empty;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            richTextBox1.Text = string.Empty;

            result = Math.Sqrt(num1);
            richTextBox1.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            input += Math.PI;
            richTextBox1.Text += input;
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double num1, x = 1;
            double.TryParse(input, out num1);

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            richTextBox1.Text = string.Empty;

            for(double i = 1; i <= num1; i++)
            {
                x *= i;
            }
            result = x;
            richTextBox1.Text = result.ToString();
        }

        private void ce_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            richTextBox1.Text = "0";
            operand1 = string.Empty;
            operand2 = string.Empty;
            sign = string.Empty;
            result = 0;
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
            else if(sign == "-")
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }
            else if(sign == "/")
            {
                result = num1 / num2;
                richTextBox1.Text = result.ToString();
            }
            else if(sign == "^")
            {
                result = Math.Pow(num1, num2);
                richTextBox1.Text = result.ToString();
            }
        }
    }
}
