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
    public partial class Systemschislenya : Form
    {

        public Systemschislenya()
        {
            InitializeComponent();
        }

        private void Systemschislenya_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int i = Convert.ToInt32(a);
            if (radioButton1.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 2);
            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 16);
            }
            else if (radioButton3.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 8);
            }
               
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 16);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 8);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 6);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
