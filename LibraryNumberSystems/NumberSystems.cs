using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNumberSystems
{
    /// <summary>
    /// This class was designed to represent various numbers in different number systems.
    /// This type can handle only numbers that consist of digits and letters (also separators like "-" and ".")
    /// </summary>
    public class Dynamsys
    {
        private byte _currentNumberSystem;
        private bool _isNegative;
        private byte[] _integralPart;
        private byte[] _fractionalPart;

        /// <summary>
        /// Constructor with 1 required parameter
        /// </summary>
        /// <param name="number">string that represents number</param>
        public Dynamsys(string number)
        {
            if (!IsNumber(number))
                throw new Exception("Cannot create Dynamsys because argument \"number\" contains inappropriate characters.");


        }

        /// <summary>
        /// Determines whether a string can be a Dynamsys number
        /// </summary>
        /// <param name="number">string that represents number</param>
        /// <returns></returns>
        public static bool IsNumber(string number)
        {
            if (number == null)
                throw new NullReferenceException("The number agrument in null.");

            // Checking if number has at least 1 digit
            // return false if not
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9' ||
                    number[i] >= 'a' && number[i] <= 'z' ||
                    number[i] >= 'A' && number[i] <= 'Z')
                    break;

                if (i + 1 == number.Length) return false;
            }

            int idx = 0;
            // Skipping number sign if it is there
            if (number[idx] == '+' || number[idx] == '-')
                idx++;

            // Check for integral part
            while(idx < number.Length)
            {
                if (number[idx] == '.')
                {
                    idx++;
                    break;
                }

                if (!(number[idx] >= '0' && number[idx] <= '9' ||
                    number[idx] >= 'a' && number[idx] <= 'z' ||
                    number[idx] >= 'A' && number[idx] <= 'Z'))
                    return false;

                idx++;
            }

            // Check for fractional part
            while (idx < number.Length)
            {
                if (!(number[idx] >= '0' && number[idx] <= '9' ||
                    number[idx] >= 'a' && number[idx] <= 'z' ||
                    number[idx] >= 'A' && number[idx] <= 'Z'))
                    return false;

                idx++;
            }

            return true;
        }

        //public static int SizeOfIntegralPart(string number)
        //{
        //    int i = 0;
        //    for (i = 0; number[i] != '.' && i < number.Length; i++)
        //    {

        //    }
        //}

        //public static int SizeOfFractionalPart(string number)
        //{

        //}
    }

    /// <summary>
    /// Number systems class
    /// Allows to convert numbers from one number system to another
    /// </summary>
    public static class NumberSystems
    {
        private const string _digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        #region NEW

        /// <summary>
        /// Converts string-number from any system to decimal
        /// </summary>
        /// <param name="str">string-number</param>
        /// <param name="fromSystem">from number system</param>
        /// <returns>string-number in decimal number system</returns>
        public static string ToDecimalSystem(string str, double fromSystem) // Only for whole numbers
        {
            double num = 0;
            int i = 0;

            int power = 0;
            for (i = str.Length - 1; i >= 0; i--)
            {
                if(str[i] >= '0' && str[i] <= '9')
                {
                    num += (str[i] - '0') * Math.Pow(fromSystem, power);
                    power++;
                }
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    num += (str[i] - 55) * Math.Pow(fromSystem, power);
                    power++;
                }
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    num += (str[i] - 87) * Math.Pow(fromSystem, power);
                    power++;
                }
            }

            return num.ToString();
        }
        /// <summary>
        /// Converts string-number from decimal number system to any other
        /// </summary>
        /// <param name="str">string-number</param>
        /// <param name="toSystem">to system</param>
        /// <returns>string-number</returns>
        public static string ToCustomSystem(string str, double toSystem)
        {
            double num;
            double.TryParse(str, out num);

            int integral = (int)Math.Truncate(num);
            double fraction = num - integral;

            string result = "";

            while (integral > 0) // Whole part
            {
                if(integral % (int)toSystem < 10)
                {
                    result = (integral % (int)toSystem).ToString() + result;
                }
                else
                {
                    result = (char)(integral % (int)toSystem + 55) + result;
                }
                integral = integral / (int)toSystem;
            }

            // Fraction part
            if (fraction != 0) result += ",";
            fraction = (fraction - Math.Truncate(fraction)) * toSystem;
            for (int i = 0; i < 13 && (fraction - Math.Truncate(fraction) != 0); i++)
            {
                if(Math.Truncate(fraction) < 10)
                {
                    result = result + Math.Truncate(fraction);
                }
                else
                {
                    result += (char)(Math.Truncate(fraction) + 55);
                }
                fraction = (fraction - Math.Truncate(fraction)) * toSystem;
            }

            return result;
        }

        #endregion

        public static int QuantityOfDigits(double num) => (int)Math.Log10(num) + 1;
    }
}
