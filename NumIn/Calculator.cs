using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumIn
{
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {

        }
        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch
                {

                }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': c = a + b;
                    break;
                case '-':c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '÷': c = a / b;
                    break;
                case '√': c = Math.Sqrt(a);
                    break;
            }
            textBox1.Text = c.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void Koren(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();

        }
        private void x2(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = a * a;
            textBox1.Text = c.ToString();
        }

    }
}
