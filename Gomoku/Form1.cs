using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class GameForm1 : Form
    {
        bool IsBlack = true;
        public GameForm1()
        {
            InitializeComponent();
        }

        private void GameForm1_MouseDown(object sender, MouseEventArgs e)
        {

            if (IsBlack == true)
            {
                this.Controls.Add(new BlackPiece(e.X, e.Y));
                IsBlack = false;
            }
            else if(IsBlack == false)
            {
                this.Controls.Add(new WhitePiece(e.X, e.Y));
                IsBlack = true;
            }
        }
    }
}
