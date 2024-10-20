using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox3.BackColor = color.Color;
            color.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 20;
            listBox1.Items.Add("Your Name: " + textBox1.Text);
            listBox1.Items.Add("Your Surname: " + textBox2.Text);

            listBox1.Items.Add("Your Age: " + (DateTime.Now.Year - dateTimePicker1.Value.Year));
            listBox1.Items.Add("Your Cuntry: " + comboBox1.Text);
            if (radioButton1.Checked) listBox1.Items.Add("Your gender: " + radioButton1.Text); else listBox1.Items.Add("Your gender: " + radioButton2.Text);
            if (checkBox1.Checked) listBox1.Items.Add("Your  position: " + checkBox1.Text); else listBox1.Items.Add("Your position: " + checkBox2.Text);
            progressBar1.Value = 100;
            tabControl1.Refresh();
        }
    }

}
