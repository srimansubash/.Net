using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marklist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text));
            textBox6.Text = Convert.ToString(int.Parse(textBox5.Text) /4);

            if (int.Parse(textBox6.Text) >= 90 && int.Parse(textBox6.Text) <= 100)
            {
                richTextBox1.Text = "Excellent";
            }
            if (int.Parse(textBox6.Text) >=81 && int.Parse(textBox6.Text) <=90)
            {
                richTextBox1.Text = "Very Good";
            }
            if (int.Parse(textBox6.Text) >= 71 && int.Parse(textBox6.Text) <= 80)
            {
                richTextBox1.Text = "Good";
            }
            if (int.Parse(textBox6.Text) >= 61 && int.Parse(textBox6.Text) <= 70)
            {
                richTextBox1.Text = "Good Mark";
            }
            if (int.Parse(textBox6.Text) >= 51 && int.Parse(textBox6.Text) <= 60)
            {
                richTextBox1.Text = "Perfect";
            }
            if (int.Parse(textBox6.Text) >= 41 && int.Parse(textBox6.Text) <= 50)
            {
                richTextBox1.Text = "Need improvement";
            }
            if (int.Parse(textBox6.Text) >= 35 && int.Parse(textBox6.Text) <= 40)
            {
                richTextBox1.Text = "Try to improve";
            }
            if (int.Parse(textBox6.Text) >= 0 && int.Parse(textBox6.Text) <= 34)
            {
                richTextBox1.Text = "Fail";
            }
            if (int.Parse(textBox1.Text) < 34)
            {
                richTextBox1.Text = "Fail in java";
            }
            if (int.Parse(textBox2.Text) < 34)
            {
                richTextBox1.Text = "Fail in dt";
            }
            if (int.Parse(textBox3.Text) < 34)
            {
                richTextBox1.Text = "Fail in lamp";
            }
            if (int.Parse(textBox4.Text) < 34)
            {
                richTextBox1.Text = "Fail in Soft Skills";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
