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
    public partial class Studentlogin : Form
    {
        public Studentlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BLACKHOLE" && textBox2.Text == "MEGASTRUCTURE")
            {
                MessageBox.Show("Sucessfully logged in");
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Studentlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
