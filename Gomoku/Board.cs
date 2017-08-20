using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    class Board
    {

        private static readonly int offset = 70;
        private static readonly int Pitch = 75;
        private static readonly int Radius = 15;
        private static readonly Point NoMatchPoint = new Point(-1, -1);
        /*
        public bool CanBePlaced(int x,int y)
        {
            ;
        }
        */
        private int FindClossestNum (int Pos)
        {
            if (Pos<offset -10)
                return -1;
            else
            {
                Pos -= offset;
                int ShangPos = Pos / Pitch;
                int YuPos = Pos % Pitch;
                if (YuPos <= Radius)
                {
                    return ShangPos;
                }
                else if (YuPos >= Pitch - Radius)
                {
                    return ++ShangPos;
                }
                return -1;
            }

        }
        public Point ActivePoint(int x, int y)
        {
            Point A = new Point(x,y);
            if (FindClossestNum(x) != -1 && FindClossestNum(y) != -1)
                return A;
            else return NoMatchPoint;
        }
    }
}
