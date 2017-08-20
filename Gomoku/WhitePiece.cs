using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    class WhitePiece:Pieces
    {
        public WhitePiece(int x, int y): base (x, y)
        {
            this.BackgroundImage = Properties.Resources.white;
        }
    }
}
