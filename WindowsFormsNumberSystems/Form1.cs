using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryNumberSystems;

namespace WindowsFormsNumberSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_FinNewNumber_Click(object sender, EventArgs e)
        {
            string num;
            double fromNumberSystem;
            double toNumberSystem;

            //RichTextBox_Log.Text = NumChecker(TextBox_NumberForTranslate.Text);
            num = TextBox_NumberForTranslate.Text;

            if (!double.TryParse(TextBox_FromSystemOfNumber.Text, out fromNumberSystem))
            {
                TextBox_Result.Text = "Ошибка!";
                return;
            }
            if (!double.TryParse(TextBox_ToSystemOfNumber.Text, out toNumberSystem))
            {
                TextBox_Result.Text = "Ошибка!";
                return;
            }

            string result = NumberSystems.toDecimalSystem_str(num, fromNumberSystem);
            result = NumberSystems.toCustomSystem_str(result, toNumberSystem);
            TextBox_Result.Text = result.ToString();
        }

        private void TextBox_NumberForTranslate_TextChanged(object sender, EventArgs e)
        {
            TextBox_Result.Text = "";
        }

        private void TextBox_FromSystemOfNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox_Result.Text = "";
        }

        private void TextBox_ToSystemOfNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox_Result.Text = "";
        }
        private string NumChecker(string str)
        {
            int i = 0;

            if (str[i] == '-' || str[i] == '+') i++;

            for (; i < str.Length && str[i] != ','; i++) // Проверка целой части числа
            {
                if (str[i] == '.')
                {
                    return "В качестве разделителя целой части от дробной нужно использовать запятую! Вы используете точку.";
                }
                if (str[i] < '0' || str[i] > '9')
                {
                    return "В целой части числа присутствуют недопустимые символы!";
                }
            }
            i++;

            for (; i < str.Length; i++) // Проверка дробной части числа
            {
                if (str[i] == ',')
                {
                    return "В числе не может быть больше одной запятой!";
                }
                if (str[i] < '0' || str[i] > '9')
                {
                    return "В дробной части числа присутствуют недопустимые символы!";
                }
            }

            return "Всё в порядке.";
        }
    }
}
