namespace Mind_reading
{
    public partial class Form1 : Form
    {
        private double number;

        public Form1()
        {
            InitializeComponent();
            textBox2.Select(); //fokus na textBox2
            this.Icon = new Icon("waves.ico"); //plik ico musi byæ max 64x64 na samym koñcu projektu
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            double number;
            string numlit;
            if (textBox2.TextLength >= 1)
            {
                numlit = textBox2.Text;
                double.TryParse(numlit, out number);
                Progressform progressform = new Progressform(number);
                progressform.Show();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //mo¿na wpisaæ tylko cyfry i rzeczy typu backspace
            }
            
            if(e.KeyChar == '0')
            {
                e.Handled = true; //nie mo¿na wpisaæ 0
            }

            if(textBox2.Text == "1" && e.KeyChar == '0')
            {
                e.Handled = false; //mo¿na wpisaæ 0 ale tylko jeœli text to "1"
            }
            else if(textBox2.TextLength >= 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
