using chessGame.model;
using chessGame.model.board;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace chess_game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            /*
            ChessBoardDirector cbd = new ChessBoardDirector();
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            cbd.ConstructDefaultChessBoard(cbb);
            ChessBoard cb = cbb.GetChessBoard();

            foreach(List<char> c in cb.board.Values)
            {
                Console.WriteLine(c);
                Console.WriteLine("-------------------------------------");

            }
            */
            //Console.WriteLine(cb.board.);
            
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new ChessGame());
        }
    }
}
