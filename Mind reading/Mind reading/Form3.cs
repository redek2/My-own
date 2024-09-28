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
    public partial class resultForm : Form
    {
        private double number;

        public resultForm(double number)
        {
            InitializeComponent();  //You're thinking of the number x
            this.number = number;
            textBox1.Text = "You're thinking of the number "+number;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
