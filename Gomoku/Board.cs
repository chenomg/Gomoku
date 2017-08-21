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

        private static readonly int offset = 75;
        private static readonly int Pitch = 74;
        private static readonly int Radius = 15;
        public static readonly Point NoMatchPoint = new Point(-1, -1);

        /*
        public bool CanBePlaced(int x,int y)
        {
            ;
        }
        */
        public int FindClossestNum (int Pos)
        {
            if (Pos<offset -Radius)
                return -1;
            else
            {
                Pos -= offset;
                int ShangPos = Pos / Pitch;
                int YuPos = Pos % Pitch;
                if (YuPos <= Radius)
                {
                    return ShangPos*Pitch+offset;
                }
                else if (YuPos >= Pitch - Radius)
                {
                    return ++ShangPos*Pitch+offset;
                }
                return -1;
            }

        }
        public int FindIndexNum(int Pos)
        {
            Pos -= offset;
            int ShangPos = Pos / Pitch;
            return ShangPos;
        }
        public Point ActivePoint(int x, int y)
        {
            Point ActivePoint = new Point(x,y);
            if (FindClossestNum(x) != -1 && FindClossestNum(y) != -1)
            {
                x = FindClossestNum(x);
                y = FindClossestNum(y);
                return ActivePoint;
            }
            else return NoMatchPoint;
        }
        
    }
}
