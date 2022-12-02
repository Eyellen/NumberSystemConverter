using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberSystems;

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
            RichTextBox_Log.Text = string.Empty;

            byte fromNumberSystem;
            byte toNumberSystem;
            string number;
            Dynamsys dynamsys = null;

            try
            {
                fromNumberSystem = byte.Parse(TextBox_FromSystemOfNumber.Text);
                toNumberSystem = byte.Parse(TextBox_ToSystemOfNumber.Text);
                number = TextBox_NumberForTranslate.Text;

                dynamsys = new Dynamsys(number, fromNumberSystem);
                dynamsys.ConvertToCustomSystem(toNumberSystem);
            }
            catch (FormatException)
            {
                RichTextBox_Log.Text = $"You entered wrong data to " +
                    $"\"{Text_FromSystemOfNumber.Text}\" and/or \"{Text_ToSystemOfNumber.Text}\" field(s). " +
                    $"These fields can contain only numbers (0-9).";
            }
            catch (OverflowException)
            {
                RichTextBox_Log.Text = $"You entered too big numbers to " +
                    $"\"{Text_FromSystemOfNumber.Text}\" and/or \"{Text_ToSystemOfNumber.Text}\" field(s).";
            }
            catch (WrongNumberSystemException)
            {
                RichTextBox_Log.Text = $"You entered wrong number system for number. " +
                    $"Max possible number system value is {Dynamsys.MaxNumberSystemValue} " +
                    $"and number shouldn't contain digits that are greater than number system";
            }
            catch (InappropriateCharactersException)
            {
                RichTextBox_Log.Text = $"You entered inappropriate characters in \"{Text_EnterNumber.Text}\" field. " +
                    $"Range of possible characters is {string.Join(",", Dynamsys.CharactersSet.ToCharArray())}.";
            }
            catch (Exception)
            {
                RichTextBox_Log.Text = $"You entered wrong data to " +
                    $"\"{Text_FromSystemOfNumber.Text}\" and/or " +
                    $"\"{Text_ToSystemOfNumber.Text}\" and/or " +
                    $"\"{Text_EnterNumber.Text}\" field(s).";
            }

            TextBox_Result.Text = dynamsys?.ToString();
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
    }
}
