﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace NumberSystems
{
    /// <summary>
    /// Class that represents number and allows to convert numbers to different number systems.
    /// Also this class allows to use basic operators and math operations.
    /// The number can consist only of characters from characters set, positive/negative signs and decimal separators.
    /// </summary>
    public class Dynamsys
    {
        private static NumberFormatInfo _nfi = NumberFormatInfo.CurrentInfo;

        // Set of symbols the Dynamsys can consist of.
        private static string _charactersSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string _pattern = null;
        private static string Pattern
        {
            get
            {
                if (_pattern != null && _pattern != string.Empty)
                    return _pattern;

                _pattern = @"^[";
                _pattern += Regex.Escape(_nfi.PositiveSign + _nfi.NegativeSign) + @"]?([0-9_A-Z]*";
                _pattern += Regex.Escape(_nfi.NumberDecimalSeparator) + @"?[0-9_A-Z]+){1}$";

                return _pattern;
            }
        }

        private byte _currentNumberSystem;
        private bool _isNegative;
        private byte[] _integralPart;
        private byte[] _fractionalPart;

        /// <summary>
        /// </summary>
        /// <param name="number">String that represents number. Can't contain values equal or bigger than numberSystem.</param>
        /// <param name="numberSystem"></param>
        public Dynamsys(string number, byte numberSystem)
        {
            number = number.ToUpper();

            if (!IsNumber(number))
                throw new Exception("Cannot create Dynamsys because argument \"number\" contains inappropriate characters.");

            foreach (char character in number)
            {
                if (_charactersSet.IndexOf(character) >= numberSystem)
                    throw new Exception("The number argument can't contain numbers bigger than number system.");
            }

            _currentNumberSystem = numberSystem;
            _isNegative = number.Contains(_nfi.NegativeSign);

            string integralPart = GetIntegralPart(number);
            integralPart = RemoveExtraFrontZeros(integralPart);
            if (!integralPart.Equals(string.Empty))
                _integralPart = ToArray(integralPart);
            else
                _integralPart = Array.Empty<byte>();

            string fractionalPart = GetFractionalPart(number);
            fractionalPart = RemoveExtraRearZeros(fractionalPart);
            if (!fractionalPart.Equals(string.Empty))
                _fractionalPart = ToArray(fractionalPart);
            else
                _fractionalPart = Array.Empty<byte>();
        }

        public Dynamsys(Dynamsys other)
        {
            this._currentNumberSystem = other._currentNumberSystem;
            this._isNegative = other._isNegative;
            this._integralPart = new byte[other._integralPart.Length];
            this._fractionalPart = new byte[other._fractionalPart.Length];
            Array.Copy(other._integralPart, this._integralPart, other._integralPart.Length);
            Array.Copy(other._fractionalPart, this._fractionalPart, other._fractionalPart.Length);
        }

        /// <summary>
        /// Determines whether a string can be a Dynamsys number 
        /// according to characters set.
        /// </summary>
        /// <param name="number">String that represents number.</param>
        /// <returns>True if number can be a Dynamsys, otherwise False.</returns>
        public static bool IsNumber(string number)
        {
            if (number == null)
                throw new NullReferenceException("The number agrument is null.");

            if (number.Equals(string.Empty))
                throw new Exception("The number argument doesn't contain any character.");

            Regex regex = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return regex.IsMatch(number);
        }

        public static string GetIntegralPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            // Remove number sign if it has one
            if (number.Contains(_nfi.PositiveSign) || number.Contains(_nfi.NegativeSign))
                number = number.Substring(1);

            int separatorPosition = number.IndexOf(_nfi.NumberDecimalSeparator);

            if (separatorPosition <= -1)
                return number;

            return number.Substring(0, separatorPosition);
        }

        public static string GetFractionalPart(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            int separatorPosition = number.IndexOf(_nfi.NumberDecimalSeparator);

            if (separatorPosition <= -1)
                return string.Empty;

            return number.Substring(separatorPosition + 1);
        }

        public static string RemoveExtraFrontZeros(string number)
        {
            int i = 0;
            while (i < number.Length && number[i] == '0')
                i++;

            return number.Substring(i);
        }

        public static string RemoveExtraRearZeros(string number)
        {
            int i = number.Length - 1;
            while (i >= 0 && number[i] == '0')
                i--;

            return number.Substring(0, i + 1);
        }

        /// <summary>
        /// Converts sequence of characters from characters set to array type of byte
        /// with values corresponding to indexes of characters in characters set.
        /// </summary>
        /// <param name="number">String that contains only characters from characters set.</param>
        /// <returns>Array of values corresponding to indexes of characters in characters set.</returns>
        public static byte[] ToArray(string number)
        {
            if (!IsNumber(number))
                throw new Exception($"The number argument contains not suitable for {nameof(Dynamsys)} characters.");

            Regex regex = new Regex(@"^[0-9_A-Z]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
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

        public override string ToString()
        {
            char[] integralPart = new char[_integralPart.Length];
            char[] fractionalPart = new char[_fractionalPart.Length];

            for (int i = 0; i < _integralPart.Length; i++)
                integralPart[i] = _charactersSet[_integralPart[i]];

            for (int i = 0; i < _fractionalPart.Length; i++)
                fractionalPart[i] = _charactersSet[_fractionalPart[i]];

            string result = (_isNegative ? _nfi.NegativeSign : string.Empty) +
                (integralPart.Length > 0 ? new string(integralPart) : "0") +
                (_fractionalPart.Length > 0 ? _nfi.NumberDecimalSeparator +
                new string(fractionalPart) : string.Empty);

            return result;
        }

        public static bool Equals(Dynamsys a, Dynamsys b)
        {
            if (a._isNegative != b._isNegative)
                return false;

            if (a._currentNumberSystem != b._currentNumberSystem)
                return false;

            if (a._integralPart.Length != b._integralPart.Length)
                return false;

            if (a._fractionalPart.Length != b._fractionalPart.Length)
                return false;

            for (int i = 0; i < a._integralPart.Length; i++)
            {
                if (a._integralPart[i] != b._integralPart[i])
                    return false;
            }

            for (int i = 0; i < a._fractionalPart.Length; i++)
            {
                if (a._fractionalPart[i] != b._fractionalPart[i])
                    return false;
            }

            return true;
        }

        public bool Equals(Dynamsys other)
        {
            return Equals(this, other);
        }
    }
}
