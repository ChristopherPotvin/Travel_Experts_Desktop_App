using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    //This code validates data input into a Form Textbox.
    //Author: 
    //Date: 6th February 2019

    public static class Validator1
    {
        // tests if a textbox is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if(tb.Text == "")//empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }

        public static bool IsProvided(RichTextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text == "")//empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        //test if input is non-negative integer
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int num; //parse number
            if(!Int32.TryParse(tb.Text, out num)) //if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number, between 0 and 2147483647", "Data entry error");
                tb.SelectAll(); //select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); //select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }

        //test if input is non-negative double
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num; //parse number
            if (!Double.TryParse(tb.Text, out num)) //if not double
            {
                result = false;
                MessageBox.Show(name + " has to be an a flooating", "Data entry error");
                tb.SelectAll(); //select all text to facilitate change
                tb.Focus();
            }
            else // a double value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); //select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }

        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;
            decimal num; //parse number
            if (!Decimal.TryParse(tb.Text, out num)) //if not decimal
            {
                result = false;
                MessageBox.Show(name + " has to be an a flooating", "Data entry error");
                tb.SelectAll(); //select all text to facilitate change
                tb.Focus();
            }
            else // a decimal value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); //select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }

    }
}

