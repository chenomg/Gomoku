using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gomoku.Properties;

namespace Gomoku
{
    //Board QiPan = new Board(); 
    public partial class GameForm1 : Form
    {
        bool IsBlack = true;
        bool ShowGreeting = true;


        public GameForm1()
        {
            InitializeComponent();
        }
        public void Greeting()
        {
            
            if (ShowGreeting == true)
            {
                MessageBox.Show("黑子先手");
                ShowGreeting = false;
            }
            else return;

        }
        private void GameForm1_MouseDown(object sender, MouseEventArgs e)
        {
            //Greeting();
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

        private void GameForm1_MouseMove(object sender, MouseEventArgs e)
        {
            Board MovePointBoard=new Gomoku.Board ();
            if (MovePointBoard.ActivePoint(e.X, e.Y) != new Point(-1, -1))
            {
                this.Cursor = Cursors.Hand;
            }
            else this.Cursor = Cursors.Arrow;
        }
    }
}
