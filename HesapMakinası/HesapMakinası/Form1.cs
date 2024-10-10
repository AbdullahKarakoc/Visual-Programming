using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {

        string user_name = "jose";
        int password = 1234;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == textBox1.Text && password == Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Congrultions!!! Username and Password are True....",
                    "Sign In Panel",MessageBoxButtons.OK);

                Form1 frm1 = new Form1();
                this.Hide();

                Form2 form = new Form2();
                form.Show();
            }

            else if (user_name != textBox1.Text && password == Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Username is wrong!!! Please try again....",
                    "Sign In Panel", MessageBoxButtons.OK);
                counter++;
            }

            else if (user_name == textBox1.Text && password != Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Password is wrong!!! Please try again....",
                    "Sign In Panel", MessageBoxButtons.OK);
                counter++;
            }

            else
            {
                MessageBox.Show("Username and Password are wrong!!! Please try again....",
                    "Sign In Panel", MessageBoxButtons.OK);
                counter++;
            }


        }
    }
}
