using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Инженерный_калькулятор
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public const double PI = 3.1415926535897931;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            {
                D = "=";
                n2 = true;
                textBox1.Text = res.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double result = Math.Sin(Convert.ToDouble(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double res = double.Parse(textBox1.Text);
            res = Math.Cos(res);
            textBox1.Text = res.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double res = double.Parse(textBox1.Text);
            res = Math.Tan(res);
            textBox1.Text = res.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double res = double.Parse(textBox1.Text);
            res = Math.Log10(res);
            textBox1.Text = res.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double res = double.Parse(textBox1.Text);
            res = Math.Exp(res);
            textBox1.Text = res.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double res = double.Parse(textBox1.Text);
            res = Math.Log(res);
            textBox1.Text = res.ToString();
        }
    }
}
           

