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

            Dictionary<Coord, Piece> pi = new Dictionary<Coord, Piece>() { { new Coord(2, 'e'), new King() } , { new Coord(20, 'a'), new Pawn() } };

            Console.WriteLine("-------------------------------------");
            foreach (KeyValuePair<Coord, Piece> kv in pi)
                Console.WriteLine(kv);




            //foreach(KeyValuePair<Coord, Piece> kv in chessBoard.pieceAtCoord)
            //Console.WriteLine(ki);

            // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
