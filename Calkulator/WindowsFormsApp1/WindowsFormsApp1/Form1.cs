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
    public partial class Form1 : Form
    {
        int nub;
        int nubs;
        int outp;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnText_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + " + ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "4";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "5";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "8";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TB1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double result = 0;

            string operation = "";

            string[] tokens = TB1.Text.Split(' ');

            if (tokens.Length % 2 == 1)
            {
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    if (double.TryParse(tokens[i], out double value))
                    {
                        if (i == 0)
                        {
                            result = value;
                        }
                        else
                        {
                            switch (operation)
                            {
                                case "+":
                                    result += value;
                                    break;
                                case "-":
                                    result -= value;
                                    break;
                                case "*":
                                    result *= value;
                                    break;
                                case "/":
                                    result /= value;
                                    break;
                                default:
                                    return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }

                    if (i + 1 < tokens.Length)
                    {
                        operation = tokens[i + 1];
                    }
                }

                TB1.Text = "" + result;
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + " - ";
        }

        private void btnumn_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + " * ";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + " / ";
        }

        private void TB1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.C)
            {
                TB1.Text = "0";
            }
        }
    }
    }

