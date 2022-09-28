using System;

namespace LibraryNumberSystems
{
    /// <summary>
    /// This class was designed to represent various numbers in different number systems.
    /// This type can handle only numbers that consist of digits and letters (also signs "+" and "-" and separator ".").
    /// </summary>
    public class Dynamsys
    {
        // Set of symbols the Dynamsys can consist of.
        private static string _numbersSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

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

            _integralPart = new byte[SizeOfIntegralPart(number)];
            _fractionalPart = new byte[SizeOfFractionalPart(number)];
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

        public static int SizeOfIntegralPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            int i = 0;
            // The second condition will be checked only if first condition is true
            while (i < number.Length && number[i] != '.')
                i++;

            if (number[0] == '+' || number[0] == '-')
                return i - 1;

            return i;
        }

        public static int SizeOfFractionalPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            int separatorPosition = number.IndexOf('.');

            if (separatorPosition <= -1)
                return 0;

            return number.Length - separatorPosition - 1;
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
    }
}
