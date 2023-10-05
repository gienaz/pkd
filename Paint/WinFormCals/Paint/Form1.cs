namespace Paint
{
    public partial class RISOVANIE : Form
    {
        public RISOVANIE()
        {
            InitializeComponent();
            SetSize();
        }

        private class ArrayPoints
        {
            private int index;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if(size <= 0) { size = 2; }
                points= new Point[size];
            }

            public void SetPoint(int x,int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x,y);
                index++;
            }

            public void ResetPoints()
            {
                index= 0;
            }

            public int GetCountPoints()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }
        }
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(256, 256);
        Graphics graphics;

        Pen pen = new   Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse= true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse= false;
            arrayPoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) return;

            arrayPoints.SetPoint(e.X, e.X);
            if(arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X,e.Y); 
            }
        }
    }
}