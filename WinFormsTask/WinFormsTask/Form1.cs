using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string adress = "";
        string theme = "";
        string text = "";

        bool adressIsOk = false;

        private void textBox1_TextChanged(object sender, EventArgs e)//адрес
        {
            adress = textBox1.Text;

            if (adress.Contains("@")&&adress.Contains(".")) adressIsOk = true;
            else adressIsOk = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//тема
        {
            theme = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)//текст
        {
            text = textBox3.Text;
        }


        private void button1_Click(object sender, EventArgs e)//отправить
        {
            if (adressIsOk)
            {
                Send();
                button1.Text = "Отправлено";
            }
            else
            {
                button1.Text = "Неверный адрес";
            }
        }
        void Send()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)//черновик
        {
            Application.Exit();

        }

    }
}
