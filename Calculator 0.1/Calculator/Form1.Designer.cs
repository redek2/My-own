namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pm = new Button();
            richTextBox1 = new RichTextBox();
            zero = new Button();
            comma = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            sqrt = new Button();
            power = new Button();
            chuj = new Button();
            divide = new Button();
            multi = new Button();
            minus = new Button();
            plus = new Button();
            equals = new Button();
            back = new Button();
            c = new Button();
            ce = new Button();
            percent = new Button();
            SuspendLayout();
            // 
            // pm
            // 
            pm.Location = new Point(44, 496);
            pm.Name = "pm";
            pm.Size = new Size(95, 64);
            pm.TabIndex = 0;
            pm.Text = "+/-";
            pm.UseVisualStyleBackColor = true;
            pm.Click += pm_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(541, 74);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // zero
            // 
            zero.Location = new Point(145, 496);
            zero.Name = "zero";
            zero.Size = new Size(95, 64);
            zero.TabIndex = 4;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // comma
            // 
            comma.Location = new Point(246, 496);
            comma.Name = "comma";
            comma.Size = new Size(95, 64);
            comma.TabIndex = 5;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = true;
            comma.Click += comma_Click;
            // 
            // three
            // 
            three.Location = new Point(246, 426);
            three.Name = "three";
            three.Size = new Size(95, 64);
            three.TabIndex = 8;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Location = new Point(145, 426);
            two.Name = "two";
            two.Size = new Size(95, 64);
            two.TabIndex = 7;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Location = new Point(44, 426);
            one.Name = "one";
            one.Size = new Size(95, 64);
            one.TabIndex = 6;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // six
            // 
            six.Location = new Point(246, 356);
            six.Name = "six";
            six.Size = new Size(95, 64);
            six.TabIndex = 11;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // five
            // 
            five.Location = new Point(145, 356);
            five.Name = "five";
            five.Size = new Size(95, 64);
            five.TabIndex = 10;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Location = new Point(44, 356);
            four.Name = "four";
            four.Size = new Size(95, 64);
            four.TabIndex = 9;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // nine
            // 
            nine.Location = new Point(246, 286);
            nine.Name = "nine";
            nine.Size = new Size(95, 64);
            nine.TabIndex = 14;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Location = new Point(145, 286);
            eight.Name = "eight";
            eight.Size = new Size(95, 64);
            eight.TabIndex = 13;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Location = new Point(44, 286);
            seven.Name = "seven";
            seven.Size = new Size(95, 64);
            seven.TabIndex = 12;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // sqrt
            // 
            sqrt.Location = new Point(246, 216);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(95, 64);
            sqrt.TabIndex = 17;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += sqrt_Click;
            // 
            // power
            // 
            power.Location = new Point(145, 216);
            power.Name = "power";
            power.Size = new Size(95, 64);
            power.TabIndex = 16;
            power.Text = "^";
            power.UseVisualStyleBackColor = true;
            power.Click += power_Click;
            // 
            // chuj
            // 
            chuj.Location = new Point(44, 216);
            chuj.Name = "chuj";
            chuj.Size = new Size(95, 64);
            chuj.TabIndex = 15;
            chuj.Text = "chuj";
            chuj.UseVisualStyleBackColor = true;
            chuj.Click += chuj_Click;
            // 
            // divide
            // 
            divide.Location = new Point(347, 216);
            divide.Name = "divide";
            divide.Size = new Size(95, 64);
            divide.TabIndex = 22;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multi
            // 
            multi.Location = new Point(347, 286);
            multi.Name = "multi";
            multi.Size = new Size(95, 64);
            multi.TabIndex = 21;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // minus
            // 
            minus.Location = new Point(347, 356);
            minus.Name = "minus";
            minus.Size = new Size(95, 64);
            minus.TabIndex = 20;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Location = new Point(347, 426);
            plus.Name = "plus";
            plus.Size = new Size(95, 64);
            plus.TabIndex = 19;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // equals
            // 
            equals.Location = new Point(347, 496);
            equals.Name = "equals";
            equals.Size = new Size(95, 64);
            equals.TabIndex = 18;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // back
            // 
            back.Location = new Point(347, 146);
            back.Name = "back";
            back.Size = new Size(95, 64);
            back.TabIndex = 26;
            back.Text = "<---";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // c
            // 
            c.Location = new Point(246, 146);
            c.Name = "c";
            c.Size = new Size(95, 64);
            c.TabIndex = 25;
            c.Text = "C";
            c.UseVisualStyleBackColor = true;
            c.Click += c_Click;
            // 
            // ce
            // 
            ce.Location = new Point(145, 146);
            ce.Name = "ce";
            ce.Size = new Size(95, 64);
            ce.TabIndex = 24;
            ce.Text = "CE";
            ce.UseVisualStyleBackColor = true;
            ce.Click += ce_Click;
            // 
            // percent
            // 
            percent.Location = new Point(44, 146);
            percent.Name = "percent";
            percent.Size = new Size(95, 64);
            percent.TabIndex = 23;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += percent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 592);
            Controls.Add(back);
            Controls.Add(c);
            Controls.Add(ce);
            Controls.Add(percent);
            Controls.Add(divide);
            Controls.Add(multi);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(equals);
            Controls.Add(sqrt);
            Controls.Add(power);
            Controls.Add(chuj);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(comma);
            Controls.Add(zero);
            Controls.Add(richTextBox1);
            Controls.Add(pm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button pm;
        private RichTextBox richTextBox1;
        private Button zero;
        private Button comma;
        private Button three;
        private Button two;
        private Button one;
        private Button six;
        private Button five;
        private Button four;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button sqrt;
        private Button power;
        private Button chuj;
        private Button divide;
        private Button multi;
        private Button minus;
        private Button plus;
        private Button equals;
        private Button back;
        private Button c;
        private Button ce;
        private Button percent;
    }
}
