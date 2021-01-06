using chessGame.model;
using chessGame.model.board;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_game
{
    public partial class Form1 : Form
    {
        ChessBoard chessBoard;
        public Button[,] buttons;

        public Form1()
        {
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            ChessBoardDirector cbd = new ChessBoardDirector();
            cbd.ConstructDefaultChessBoard(cbb);
            chessBoard = cbb.GetChessBoard();

            //buttons = new Button[chessBoard.,];
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            //int buttonSize = Panel1.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
