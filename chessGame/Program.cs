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
            Piece p1 = null;
            Console.WriteLine(p1 == null);
            /*
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            ChessBoard chessBoard = chessBoardBuilder.GetChessBoard();
            
            Dictionary<Coord, Piece> pi = new Dictionary<Coord, Piece>() { { new Coord(2, 'e'), new King() } , 
                { new Coord(20, 'a'), new Pawn() }  ,
                { new Coord(2, 'a'), new Pawn() }};

            Console.WriteLine("-------------------------------------");
            foreach (List<char> column in chessBoard.board.Values)
            {
                Console.WriteLine(column.Count);

                    Console.WriteLine();
            }

            */


            //foreach(KeyValuePair<Coord, Piece> kv in chessBoard.pieceAtCoord)
            //Console.WriteLine(ki);

            // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
