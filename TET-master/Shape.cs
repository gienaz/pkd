using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Shape
    {
        public int x;
        public int y;
        public int[,] matrix;

        public Shape(int _x, int _y)
        {
            x = _x;
            y = _y;
            matrix = new int[3, 3] {
                {0,1,0},
                {0,1,1},
                {0,0,1},
            };


        }
        public void MoveDown()
        {
            y++;
        }
        public void Moveright()
        {
            x++;
        }
        public void MoveLeft()
        {
            x--;
        }
    }
}