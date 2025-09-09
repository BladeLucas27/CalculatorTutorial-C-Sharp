using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorTutorial
{
    public partial class Form1 : Form
    {
        String num1 = ""; // User input
        String num2 = ""; // User input
        String lastResult = ""; // Last result
        bool isOperating = false; // Is an operation being performed
        bool hasDecimal1 = false, hasDecimal2 = false; // Does the current number have a decimal point
        char operation; // The operation to be performed
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "1";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "1";
                textBox1.Text = num2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isOperating)
            {
                num1 += "2";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "2";
                textBox1.Text = num2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "3";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "3";
                textBox1.Text = num2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "4";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "4";
                textBox1.Text = num2;
            }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "5";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "5";
                textBox1.Text = num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "6";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "6";
                textBox1.Text = num2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "7";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "7";
                textBox1.Text = num2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "8";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "8";
                textBox1.Text = num2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "9";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "9";
                textBox1.Text = num2;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(!isOperating)
            {
                num1 += "0";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "0";
                textBox1.Text = num2;
            }
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!isOperating)
            {
                if(!hasDecimal1)
                {
                    num1 += ".";
                    textBox1.Text = num1;
                    hasDecimal1 = true;
                }
            }
            else
            {
                if (!hasDecimal2)
                {
                    num2 += ".";
                    textBox1.Text = num2;
                    hasDecimal2 = true;
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            if (isOperating)
            {
               // If an operation is already being performed, calculate the result first
                buttonEquals_Click(sender, e);
            }
            isOperating = true;
            operation = '+';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            if (isOperating)
            {
                // If an operation is already being performed, calculate the result first
                buttonEquals_Click(sender, e);
            }
            isOperating = true;
            operation = '-';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            if (isOperating)
            {
                // If an operation is already being performed, calculate the result first
                buttonEquals_Click(sender, e);
            }
            isOperating = true;
            operation = '*';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            if (isOperating)
            {
                // If an operation is already being performed, calculate the result first
                buttonEquals_Click(sender, e);
            }
            isOperating = true;
            operation = '/';
        }
        private void buttonModulo_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            if (isOperating)
            {
                // If an operation is already being performed, calculate the result first
                buttonEquals_Click(sender, e);
            }
            isOperating = true;
            operation = '%';
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(!hasDecimal1 && !hasDecimal2)
            {
                int result = 0;
                if (operation == '+')
                {
                    result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                }
                else if (operation == '-')
                {
                    result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                }
                else if (operation == '*')
                {
                    result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                }
                else if (operation == '/')
                {
                    result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                }
                else if (operation == '%')
                {
                    result = Convert.ToInt32(num1) % Convert.ToInt32(num2);
                }
                else
                {
                    result = Convert.ToInt32(num1);
                }
                textBox1.Text = result.ToString();
                num1 = result.ToString();
            }
            else
            {
                double result = 0.0;
                if (operation == '+')
                {
                    result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                }
                else if (operation == '-')
                {
                    result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                }
                else if (operation == '*')
                {
                    result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                }
                else if (operation == '/')
                {
                    result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                }
                else if (operation == '%')
                {
                    result = Convert.ToDouble(num1) % Convert.ToDouble(num2);
                }
                else
                {
                    result = Convert.ToDouble(num1);
                }
                hasDecimal2 = false;
                textBox1.Text = result.ToString();
                num1 = result.ToString();
            }
            num2 = string.Empty;
            isOperating = false;
            operation = '\0';
            lastResult = textBox1.Text;
            if(lastResult == "0")
            {
                hasDecimal1 = false;
                num1 = string.Empty;
            }
        }

        private void buttonRecall_Click(object sender, EventArgs e)
        {
            num1 = string.Empty;
            num2 = string.Empty;
            textBox1.Text = lastResult;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!isOperating)
            {
                if (num1.Length > 0)
                {
                    if (num1.EndsWith("."))
                    {
                        hasDecimal1 = false;
                    }
                    num1 = num1.Substring(0, num1.Length - 1);
                    textBox1.Text = num1;
                }
            }
            else
            {
                if (num2.Length > 0)
                {
                    if (num1.EndsWith("."))
                    {
                        hasDecimal1 = false;
                    }
                    num2 = num2.Substring(0, num2.Length - 1);
                    textBox1.Text = num2;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            num1 = string.Empty;
            num2 = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
