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
    public partial class DiscriminantForm : Form
    {
        public DiscriminantForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Шаги решения:";
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            float a_1 = Convert.ToSingle(a);
            float b_1 = Convert.ToSingle(b);
            float с_1 = Convert.ToSingle(c);
            int z = 0;
            if (a_1 % 1 != 0 || b_1 % 1 != 0 || с_1 % 1 != 0)
            {
                do
                {
                    a_1 = a_1 * 10;
                    b_1 = b_1 * 10;
                    с_1 = с_1 * 10;
                    z = z + 1;
                }
                while (a_1 % 1 == 0 & b_1 % 1 == 0 & с_1 % 1 == 0);

            }

            float discriminant = (b_1 * b_1) - (4 * a_1 * с_1);
            label5.Text = "1) Находим дискриминант нашего уравнения через формулу b^2 - 4*a*c, в нашем случае он равен " + discriminant.ToString();
            if (discriminant > 0)
            {
                float dis = Convert.ToSingle(Math.Sqrt(discriminant));
                label6.Text = "2) Дискриминант больше нуля, значит будет 2 корня. Найдем корень из дискриминанта, в нашем случае он будет " + dis.ToString();
                float pervkor = (-b_1 + dis) / (2 * Convert.ToSingle(a));
                float firstkor = (-b_1 - dis) / (2 * Convert.ToSingle(a));
                label7.Text = "3) Теперь, подставив в формулы наши значения найдем эти два корня";
                if (z > 0)
                {
                    pervkor = pervkor / 10;
                    firstkor = firstkor / 10;
                    label1.Text = "Первый корень: " + pervkor.ToString();
                    label3.Text = "Второй корень: " + firstkor.ToString();
                }

                else
                {

                    label1.Text = "Первый корень: " + pervkor.ToString();
                    label3.Text = "Второй корень: " + firstkor.ToString();
                }
            }
            if (discriminant < 0)
            {
                label6.Text = "2) Дискриминант меньше нуля, значит корней не будет.";
                label1.Text = "Нет корней ";
                label3.Text = "";
            }
            if (discriminant == 0)
            {
                float dis = Convert.ToSingle(Math.Sqrt(discriminant));
                label6.Text = "2) Дискриминант равен нулю, значит будет 1 корень. Найдем корень из дискриминанта, в нашем случае он будет " + dis.ToString();
                float pervkor = (-b_1 + dis) / (2 * Convert.ToSingle(a));
                label7.Text = "3) Теперь, подставив в формулу наши значения найдем этот корень";
                if (z > 0)
                {
                    pervkor = pervkor / 10;
                    label1.Text = "Ответ: " + pervkor.ToString();
                    label3.Text = "";
                }
                else
                {
                    label1.Text = "Ответ: " + pervkor.ToString();
                    label3.Text = "";
                }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DiscriminantForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
