using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        double r;
        const double pi = 3.14159;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            result = pi * r * r;
            label1.Text = "Area of the circle is " + result.ToString();
            label2.Text = "r="+ r.ToString();
            MessageBox.Show("Area of the circle is " + result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            result = 2 * pi * r;
            label1.Text = "Perimeter of the circle is " + result.ToString();
            label2.Text = "r="+ r.ToString();

            MessageBox.Show("Perimeter of the circle is " + result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
