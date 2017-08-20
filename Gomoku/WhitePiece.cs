using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    class WhitePiece:Pieces
    {
        //private Point point;

        
        
        public WhitePiece(int x, int y): base (x, y)
        {
            this.BackgroundImage = Properties.Resources.white;
        }
    }
}
