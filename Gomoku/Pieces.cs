using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gomoku
{
    class Pieces : PictureBox
    {
        private static int PIECEWIDETH = 50;
        public Pieces (int x,int y)
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(PIECEWIDETH, PIECEWIDETH);
            this.Location = new Point(x, y);
        }
        
    }
}
