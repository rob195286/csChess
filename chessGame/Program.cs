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
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            ChessBoard chessBoard = chessBoardBuilder.GetChessBoard();

            Dictionary<Coord, Piece> pi = new Dictionary<Coord, Piece>() { { new Coord(2, 'e'), new King() } };

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(pi.ContainsKey(new Coord(2, 'e')));
            Console.WriteLine(pi.ContainsKey(new Coord(2, 'a')));
            Console.WriteLine(pi.ContainsKey(new Coord(1, 'a')));
            Console.WriteLine(pi.ContainsKey(new Coord(1, 'e')));
            pi.Add(new Coord(1, 'e'), new King());
            Console.WriteLine(pi.ContainsKey(new Coord(1, 'e')));


            //foreach(KeyValuePair<Coord, Piece> kv in chessBoard.pieces)
            //Console.WriteLine(ki);

            // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
