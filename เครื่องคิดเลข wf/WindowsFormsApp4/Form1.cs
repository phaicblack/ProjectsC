using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double sum1, sum2, ans;
        int a, b, c, d, e;
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+0 ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = 1;
            sum1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sum2 = double.Parse(textBox1.Text);
            if (a == 1)
            {
                ans = (sum1 + sum2);
                textBox1.Text = ans.ToString();
            }
            if (b == 1)
            {
                ans = (sum1 - sum2);
                textBox1.Text = ans.ToString();
            }
            if (c == 1)
            {
                ans = (sum1 * sum2);
                textBox1.Text = ans.ToString();
            }
            if (d == 1)
            {
                ans = (sum1 / sum2);
                textBox1.Text = ans.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = 1;
            sum1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = 1;
            sum1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            d = 1;
            sum1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sum1 = 0;
            sum2 = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
    }
}
