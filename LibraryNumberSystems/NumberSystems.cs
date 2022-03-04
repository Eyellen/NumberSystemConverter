﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNumberSystems
{
    /// <summary>
    /// Класс систем счисления
    /// Позволяет переводить числа из одной системы счисления в другую
    /// </summary>
    public static class NumberSystems
    {
        const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTVWXYZ";

        #region NEW

        /// <summary>
        /// Функция переводит строку-число из какой-либо системы в десятичную
        /// </summary>
        /// <param name="str">строка-число</param>
        /// <param name="fromSystem">из системы счисления</param>
        /// <returns>строка-число в десятичной системе счисления</returns>
        public static string toDecimalSystem_str(string str, double fromSystem) // Только для целых чисел
        {
            double num = 0;
            int i = 0;
            for (; i < str.Length; i++) // Перевод целой части
            {
                if (str[str.Length - 1 - i] >= '0' && str[str.Length - 1 - i] <= '9')
                {
                    num = num + (str[str.Length - 1 - i] - 48) * Math.Pow(fromSystem, i);
                }
                if(str[str.Length - 1 - i] >= 'A' && str[str.Length - 1 - i] <= 'Z')
                {
                    num = num + (str[str.Length - 1 - i] - 55) * Math.Pow(fromSystem, i);
                }
                if (str[str.Length - 1 - i] >= 'a' && str[str.Length - 1 - i] <= 'z')
                {
                    num = num + (str[str.Length - 1 - i] - 87) * Math.Pow(fromSystem, i);
                }
            }



            return num.ToString();
        }
        /// <summary>
        /// Функция переводит строку-число из десятичной системы счисления в любую другую
        /// </summary>
        /// <param name="str">строка-число</param>
        /// <param name="toSystem">в систему</param>
        /// <returns>строка-число</returns>
        public static string toCustomSystem_str(string str, double toSystem)
        {
            //double num = StrToDouble(str);
            double num;
            double.TryParse(str, out num);

            int integral = (int)Math.Truncate(num); // Целая часть
            double fraction = num - integral; // Дробная часть

            string result = "";

            while (integral > 0) // Целая часть
            {
                switch (integral % (int)toSystem)
                {
                    default:
                        result = (integral % (int)toSystem).ToString() + result;
                        break;
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                }
                //result = (integral % (int)toSystem).ToString() + result;
                integral = integral / (int)toSystem;
            }

            // Дробная часть
            if (fraction != 0) result += ",";
            fraction = (fraction - Math.Truncate(fraction)) * toSystem;
            for (int i = 0; i < 13 && (fraction - Math.Truncate(fraction) != 0); i++)
            {
                //result = result + Math.Truncate(fraction);
                switch (Math.Truncate(fraction))
                {
                    default:
                        result = result + Math.Truncate(fraction);
                        break;
                    case 10:
                        result = result + "A";
                        break;
                    case 11:
                        result = result + "B";
                        break;
                    case 12:
                        result = result + "C";
                        break;
                    case 13:
                        result = result + "D";
                        break;
                    case 14:
                        result = result + "E";
                        break;
                    case 15:
                        result = result + "F";
                        break;
                }
                fraction = (fraction - Math.Truncate(fraction)) * toSystem;
            }

            return result;
        }

        #endregion

        public static int QuantityOfDigits(double num)
        {
            return (int)Math.Log10(num) + 1;
        }
        /// <summary>
        /// Переводит строку в число типа Double
        /// </summary>
        /// <param name="str">строка-число</param>
        /// <returns>Число типа Double</returns>
        public static double StrToDouble(string str)
        {
            if (!IsNumber(str)) return 0; // Проверка является ли строка числом

            double num = 0;
            int i = 0;
            if (str[i] == '-' || str[i] == '+') i++; // Пропускает знак числа
            for (; i < str.Length; i++) // Переводит целую часть строки-числа в double
            {
                if (str[i] == '.' || str[i] == ',')
                {
                    i++;
                    break;
                }
                num = num * 10 + (str[i] - 48);
            }
            double fraction = 1;
            for (; i < str.Length; i++) // Переводит вещественную часть строки-числа в double
            {
                fraction *= 0.1;
                num += fraction * (str[i] - 48);
                //num += (fraction *= .1) * (str[i] - 48);
            }
            if (str[0] == '-') num *= -1;
            return num;
        } // Нахрена я это сделал если есть tryparse
        /// <summary>
        /// Функция проверяет является ли строка числом
        /// </summary>
        /// <param name="str">строка-число</param>
        /// <returns>истинно либо ложно</returns>
        public static bool IsNumber(string str)
        {
            int i = 0;
            if (str[i] == '-' || str[i] == '+') i++;
            for (; i < str.Length; i++)
            {
                if (str[i] < 48 || str[i] > 57)
                {
                    if (str[i] != '.' && str[i] != ',') return false;
                }
            }
            return true;
        }
    }
}
