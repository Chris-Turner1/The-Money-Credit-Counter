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

        int fiftyPenceCount = 0; // Global code: displays number of fifty pence, once clicked 
        int onePenceCount = 0;   // Global code: dislpays number of pennies, once clicked 
        int twentyPenceCount = 0; // Global code: increments twenty pence, once clicked 
        int totalnumberofpennies = 0; //Global code: increments the coins by the value I set the coin to in pence; in the class

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FiftyPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "") // double equal meaning the value at the side
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                fiftyPenceCount = fiftyPenceCount + 1;
                Fifty_pence_label.Text = fiftyPenceCount.ToString();
                totalnumberofpennies = totalnumberofpennies + 50;

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  
         
            }
            //Fifty pence label.Text = // is value of how many times coin has been clicked
            //cost per credit.Text == means the value is definitely zero 
            //therefore starts at zero in the pence textbox or it can be a blank space 
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
        // this is known as local code 
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

        private void Times_Label_One_Pence_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Ten_Pence_Label_Click(object sender, EventArgs e)
        {

        }

        private void Five_Pence_Label_Click(object sender, EventArgs e)
        {

        }

        private void One_Pence_Label_Click(object sender, EventArgs e)
        {

        }

        private void OnePence_Click(object sender, EventArgs e)
        {

            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                onePenceCount = onePenceCount + 1;
                One_Pence_Label.Text = onePenceCount.ToString();
                totalnumberofpennies = totalnumberofpennies + 1;

                UpdateText(); // it's a function call that updates pounds and pence text 
            }
     


        }

        private void TwoPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
        }

        private void TwentyPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                twentyPenceCount = twentyPenceCount + 1;
                Twnety_Pence_Label.Text = twentyPenceCount.ToString();
                totalnumberofpennies = totalnumberofpennies + 20;

                UpdateText(); // This is the division source code, at the bottom of this class


            }
        }

        private void Pence_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pounds_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostPerCredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfCredits_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Times_Label_Fifty_Pence_Click(object sender, EventArgs e)
        {

        }

        private void Fifty_pence_label_Click(object sender, EventArgs e)
        {

        }

        private void TwoPound_CoinsEntered_Click(object sender, EventArgs e)
        {

        }

        private void UpdateText() // This function is being called to everywhere I place UpdateText to a class, and this is great for the division part; anything corrected in this function will update where I placed this function into.
        {
            Pence.Text = totalnumberofpennies.ToString();

            int numberofpounds = totalnumberofpennies / 100; // This is an integer division so everytime i hit 1 hundred pennies. it's dividing by 1  
            int numberofpennies = totalnumberofpennies % 100; // This is a modulus and this is the remainder of an interger division 

            Pounds.Text = numberofpounds.ToString() + "." + numberofpennies.ToString(); // number of pounds with a decimal point in the middle and then I want number of pennies, concatenating with the +  

        }
    }
}