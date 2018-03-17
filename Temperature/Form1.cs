using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = ".";
            radioButton1.Text = "攝氏轉為華氏";
            radioButton2.Text = "華氏轉為攝氏";
            label1.Text = "";
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var getTemp = double.Parse(textBox1.Text);
            double ConvertTemp = 0;
            if (radioButton1.Checked == true)
            {
                ConvertTemp = getTemp*9 / 5 + 32;
                label1.Text = "攝氏溫度為" + getTemp + "，轉為華氏溫度為" + ConvertTemp.ToString("F2");
            }
            else
            {
                ConvertTemp = (getTemp - 32) * 5 / 9;
                label1.Text = "華氏溫度為" + getTemp + "，攝氏轉為溫度為" + ConvertTemp.ToString("F2");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
