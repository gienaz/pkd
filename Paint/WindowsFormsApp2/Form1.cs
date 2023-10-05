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
        Graphics g;
        int x = -1;
        int y = -1;
        int size = 0;
        int ssd = 2;
        bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving= true;
            x = e.X;
            y = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

               
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving= false;
            x= -1;
            y = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            g.Clear(pictureBox1.BackColor);
            pictureBox1.BackColor = Color.Black;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ssd++;
        }
    }
}
