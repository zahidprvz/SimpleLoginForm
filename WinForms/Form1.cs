using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "WinForm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "Name: " + textBox1.Text + System.Environment.NewLine + "Email: " + textBox2.Text + System.Environment.NewLine + "Address: " + textBox3.Text; 
        }
    }
}
