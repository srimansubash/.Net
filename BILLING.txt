
CODE:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Billing
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = PNAME.Text;
            string productAmount = PAMOUNT.Text;
            string quantity = QUANT.Text;
            string totalAmount = TAMOUNT.Text;
            string customerName = CUSNAME.Text;
            string customerPhone = CUSPH.Text;
            string customerAddress = CUSADD.Text;

            a1.Text = productName;
            a2.Text = productAmount;
            a3.Text = quantity;
            a4.Text = totalAmount;
            a5.Text = customerName;
            a6.Text = customerPhone;
            a8.Text = customerAddress;

            string selectedGender = GetSelectedGender();
            a7.Text = a7.Text = "Gender: " + selectedGender;
        }

        private string GetSelectedGender()
        {
            if (CGENDER.Checked)
                return "Male";
            else if (CGENDERS.Checked)
                return "Female";
            else if (CGENDER_OTHERS.Checked)
                return "Others";
            else
                return "Unknown";
        }

        private void PAMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CUSPH.MaskFull)
            {
                MessageBox.Show("no is correct");
            }
            else
            {
                MessageBox.Show("Type correct format");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(QUANT.Text);
            int unitPrice = int.Parse(PAMOUNT.Text);
            TAMOUNT.Text = Convert.ToString(quantity * unitPrice);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
