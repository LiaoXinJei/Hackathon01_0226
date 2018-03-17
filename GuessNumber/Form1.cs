using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        int ifStart = 0;
        int[] NumberRnd = new int[4] { 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NumberRnd = GenerateRnd();
            btnStart.Enabled = false;
            ifStart++;
            btnAnswer.Enabled = true;
            btnCheckAnswer.Enabled = true;
            btnReGame.Enabled = true;
        }

        private int[] GenerateRnd()
        {
            Random rnd = new Random();
            for (var i = 0; i < 4; i++)
            {
                NumberRnd[i] = rnd.Next(0, 10);
                for (var j = 0; j < i; j++)
                {
                    if (NumberRnd[i] == NumberRnd[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            return NumberRnd;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() == 4)
            {
                var dictionary = new Dictionary<int, int> { };
                int A = 0, B = 0;
                int getInput = int.Parse(textBox1.Text);
                int Thousand = getInput / 1000;
                int Hundred = (getInput % 1000) / 100;
                int Ten = (getInput % 100) / 10;
                int Bit = getInput % 10;
                dictionary.Add(0, Thousand);
                dictionary.Add(1, Hundred);
                dictionary.Add(2, Ten);
                dictionary.Add(3, Bit);
                for (var i = 0; i < 4; i++)
                {

                    if (NumberRnd[i] == dictionary[i])
                    {
                        A++;
                        if (A == 4)
                        {
                            MessageBox.Show("過關");
                            btnStart.Enabled = true;
                            btnAnswer.Enabled = false;
                            btnCheckAnswer.Enabled = false;
                            btnReGame.Enabled = false;
                        }
                    }
                    else
                    {
                        for (var j = 0; j < 4; j++)
                            if (NumberRnd[i] == dictionary[j])
                                B++;
                    }
                }
                listBox1.Items.Add(textBox1.Text + " : " + A + "A" + B + "B");
            }
            else
                MessageBox.Show("請輸入4位數字");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            foreach (var i in NumberRnd)
                label3.Text += i;
        }

        private void btnReGame_Click(object sender, EventArgs e)
        {
            NumberRnd = GenerateRnd();
        }
    }
}
