using Calculator;
using HyattCalculator.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyattCalculator
{
    public partial class CalcApp : Form
    {
        
        Calculate calc = new Calculate();
       
        public int lineCount = 0;
        public bool lastOp = false;

      

        public CalcApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load up the form
            calc.curNum = 0;
            calc.num1 = 0;
            calc.num2 = 0;
            calc.op = " ";
            calc.history = "";
          

            answerBox.Text = Convert.ToString(calc.curNum);
            answerBox.Select(answerBox.Text.Length, 0); //deselect all
          
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                calc.curNum = Convert.ToDouble(answerBox.Text);
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

     

        private void seven_btn_Click(object sender, EventArgs e)
        {

            if(lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "7";
                calc.toBeComputed += "7"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "7";
                calc.toBeComputed += "7"; //build string
            }
            else
            {
                answerBox.Text += 7;
                calc.toBeComputed += "7"; //build string
            }
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {

            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "8";
                calc.toBeComputed += "8"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "8";
                calc.toBeComputed += "8"; //build string
            }
            else
            {
                answerBox.Text += 8;
                calc.toBeComputed += "8"; //build string
            }
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {

            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "9";
                calc.toBeComputed += "9"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "9";
                calc.toBeComputed += "9"; //build string
            }
            else
            {
                answerBox.Text += 9;
                calc.toBeComputed += "9"; //build string
            }
        }

        private void four_btn_Click(object sender, EventArgs e)
        {


            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "1";
                calc.toBeComputed += "1"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "4";
                calc.toBeComputed += "4"; //build string
            }
            else
            {
                answerBox.Text += 4;
                calc.toBeComputed += "4"; //build string
            }
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "5";
                calc.toBeComputed += "5"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "5";
                calc.toBeComputed += "5"; //build string
            }
            else
            {
                answerBox.Text += 5;
                calc.toBeComputed += "5"; //build string
            }
        }

        private void six_btn_Click(object sender, EventArgs e)
        {


            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "6";
                calc.toBeComputed += "6"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "6";
                calc.toBeComputed += "6"; //build string
            }
            else
            {
                answerBox.Text += 6;
                calc.toBeComputed += "6"; //build string
            }
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            if(lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "1";
                calc.toBeComputed += "1"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "1";
                calc.toBeComputed += "1"; //build string
            }
            else
            {
                answerBox.Text += 1;
                calc.toBeComputed += "1"; //build string
            }
        }

        private void two_btn_Click(object sender, EventArgs e)
        {


            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "2";
                calc.toBeComputed += "2"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "2";
                calc.toBeComputed += "2"; //build string
            }
            else
            {
                answerBox.Text += 2;
                calc.toBeComputed += "2"; //build string
            }
        }

        private void three_btn_Click(object sender, EventArgs e)
        {


            if (lastOp == true)
            {
                lastOp = false;
                answerBox.Text = "3";
                calc.toBeComputed += "3"; //build string
            }

            else if (answerBox.Text == "0")
            {
                answerBox.Text = "3";
                calc.toBeComputed += "3"; //build string
            }
            else
            {
                answerBox.Text += 3;
                calc.toBeComputed += "3"; //build string
            }
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {

            lastOp = false;
            if (answerBox.Text != "0")
            {
                answerBox.Text += 0;
                calc.toBeComputed += "0"; //build string
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lastOp = false;
            answerBox.Text = "0";
            calc.curNum = 0;
            calc.toBeComputed = ""; //build string
            calc.history += "(" + lineCount + ". CLEARED\r\n";
        }

        private void period_btn_Click(object sender, EventArgs e)
        {
            
            if (!answerBox.Text.Contains(".") && !calc.toBeComputed.Contains("."))
            {
                answerBox.Text += ".";
                calc.toBeComputed += "."; //build string
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (lastOp == true) //changes the operation if the button clicked before it was another operation
            {
                String str = calc.toBeComputed;
                str = str.Remove(str.Length - 1) ;
                calc.toBeComputed = str; //sets it back to new string with replaced operator
                Console.WriteLine("Replaced Last Op");
            }
            lastOp = true;
            calc.add(calc);
            //answerBox.Text = "";
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            if (lastOp == true) //changes the operation if the button clicked before it was another operation
            {
                String str = calc.toBeComputed;
                str = str.Remove(str.Length - 1);
                calc.toBeComputed = str; //sets it back to new string with replaced operator
                Console.WriteLine("Replaced Last Op");
            }
            lastOp = true;
            calc.subtract(calc);
            //answerBox.Text = "";
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (lastOp == true) //changes the operation if the button clicked before it was another operation
            {
                String str = calc.toBeComputed;
                str = str.Remove(str.Length - 1);
                calc.toBeComputed = str; //sets it back to new string with replaced operator
                Console.WriteLine("Replaced Last Op");
            }
            lastOp = true;
            calc.multiply(calc);
            //answerBox.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (lastOp == true) //changes the operation if the button clicked before it was another operation
            {
                String str = calc.toBeComputed;
                str = str.Remove(str.Length - 1);
                calc.toBeComputed = str; //sets it back to new string with replaced operator
                Console.WriteLine("Replaced Last Op");
            }
            lastOp = true;
            calc.divide(calc);
            //answerBox.Text = "";
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            lastOp = false; //clears any operations 
            lineCount++;//add line count 
            calc.history += "(" + lineCount + ". " + calc.toBeComputed; // add arithmatic lines to history
            
            if (answerBox.Text != "0")
            {
                calc.num2 = Convert.ToDouble(answerBox.Text);
                if (calc.math(calc)!= 3911009001193.246810) { 
                    answerBox.Text = Convert.ToString(calc.math(calc));
                    calc.op = " ";
                }
                else
                {
                    answerBox.Text = "ERROR";
                }
               
            }
            calc.history += "= " + answerBox.Text + "\r\n"; //add answer to history with a new line
            calc.toBeComputed = answerBox.Text;

            

        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            if (answerBox.Text != "0")
            {
                calc.curNum = calc.curNum * -1;
                answerBox.Text = Convert.ToString(calc.curNum);
                calc.toBeComputed += "*-1";
                Console.WriteLine(calc.toBeComputed);
                calc.math(calc);
            }
        }

        private void remainder_Click(object sender, EventArgs e)
        {
            calc.rem(calc);
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            if (calc.history != "")
            {
                History hist = new History();
                Console.WriteLine(calc.history);
                hist.print(calc.history);
                hist.Show();
            }
        }
    }
}
