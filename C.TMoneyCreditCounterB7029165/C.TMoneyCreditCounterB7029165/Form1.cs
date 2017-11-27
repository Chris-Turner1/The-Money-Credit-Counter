using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.TMoneyCreditCounterB7029165
{
    public partial class Form1 : Form
    {

        int fiftyPenceCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(CostPerCredit.Text=="0" || CostPerCredit.Text=="")
            {
                MessageBox.Show("You have not set the cost per credit");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FiftyPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                fiftyPenceCount = fiftyPenceCount + 1;
                Fifty_pence_label.Text = fiftyPenceCount.ToString();
            }
            //Fifty pence label.Text = //value of how many times it's been clicked
        }

        private void TwoPound_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void FivePence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void TenPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void OnePound_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
