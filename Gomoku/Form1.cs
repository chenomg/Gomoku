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
        //PointedPiece=1代表黑棋，0代表白棋
        private static int[,] PointedPiece = new int[9,9];
        private void InitialArray()
        {
            for(int i=0;i<9;i++)
            {
                for(int j=0;j<9;j++)
                {
                    PointedPiece[i, j] = -1;
                }
            }
        }
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
            Board ClickPointBoard = new Gomoku.Board();
            Point ActiveXY = ClickPointBoard.ActivePoint(e.X, e.Y);
            int x = ClickPointBoard.FindClossestNum(e.X);
            int y = ClickPointBoard.FindClossestNum(e.Y);
            int IndexX = ClickPointBoard.FindIndexNum(x);
            int IndexY = ClickPointBoard.FindIndexNum(y);
            if (ActiveXY != new Point(-1, -1))
            {
                if (IsBlack == true)
                {
                    this.Controls.Add(new BlackPiece(x, y));
                    IsBlack = false;
                    PointedPiece[IndexX,IndexY] = 1;
                    BlackWinTheGame(IndexX,IndexY);
                }
                else if (IsBlack == false)
                {
                    this.Controls.Add(new WhitePiece(x, y));
                    IsBlack = true;
                    PointedPiece[IndexX, IndexY] = 0;
                }
            }
            else return;
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
        public void BlackWinTheGame(int IndexXX, int IndexYY)
        {
            //bool BlackWin = false;
            int count = 0 ;
            for(int i=0; i<9 && count<5 ;i++)
            {
                if (PointedPiece[i, IndexYY] == 1)
                    count++;
                else count = 0;
            }
            //MessageBox.Show("X方向" + count);
            if (count == 5)
            {
                MessageBox.Show("恭喜你，黑子获胜！");
                this.Controls.Clear();
                IsBlack = true;
                InitialArray();
            }                
            else if (count<5)
            {
                for (int i = 0; i < 9 && count<5; i++)
                {
                    if (PointedPiece[IndexXX, i] == 1)
                        count++;
                    else count = 0;
                }
                if (count >= 5)
                {
                    MessageBox.Show("恭喜你，黑子获胜！");
                    this.Controls.Clear();
                    IsBlack = true;
                    InitialArray();
                }
                //MessageBox.Show("Y方向" + count);
            }
            else if(count<5)
            {

            }
            
        }
    }
}
