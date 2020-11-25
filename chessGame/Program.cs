using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace chessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultBoard();
            ChessBoard chessBoard = chessBoardBuilder.GetChessBoard();


            Console.WriteLine(chessBoard.board.Count);

            /*
            Console.WriteLine("-------------------");
            Console.WriteLine(col[3]);
            
            Console.WriteLine("-------------------");
            col.Next();
            Console.WriteLine(col[3]);
            Console.WriteLine(col[4]);

            */

        }
    }
}
