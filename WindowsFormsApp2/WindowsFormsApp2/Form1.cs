using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public TextBox myText;
        public char operation;
        public double num1;
        public double result;
        public double ans;
        public int num1Length;
        public int pointCount = 1;

        public Form1()
        {
            InitializeComponent();
            myText = textBox1;
        }           

        private void button1_Click(object sender, EventArgs e)
        {
            myText.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            myText.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            myText.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            myText.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            myText.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            myText.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            myText.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            myText.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            myText.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            myText.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //=
            double num2 = Convert.ToDouble(myText.Text.Remove(0,num1Length));
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            myText.Text = Convert.ToString(result);
            num1 = result;
            operation = '\0';
            num2 = 0.0;
            pointCount = 1;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //+
            operation = '+';
            num1TextToDouble();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //-
            operation = '-';
            num1TextToDouble();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //*
            operation = '*';
            num1TextToDouble();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            // /
            operation = '/';
            num1TextToDouble();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myText.Text = null;
            num1 = 0.0;
            operation = '\0';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (pointCount > 0)
            {
                pointCount--;
                myText.Text += '.';
            }
            else
            {
                return;
            }

        }
        void num1TextToDouble()
        {
            num1 = Convert.ToDouble(myText.Text);
            myText.Text += Convert.ToString(operation);
            num1Length = myText.TextLength;
            pointCount = 1;
        }
                     
    }
}
