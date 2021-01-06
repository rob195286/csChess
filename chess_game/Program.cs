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
            ChessBoardDirector cbd = new ChessBoardDirector();
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            cbd.ConstructDefaultChessBoard(cbb);
            ChessBoard cb = cbb.GetChessBoard();
            /*
            Dictionary<Coord, Piece> pi = new Dictionary<Coord, Piece>() { { new Coord(2, 'e'), new King() } , 
                { new Coord(20, 'a'), new Pawn() }  ,
                { new Coord(2, 'a'), new Pawn() }};
            */


            foreach(List<char> c in cb.board.Values)
            {
                Console.WriteLine(c);
                Console.WriteLine("-------------------------------------");

            }

            //Console.WriteLine(cb.board.);
            /*
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());*/
        }
    }
}
