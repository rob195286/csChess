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
            ChessBoard chessBoard = new ChessBoard();
            King king1 = new King();
            King king2 = new King(PiecesColor.black);
            /*
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            ChessBoard chessBoard = chessBoardBuilder.GetChessBoard();
            */
            chessBoard.AddPieces(new List<Piece>() { king1, king2 },
                                new List<Coord>() { new Coord(), new Coord(5, 'r') });
            King ki = (King)chessBoard.GetPieceByID(1);

            Console.WriteLine("-------------------------------------");
            foreach(KeyValuePair<Coord, Piece> kv in chessBoard.pieces)
            Console.WriteLine(ki);

           // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
