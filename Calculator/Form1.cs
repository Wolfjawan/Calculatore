using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public static string input = string.Empty;
        public static string operandOne = string.Empty;
        public static string operandTwo = string.Empty;
        char operation;
        double result = 0.0;
        public Calculator()
        {
            InitializeComponent();
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "7";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '7';

        }
        private void buttonEaght_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "8";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '8';
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "9";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '9';
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '/';
            input = string.Empty;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '/';
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "4";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '4';
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "5";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '5';
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "6";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '6';
        }
        private void buttonMultipl_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '*';
            input = string.Empty;
            richTextBoxTwo.Text = richTextBoxTwo.Text + 'x';
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "1";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '1';
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "2";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '2';
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "3";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '3';
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '-';
            input = string.Empty;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '-';
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += ".";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '.';
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            richTextBoxOne.Text = "";
            input += "0";
            richTextBoxOne.Text += input;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '0';
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operandTwo = input;
            double num1, num2;
            double.TryParse(operandOne, out num1);
            double.TryParse(operandTwo, out num2);
            if (operation == '+')
            {
                result = num1 + num2;
                richTextBoxOne.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                richTextBoxOne.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                richTextBoxOne.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    richTextBoxOne.Text = result.ToString();
                }
                else
                {
                    richTextBoxOne.Text = "DIV/Zero!";
                }

            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '+';
            input = string.Empty;
            richTextBoxTwo.Text = richTextBoxTwo.Text + '+';
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
             richTextBoxOne.Text = "";
             input = string.Empty;
             operandOne = string.Empty;
             operandTwo = string.Empty;
             richTextBoxTwo.Text = string.Empty;
        }
        private void richTextBoxOne_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
        private void richTextBoxTwo_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
    }
}
