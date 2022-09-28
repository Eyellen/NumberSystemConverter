using System;
using System.Text.RegularExpressions;

namespace LibraryNumberSystems
{
    /// <summary>
    /// This class was designed to represent various numbers in different number systems.
    /// This type can handle only numbers that consist of digits and letters (also signs "+" and "-" and separator ".").
    /// </summary>
    public class Dynamsys
    {
        // Set of symbols the Dynamsys can consist of.
        private static string _charactersSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private byte _currentNumberSystem;
        private bool _isNegative;
        private byte[] _integralPart;
        private byte[] _fractionalPart;

        /// <summary>
        /// Constructor with 1 required parameter
        /// </summary>
        /// <param name="number">string that represents number</param>
        public Dynamsys(string number, byte numberSystem)
        {
            if (!IsNumber(number))
                throw new Exception("Cannot create Dynamsys because argument \"number\" contains inappropriate characters.");

            foreach (char character in number)
            {
                if (_charactersSet.IndexOf(character) >= numberSystem)
                    throw new Exception("The number argument can't contain numbers bigger than number system.");
            }

            _currentNumberSystem = numberSystem;
            _isNegative = number[0] == '-';
            _integralPart = ToArray(GetIntegralPart(number));
            _fractionalPart = ToArray(GetFractionalPart(number));
        }

        /// <summary>
        /// Determines whether a string can be a Dynamsys number
        /// </summary>
        /// <param name="number">string that represents number</param>
        /// <returns></returns>
        public static bool IsNumber(string number)
        {
            if (number == null)
                throw new NullReferenceException("The number agrument is null.");

            if (number.Equals(string.Empty))
                throw new Exception("The number argument doesn't contain any character.");

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
            while (idx < number.Length)
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

        public static string GetIntegralPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            // Remove number sign if it has one
            if (number[0] == '+' || number[0] == '-')
                number = number.Substring(1);

            int separatorPosition = number.IndexOf('.');

            if (separatorPosition <= -1)
                return number;

            return number.Substring(0, separatorPosition);
        }

        public static string GetFractionalPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            int separatorPosition = number.IndexOf('.');

            if (separatorPosition <= -1)
                return string.Empty;

            return number.Substring(separatorPosition + 1);
        }

        /// <summary>
        /// Converts string number to array of corresponding values.
        /// </summary>
        /// <param name="number">String that contains only characters from characters set.</param>
        /// <returns></returns>
        public static byte[] ToArray(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            Regex regex = new Regex(@"[1-9_A-Z]+", RegexOptions.IgnoreCase);
            if (!regex.IsMatch(number))
                throw new Exception("The number have to consisnt only of characters from characters set. " +
                    "i.e. it has to be either integral part or fractional part.");

            number = number.ToUpper();

            byte[] arr = new byte[number.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int code = _charactersSet.IndexOf(number[i]);

                if (code <= -1)
                    throw new Exception("The number argument contains inappropriate character(s).");

                arr[i] = (byte)code;
            }

            return arr;
        }
    }
}
