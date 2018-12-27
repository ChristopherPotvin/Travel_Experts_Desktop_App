using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    //Create class that will validate user input in the form
    public static class Validator
    {
        //test if input date is not in the past
        public static bool IsDate(DateTimePicker dtPicker, Label lblName)
        {
            lblName.Visible = false;
            bool result = true;
            if (DateTime.Now.Date > dtPicker.Value.Date)
            {
                result = false;
                lblName.Visible = true;
                dtPicker.Focus();

            }
            return result;
        }
        //method used in the validations to display user friendly error message in the form
        private static void FormFormat(bool ValidationResult, TextBox txtBoxName, Label lblName)
        {
            if (ValidationResult)
            {
                lblName.Visible = false;
                txtBoxName.BackColor = Color.White;
            }
            else
            {
                lblName.Visible = true;
                txtBoxName.Focus();
                txtBoxName.BackColor = Color.Pink;
            }
            
        }

        //test if input is a valid email address
        public static bool IsEmail(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if (!Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z][a-zA-Z0-9.!#$%&'*+\/=?^_`{-]+@([a-zA-Z][a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a valid phone number
        public static bool IsPhoneNo(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if(!Regex.IsMatch(txtBoxName.Text, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a valid postal code
        public static bool IsPostalCode(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if (!Regex.IsMatch(txtBoxName.Text, @"^([A-Za-z]\d[A-Za-z][- ]?\d[A-Za-z]\d)+$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        // tests if input is not empty (required fields)
        public static bool IsProvided(TextBox txtBoxName, Label lblName)
        {
            bool result = true; //innocent until proven guilty
            if(txtBoxName.Text == "") //empty textbox
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //tests if input is a string
        public static bool IsString(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if(!Regex.IsMatch(txtBoxName.Text,"^[a-zA-Z -'.]+$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a non-negative integer
        public static bool IsNonNegativeInt(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            int num; // parsed number
            if(!Int32.TryParse(txtBoxName.Text, out num)) // if not integer
            {
                result = false;
            }
            else // an int value; check if non-negative
            {
                if(num < 0)
                {
                    result = false;
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a positive integer & not equal to 0
        public static bool IsNonZeroPositiveInt(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            int num; // parsed number
            if (!Int32.TryParse(txtBoxName.Text, out num)) // if not integer
            {
                result = false;
            }
            else // an int value; check if non-negative or equal to 0
            {
                if (num <= 0)
                {
                    result = false;
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a positive double
        public static bool IsNonNegativeDouble(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            double num; // parsed number
            if (!Double.TryParse(txtBoxName.Text, out num)) // if not double
            {
                result = false;
            }
            else // a double value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //test if input is a positive decimal
        public static bool IsNonNegativeDecimal(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            decimal num; // parsed number
            if (!Decimal.TryParse(txtBoxName.Text, out num)) // if not decimal
            {
                result = false;
            }
            else // a decimal value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
    }
}
