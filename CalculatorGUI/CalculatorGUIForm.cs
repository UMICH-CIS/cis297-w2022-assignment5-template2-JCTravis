using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//Jacob Travis
//CIS 297
//4-14-22
namespace CalculatorGUI
{
    //class that manages the calculator function
    
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
        double firstInput;  
        string Operation;  
        public CalculatorForm()  
        {  
            InitializeComponent();  
        }  
  
         //collection of classes that link a textbox to a number as well as operations
        private void firstNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "1";  
            }  
            else  
            {  
                box.Text = box.Text + "1";  
            }  
        }  
  
        private void secondNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "2";  
            }  
            else  
            {  
                boxText = box.Text + "2";  
            }  
        }  
  
        private void thirdNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "3";  
            }  
            else  
            {  
                box.Text = box.Text + "3";  
            }  
        }  
  
        private void fourthNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "4";  
            }  
            else  
            {  
                box.Text = box.Text + "4";  
            }  
        }  
  
        private void fifthNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "5";  
            }  
            else  
            {  
                box.Text = box.Text + "5";  
            }  
        }  
  
        private void sixthNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "6";  
            }  
            else  
            {  
                box.Text = box.Text + "6";  
            }  
        }  
  
        private void seventhNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "7";  
            }  
            else  
            {  
                box.Text = box.Text + "7";  
            }  
        }  
  
        private void eighthNum(object sender, EventArgs e)  
        {  
            if (box.Text == "0" && box.Text != null)  
            {  
                box.Text = "8";  
            }  
            else  
            {  
                box.Text = box.Text + "8";  
            }  
        }  
  
        private void ninthNum(object sender, EventArgs e)  
        {  
            if (box.Text == "" && box.Text != null)  
            {  
                box.Text = "9";  
            }  
            else  
            {  
                box.Text = box.Text + "9";  
            }  
        }  
  
        private void zerothNum(object sender, EventArgs e)  
        {  
            box.Text = box.Text + "0";  
        }  
  
        private void log_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "log";  
        }  
  
        private void power_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "^";  
  
        }  
  
        private void min_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "min";  
        }  
  
        private void max_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "max";  
        }  

        private void squareRoot_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "Sqrt";
        } 

        private void log10_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "log10";  
        } 

        private void reverse_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "reverse";  
        } 

        private void reverse_Click(object sender, EventArgs e)  
        {  
            firstInput = Convert.ToDouble(box.Text);  
            box.Text = "0";  
            Operation = "reverse";  
        } 

        private void quad_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(box.Text);
            box.Text = "0";
            Operation = "Quad";
        }

        private void quotient_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(box.Text);
            box.Text = "0";
            Operation = "/";
        } 
  
        private void decimal_Click(object sender, EventArgs e)  
        {  
            box.Text = box.Text + ".";  
        }  
        //Function actually computes the answer for each operation
        private void operation_Click(object sender, EventArgs e)  
        {  
            double secondInput; 
            double thirdInput
            double result;  
  
            secondInput = Convert.ToDouble(box.Text);  
  
            if (Operation == "log")  
            {  
                result = (Math.log(firstInput, secondInput));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
            }  
            if (Operation == "log10")  
            {  
                result = (Math.Log10(firstInput));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
            }  
            if (Operation == "^")  
            {  
                result = (Math.Pow(firstInput,secondInput));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
            }  
            if (Operation == "min")  
            {  
                
                result = (Math.Min(firstInput / secondInput));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
                 
            }  

            if (Operation == "max")  
            {  
                result = (Math.Max(firstInput,secondInput));  
                box.Text = Convert.ToString(Result);  
                firstInput= Result;  
            }  

            if (Operation == "Sqrt")  
            {  
                result = (Math.sqrt(firstInput));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
            }  

            if (Operation == "/")  
            {  
                result = (Math.DivRem(firstInput, secondInput, out result));  
                box.Text = Convert.ToString(Result);  
                firstInput = Result;  
            } 

            if (Operation == "Quad")  
            {  
                result = ((-secondInput) + System.Math.Sqrt(secondInput * secondInput - 4 * firstInput * thirdInput)) / (2 * firstInput);));  
                box.Text = Convert.ToString(Result);  
                FirstInput = Result;  
            }  
        }


        

      }
   }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/