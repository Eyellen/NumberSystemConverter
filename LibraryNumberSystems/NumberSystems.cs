using System;
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
        public const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

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
        /// Функция переводит строку-число из десятичной системы счисления в любую другую
        /// </summary>
        /// <param name="str">строка-число</param>
        /// <param name="toSystem">в систему</param>
        /// <returns>строка-число</returns>
        public static string toCustomSystem_str(string str, double toSystem)
        {
            double num;
            double.TryParse(str, out num);

            int integral = (int)Math.Truncate(num); // Целая часть
            double fraction = num - integral; // Дробная часть

            string result = "";

            while (integral > 0) // Целая часть
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

            // Дробная часть
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
                if (str[i] < '0' || str[i] > '9')
                {
                    if (str[i] != '.' && str[i] != ',') return false;
                }
            }
            return true;
        }
    }
}
