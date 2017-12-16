using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyMaker.Helpers
{
    /// <summary>
    /// Helper Methods
    /// </summary>
    public static class MoneyMakerHelper
    {
        public static string getHash(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            byte[] hash;
            SHA512 shaM = new SHA512Managed();
            hash = shaM.ComputeHash(data);

            return Convert.ToBase64String(hash);
        }

        public static void textboxCheckLetter(ref object sender, ref KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar));
        }

        public static void textboxCheckDigital(ref object sender, ref KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','));
          
            

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        public static bool isPasswordStrength(string password)
        {
            bool isStrength = false;

            string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!#$%&'(){}*+~,-./:;<=>?!@[\]_]).{8,12}$";

            Regex r = new Regex(pattern);

            if (r.IsMatch(password) == false)
            {
                isStrength = false;
            }
            else
            {
                isStrength = true;
            }

            return isStrength;
        }             
    }    
}