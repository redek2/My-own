namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;    //String storing user input
        string operand1 = string.Empty; //String storing first operand
        string operand2 = string.Empty; //String storing second operand
        char operation;                 //Char for operation
        double result = 0.0;            //Calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = ""; //z tego co widzia³em to this nie by³o jakoœ potrzebne ale do sprawdzenia
            input += "0";
            this.richTextBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "1";
            this.richTextBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "2";
            this.richTextBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "3";
            this.richTextBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "4";
            this.richTextBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "5";
            this.richTextBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "6";
            this.richTextBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "7";
            this.richTextBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "8";
            this.richTextBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "9";
            this.richTextBox1.Text += input;
        }

        private void comma_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += ",";
            this.richTextBox1.Text += input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

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
                    richTextBox1.Text = "DIV/Zero!";
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

        private void sqrt_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void power_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void pm_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void percent_Click(object sender, EventArgs e)
        {

        }

        private void chuj_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(input);
        }
    }
}