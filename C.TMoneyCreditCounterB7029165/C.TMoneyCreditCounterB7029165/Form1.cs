using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.TMoneyCreditCounterB7029165 // this the name I gave to my project with all my source code inside it
{
    public partial class Form1 : Form // is a class called form and inside the scope is the code. Everthing in C# is known as a class inside it, and inside the classes are all the different methods being used for the application. 
    {
        //Global code: variables in a public class which are outside of the private class will effect the classes you place the function into 
        int costpercredit = 0; // Starts at "0" value in `cost per credit` 
        int fiftyPenceCount = 0; // Starts at "0" value in fifty pence count 
        int onePenceCount = 0; // Starts at "0" value in one pence count
        int twentyPenceCount = 0; // Starts at "0" value in twenty pence count
        int totalnumberofpennies = 0; //Starts at "0" value in total number of pennies
        int twopencecount = 0; //Starts at "0" value in two pence count 
        int fivePenceCount = 0; //Starts at "0" value in five pence count 
        int OnePoundPenceCount = 0; //Starts at "0" value in one pound count 
        int TenPenceCount = 0; //Starts at "0" value in ten pence count 
        int TwoPoundPenceCount = 0; //Starts at "0" value in Two pound pence count
         // Local and Global variables, (November 21st). C# for beginners. 
        // Retrieved from: http://nachocsharp.blogspot.co.uk/2013/01/55-local-and-global-variables.html
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

        private void FiftyPence_Click(object sender, EventArgs e) // private void is known as local code, so functions inside this scope can not effect anything outside of this class.   
                                                                  //FiftyPence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
                                                                  //Difference between a method and a function (December: 13/12/17). Stack Overflow. Retrieved form: https://stackoverflow.com/questions/12258964/difference-between-method-and-function
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")  // Double quote means waiting for any value to be placed inside it by the user; so it can be a blank string. Whilst a value in the double quotes just means that the string in the text box is already set to this value 
                                                                        // What’s the difference between double quotes and single quote (November 21st, 2017) Stack Overflow. Retrieved from:  https://stackoverflow.com/questions/602033/whats-the-difference-between-double-quotes-and-single-quote-in-c-sharp
                                                                        // Double equal operator: meaning it will compare "0" with whichever value I place into the text and replace it with that. By default, it will remain at "0". 
                                                                        // When should I use == and when should I use Equals? (November 27th, 2017) C# Frequently Asked Questions. Retrieved from: https://blogs.msdn.microsoft.com/csharpfaq/2004/03/29/when-should-i-use-and-when-should-i-use-equals/
                                                                        // Hints and tips for "If" & "else" statement from Peter O'Neill's Lecture 6 
                                                                        // `If-else statment` checks if a boolean type is true or not by checking to see which condition is met within the scope
                                                                        // Hints and tips from Peter O'Niell's lecture 6 "if, switch case decisions (show)"
            {
                MessageBox.Show("You have not set the cost per credit"); // Displays a safety net message for when I haven't entered a value yet for the objects in the application to work with. 
            }   // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                fiftyPenceCount = fiftyPenceCount + 1; // Increments the total number of fifty pences I have clicked by 1  
                Fifty_pence_label.Text = fiftyPenceCount.ToString(); // Tostring() allows me to display the content in my function to textbox 
                totalnumberofpennies = totalnumberofpennies + 50; // // "=" operator to assign how much I want to increment my 50pence by using "+" operator each time I have clicked the object

                UpdateText(); // This eliminates the need to copy and paste the same code. The division part I used in `Update text`.  
                              // EditCommandColumn.UpdateText Property (December: 15/12/17) Microsoft Developer Network. Retrieved from:  https://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.editcommandcolumn.updatetext(v=vs.110).aspx

            }
            //Fifty pence label.Text = displays value of how many times the coin has been clicked
            //cost per credit.Text == the operator means the value is zero as well as it can change with another value; it compares basically and this is where the OR statment is used. 0 OR the value I type.
            //therefore starts at zero in the pence textbox or it can be a blank space 
        }

        private void TwoPound_Click(object sender, EventArgs e) // // TwoPound_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "") // "if" statement used with "OR operator". So if values are inputted instead of "0" by default then display the value entered rather than the default of "0"
            { // Logical OR Operator: || (December, 2017) Microsoft Developer Network. Retrieved from: https://msdn.microsoft.com/en-us/library/f355wky8.aspx 
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                TwoPoundPenceCount = TwoPoundPenceCount + 1; // Increments the total number of two pounds in "coins entered group box" by one, once I have clicked the object in coins group box.
                Two_Pound_Label.Text = TwoPoundPenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 200; // "=" operator to assign how much I want to increment my TwoPound by using "+" operator each time I have clicked the object

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void FivePence_Click(object sender, EventArgs e) // FivePence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit"); // Message box will show if no value is inputted into "cost per credit"
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                fivePenceCount = fivePenceCount + 1; // Increments the total number of 5 pences, I have clicked 
                Five_Pence_Label.Text = fivePenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 5; // "=" operator to assign how much I want to increment my5pence by using "+" operator each time I have clicked the object

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  
              // The source code in here is known as local code because it is in the class and not outside in public so will only take effect inside this class and nowhere else 
            }
        }
        
        private void TenPence_Click(object sender, EventArgs e) // TenPence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                TenPenceCount = TenPenceCount + 1; // increments the total number of 10 pences, I have clicked 
                Ten_Pence_Label.Text = TenPenceCount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 10; // "=" operator to assign how much I want to increment my 10pence by using "+" operator each time I have clicked the object

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void OnePound_Click(object sender, EventArgs e) // OnePound_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                OnePoundPenceCount = OnePoundPenceCount + 1; // increments the total number of  one pounds, I have clicked 
                One_Pound_Label.Text = OnePoundPenceCount.ToString(); // Tostring() allows me to display the content from my function 
                totalnumberofpennies = totalnumberofpennies + 100; // "=" operator to assign how much I want to increment my OnePound by using "+" operator each time I have clicked the object

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

        private void OnePence_Click(object sender, EventArgs e) // OnePence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {

            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                onePenceCount = onePenceCount + 1; // Displays the number of pennies I have clicked on by 1. 
                One_Pence_Label.Text = onePenceCount.ToString(); // Tostring: displays number into text 
                totalnumberofpennies = totalnumberofpennies + 1; // "=" operator to assign how much I want to increment my 1pence by using "+" operator each time I have clicked the object

                UpdateText(); // it's a function call that updates pounds and pence text 
            }
     


        }

        private void TwoPence_Click(object sender, EventArgs e) // TwoPence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                twopencecount = twopencecount + 1; // increments the total number of fifty pences. I have clicked 
                Two_Pence_Label.Text = twopencecount.ToString(); // Tostring() allows me to display the content in my function 
                totalnumberofpennies = totalnumberofpennies + 2; // "=" operator to assign how much I want to increment my 2pence by using "+" operator each time I have clicked the object

                UpdateText(); // this eliminates the need to copy and paste the same code. The division part.  

            }
        }

        private void TwentyPence_Click(object sender, EventArgs e) // // TwnetyPence_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
        {
            if (CostPerCredit.Text == "0" || CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not set the cost per credit");
            } // Hints and tips from Peter O'Neill's Assignment 1; to show text in Messagebox 
            else
            {
                twentyPenceCount = twentyPenceCount + 1; // Displays the number of pennies I have clicked on by 1.
                Twnety_Pence_Label.Text = twentyPenceCount.ToString(); // Tostring() allows me to display the content in my function
                totalnumberofpennies = totalnumberofpennies + 20; // "=" operator to assign how much I want to increment my 20pence by using "+" operator each time I have clicked the object

                UpdateText(); // This is the division source code, at the bottom of this class


            }
        }

        private void Pence_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pounds_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostPerCredit_TextChanged(object sender, EventArgs e) // CosterPerCredit_TextChange is the name of the method which is an object textbox and inside the scope is the source code of the method; can also be known as a function. 
        {
           if(CostPerCredit.Text != "") // if cost per credit is emppty it will do nothing. This is just a safety net   
                costpercredit = Convert.ToInt32(CostPerCredit.Text); // new cost per credit will update in "number of credis" by the value I place into it
        } // How to convert string to integer in C# (December 2nd, 2017) Stack Overflow. Retrieved from: https://stackoverflow.com/questions/2344411/how-to-convert-string-to-integer-in-c-sharp

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
        { // Update text from a different class (December 3rd, 2017) Stack Overflow. Retrieved from: https://stackoverflow.com/questions/26810056/update-textbox-from-a-different-class
            Pence.Text = totalnumberofpennies.ToString(); // tells coins to increment in textbox 

            Pounds.Text = string.Format("{0:n2}", Convert.ToDouble(Pence.Text)); // Gives extra decimal point at end of values in pounds and pence text box
            // Hints and tips from Peter O'Neill's Assignment 1   
            int numberofpounds = totalnumberofpennies / 100; // This is an integer division so everytime I hit 1 hundred pennies. It's dividing by 1  
            int numberofpennies = totalnumberofpennies % 100; // This is a modulus operator and this is the remainder of an interger division 
            // % Operator (C# Reference) December 1, 2017. Microsoft. Net. Retrieved from: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/modulus-operator


            NumberOfCredits.Text = (totalnumberofpennies / costpercredit).ToString(); // dividing the total number of pennies by the cost and converting that to a string so it shows in text box. 

            // for example: 45p (number of credits) noc=8
            // 45 / 8 = 5 (5p left over)  
        }

        private void ResetButton_Click(object sender, EventArgs e) // ResetButton_click is the name of the method which is an object that I can click and inside the scope is the source code of the method; can also be known as a function. 
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



          // The above source code in this scope allows me to reset the variabls in the text to "0" if I choose to. 
        }
    }
}