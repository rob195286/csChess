using chessGame.model;
using chessGame.model.board;
using chessGame.model.piece;
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
            /*
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            ChessBoard chessBoard = chessBoardBuilder.GetChessBoard();
            */

            PossibleMoves m = new PossibleMoves(new Dictionary<EDirections, int>() { {EDirections.horizontal,5},{ EDirections.vertical, 1 } });

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(m);

           // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
