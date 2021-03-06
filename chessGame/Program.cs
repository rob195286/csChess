﻿using chessGame.model;
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
            ChessBoardDirector cbd = new ChessBoardDirector();
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            cbd.ConstructDefaultChessBoard(cbb);
            ChessBoard cb = cbb.GetChessBoard();
            /*
            Dictionary<Coord, Piece> pi = new Dictionary<Coord, Piece>() { { new Coord(2, 'e'), new King() } , 
                { new Coord(20, 'a'), new Pawn() }  ,
                { new Coord(2, 'a'), new Pawn() }};
            */
            Console.WriteLine("-------------------------------------");
            foreach (Coord kv in cb.pieceAtCoord.Keys)
                Console.WriteLine(kv);
            

            //foreach(KeyValuePair<Coord, Piece> kv in chessBoard.pieceAtCoord)
            //Console.WriteLine(ki);

            // Console.WriteLine(chessBoard.board.Count);

        }

    }
}
