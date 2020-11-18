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
            //ChessBoard b = new ChessBoard(5, new List<char>() { 'r', 't', 'a' });
            King p = new King(1);
            Console.WriteLine(p is Piece);

        }
    }
}
