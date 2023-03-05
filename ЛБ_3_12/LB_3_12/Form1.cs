using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_3_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(textBox1.Text);
            Double y = Convert.ToDouble(textBox2.Text);
            Double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text += "Результаты работы программы" + Environment.NewLine;
            textBox4.Text += "При х = " + x + Environment.NewLine;
            textBox4.Text += "При y = " + y + Environment.NewLine;
            textBox4.Text += "При z = " + z + Environment.NewLine;
            int n = 0;
            if (radioButton2.Checked) n = 1;
            else if (radioButton3.Checked) n = 2;
            double N;
            switch (n)
            {
                case 0:
                    N = Math.Min(Math.Sinh(x) + y, y - z) / Math.Max(Math.Sinh(x), y);
                    textBox4.Text += "N = " + Convert.ToString(N) + Environment.NewLine;
                    break;
                case 1:
                    N = Math.Min(x*x + y, y - z) / Math.Max(x*x, y);
                    textBox4.Text += "N = " + Convert.ToString(N) + Environment.NewLine;
                    break;
                case 2:
                    N = Math.Min(Math.Exp(x) + y, y - z) / Math.Max(Math.Exp(x), y);
                    textBox4.Text += "N = " + Convert.ToString(N) + Environment.NewLine;
                    break;
                default:
                    textBox4.Text += "Решение не найдено" + Environment.NewLine;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}
