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
            double fromNS;
            double toNS;

            string integral;
            string fraction;


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
        private string NumChecker(string str, out string num)
        {

        }
    }
}
