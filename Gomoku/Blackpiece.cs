using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    class BlackPiece : Pieces
    {
        public BlackPiece(int x, int y): base (x, y)
        {
            this.BackgroundImage = Properties.Resources.black;
        }
    }
}
