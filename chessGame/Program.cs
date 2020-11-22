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
            List<char> alphanum = new List<char>() { };
            ColumnCollection col = new ColumnCollection(8);
            
            foreach (char c in col)
            {

                Console.WriteLine(c);
            }
            
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
