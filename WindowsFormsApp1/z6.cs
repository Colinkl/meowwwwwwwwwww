using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class z6 : Form
    {
        public z6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AutoPlusFlag.Checked)
            {
                string textI = InputTextBox.Text;
                plusinator(textI);
            }
        }

        private void OutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutoPlusFlag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Plusify_Click(object sender, EventArgs e)
        {
            string textI = InputTextBox.Text;
            plusinator(textI);
        }

        private void plusinator(string textInput)
        {
            string arr_en = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string textOut = "";
            int textL = textInput.Length;
            for (int i = 0; i < textL; i++)
            {
                if (arr_en.Contains(textInput[i]))
                {
                    textOut = textOut + "+";
                }
                else
                {
                    textOut = textOut + textInput[i];
                }
            }
            OutTextBox.Text = textOut;
        }

    }
}
