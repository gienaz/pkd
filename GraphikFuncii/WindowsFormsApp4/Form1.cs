using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            float k, power;

            try
            {
                k = float.Parse(txtK.Text);
                power = float.Parse(txtN.Text);
            }
            catch (FormatException)
            {
                return;
            }

            var count = 100;
            var step = 0.1f;
            var points = Enumerable.Range(0, count)
                .Select(x => step * x - step * count / 2)
                .Select(x => new PointF(x, k * (float)Math.Pow(x, power)));

            var blackPen = new Pen(Color.Black, 1);

            e.Graphics.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);

            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.ScaleTransform(e.Graphics.DpiX / 2.54f, e.Graphics.DpiY / 2.54f);

            var penTransform = e.Graphics.Transform.Clone();

            penTransform.Invert();

            blackPen.Transform = penTransform;

            var grayPen = new Pen(Color.LightGray, 1);
            grayPen.Transform = penTransform;

            for (var x = -10; x <= 10; ++x)
            {
                var pen = x == 0 ? blackPen : grayPen; //
                e.Graphics.DrawLine(pen, x, -10, x, 10);
                e.Graphics.DrawLine(pen, -10, x, 10, x);
            }

            e.Graphics.DrawLines(blackPen, points.ToArray());
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
