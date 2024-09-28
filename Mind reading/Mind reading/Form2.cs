using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mind_reading
{
    public partial class Progressform : Form
    {
        private double number;

        public Progressform(double number)
        {
            InitializeComponent();
            this.number = number;
            this.Icon = new Icon("waves.ico");
            this.Select(); // ustawia fokus tak że jest na wszystko
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            delayTimer.Interval = 1000;
            delayTimer.Tick -= delayTimer_Tick;
            delayTimer.Tick += delayTimer_Tick;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop(); // Zatrzymanie timera
                delayTimer.Start();
            }


            if (progressBar1.Value < 25)
            {
                textBox1.Text = "Analyzing brainwaves...";
            }
            else if (progressBar1.Value >= 25 && progressBar1.Value < 50)
            {
                textBox1.Text = "Scanning memories...";
            }
            else if (progressBar1.Value >= 50 && progressBar1.Value < 75)
            {
                textBox1.Text = "Calculating probabilities...";
            }
            else
            {
                textBox1.Text = "Decoding thoughts...";
            }


        }

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop(); // Zatrzymanie timera
            resultForm resultform = new resultForm(number);
            resultform.Show(); // Wyświetlenie nowego formularza
            this.Close(); // Zamknięcie bieżącego formularza
        }

    }
}
