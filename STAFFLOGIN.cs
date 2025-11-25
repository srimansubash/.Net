using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STUDENT_MARKLIST
{
    public partial class STAFFLOGIN : Form
    {
        public STAFFLOGIN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "SRIMAN") && (textBox2.Text == "SRI"))
            {
                STAFFHOME j = new STAFFHOME();
                j.a = textBox1.Text;

                j.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void STAFFLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
