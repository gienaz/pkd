using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int nub;
        int nubs;
        int outp;
        int result;


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

        private void button5_Click(object sender, EventArgs e)
        {
            TB1.Text = TB1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
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

        private void TB1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) { }
        private void Button_Click_2(object sender, RoutedEventArgs e) { }



    }
}
