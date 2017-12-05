﻿using System;
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
        //Global code: variables outside of the class will effect the classes you place the function into 
        int costpercredit = 0; // Starts "0" value in cost per credit 
        int fiftyPenceCount = 0; // Starts "0" value in fifty pence count 
        int onePenceCount = 0; // Starts "0" value in one pence count
        int twentyPenceCount = 0; // Starts "0" value in twenty pence count
        int totalnumberofpennies = 0; //Starts "0" value in total number of pennies
        int twopencecount = 0; //Starts "0" value in two pence count 
        int fivePenceCount = 0; //Starts "0" value in five pence count 
        int OnePoundPenceCount = 0; //Starts "0" value in one pound count 
        int TenPenceCount = 0; //Starts "0" value in ten pence count 
        int TwoPoundPenceCount = 0; //Starts "0" value in Two pound pence count

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
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "") // Double equal operator: meaning it will compare "0" with whichever value I place into the text and replace it with that. By default it will remain at "0". 
                                                                       //Double quote means waiting for any value to be placed inside it; so it can be blank 
            {
                MessageBox.Show("You have not set the cost per credit"); // displays a safety net message that I havent entered a value yet for the application to work with. 
            }
            else
            {
                fiftyPenceCount = fiftyPenceCount + 1; // increments the total number of fifty pences. I have clicked 
                Fifty_pence_label.Text = fiftyPenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 50; // how much I want to increment my 50pence by each time I have clicked on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  
         
            }
            //Fifty pence label.Text = // is value of how many times coin has been clicked
            //cost per credit.Text == the operator means the value is zero as well as it can change with another value; it compares basically and this is where the OR statment is used. 0 OR the value I type.
            //therefore starts at zero in the pence textbox or it can be a blank space 
        }

        private void TwoPound_Click(object sender, EventArgs e) // the object I can click 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "") // "if" statement used with "OR operator". So if values is inputted instead of "0" by default then display the value entered rather than the default of "0"
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                TwoPoundPenceCount = TwoPoundPenceCount + 1; // Increments the total number of two pounds, I have clicked 
                Two_Pound_Label.Text = TwoPoundPenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 200; // = operator to assign how much I want to increment my two pound by, each time I have clicked on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void FivePence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                fivePenceCount = fivePenceCount + 1; // Increments the total number of 5 pences, I have clicked 
                Five_Pence_Label.Text = fivePenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 5; // "=" operator to assign how much I want to increment my 5pence by each time I have click on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }
        // this is known as local code because it is in the class and not outside in public 
        private void TenPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                TenPenceCount = TenPenceCount + 1; // increments the total number of 10 pences, I have clicked 
                Ten_Pence_Label.Text = TenPenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 10; // = operator to assign how much I want to increment my 10 pence by, each time I have click on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void OnePound_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                OnePoundPenceCount = OnePoundPenceCount + 1; // increments the total number of  one pounds, I have clicked 
                One_Pound_Label.Text = OnePoundPenceCount.ToString(); // Tostring() allows me to display the content from my function 
                totalnumberofpennies = totalnumberofpennies + 100; // = operator to assign how much I want to increment my one pound by each time I have click on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

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
                onePenceCount = onePenceCount + 1; // Displays the number of pennies I have clicked on by 1. 
                One_Pence_Label.Text = onePenceCount.ToString(); // Tostring: displays number into text 
                totalnumberofpennies = totalnumberofpennies + 1; // Increments penny value by 1 eveytime it is clicked

                UpdateText(); // it's a function call that updates pounds and pence text 
            }
     


        }

        private void TwoPence_Click(object sender, EventArgs e)
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                twopencecount = twopencecount + 1; // increments the total number of fifty pences. I have clicked 
                Two_Pence_Label.Text = twopencecount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 2; // = operator to assign how much I want to increment my 2pence by each time I have click on it

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void TwentyPence_Click(object sender, EventArgs e) // object I "click on"
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                twentyPenceCount = twentyPenceCount + 1; // Displays the number of pennies I have clicked on by 1.
                Twnety_Pence_Label.Text = twentyPenceCount.ToString(); // shows as text 
                totalnumberofpennies = totalnumberofpennies + 20; //increments the value of the coin by 20pence everytime it is clicked

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
           if(CostPerCredit.Text != "") // if cost per credit is emppty it will do nothing. This is just a safety net   
                costpercredit = Convert.ToInt32(CostPerCredit.Text); // new cost per credit will update in number of credis by the value I place into it
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
            Pence.Text = totalnumberofpennies.ToString(); // tells coins to increment in textbox 
            

            int numberofpounds = totalnumberofpennies / 100; // This is an integer division so everytime i hit 1 hundred pennies. it's dividing by 1  
            int numberofpennies = totalnumberofpennies % 100; // This is a modulus and this is the remainder of an interger division 
            
            Pounds.Text = numberofpounds.ToString() + "." + numberofpennies.ToString(); // number of pounds with a decimal point in the middle and then I want number of pennies, concatenating with the +  

            NumberOfCredits.Text = (totalnumberofpennies / costpercredit).ToString(); // dividing the total number of pennies by the cost and converting that to a string so it shows. 

            // for example: 45p (number of credits) noc=8
            // 45 / 8 = 5 (5p left over)
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            costpercredit = 0; // Display "0" value in cost per credit 
            fiftyPenceCount = 0; // Displays "0" value on number of fifty pence 
            onePenceCount = 0; // Displays "0" value in number of pennies   
            twentyPenceCount = 0; // Displays "0" of twnety pence count 
            totalnumberofpennies = 0; // Display "0" value in total number of pennies 
            twopencecount = 0; // Display "0" value of two pence count
            fivePenceCount = 0; // Display "0" value of five pence count 
            OnePoundPenceCount = 0; // Display "0" value one pound pence count 
            TenPenceCount = 0; // Display "0" value ten pence count 
            TwoPoundPenceCount = 0; // Display "0" value two pound pence count 

            Pence.Text = "0"; // Resets pence textbox to "0"
            Pounds.Text = "0"; // Resets pounds textbox to "0"
            NumberOfCredits.Text = "0"; // Resets numberOfCredits text to "0"
            CostPerCredit.Text = "0"; // Resets CostPerCredit to "0" 
            One_Pence_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Two_Pence_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Five_Pence_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Ten_Pence_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Twnety_Pence_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Fifty_pence_label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            One_Pound_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button
            Two_Pound_Label.Text = "0"; // Telling the label to reset itself to "0" once I clicked reset button



            // the above allows me to reset the the variabls in the text to "0" if I choose to. 
        }
    }
}