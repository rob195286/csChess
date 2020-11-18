using chessGame.model;
using chessGame.pieces;
using System;
using System.Collections.Generic;

namespace chessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new List<int> { 1, 2, 3, 4 };
            var bar = new List<char> { 'a', 'b', 'c', 's' };
            var b = new Board(new List<King>() { new King(1) },
                                 new List<Rook> { new Rook(1) },
                                 new List<Bishop> { new Bishop(1) },
                                 new List<Queen> { new Queen(1) },
                                 new List<Knight> { new Knight(1) },
                                 new List<Pawn> { new Pawn(1) },
                                 foo,
                                 bar);
            /*
            List<int> l1 = new List<int>() { 1, 2 };
            List<int> l2 = new List<int>() { 3, 24 };
            Dictionary<List<int>, char> test = new Dictionary<List<int>, char>() { {l1, 'r' }, {l2, 'e' } };
            foreach (var t in test)
            {
                foreach (var x in t.Key)
                    Console.WriteLine(x);
                Console.WriteLine("---------------------------");
                //foreach (List<int> c in rc)
                //Console.WriteLine(c.index);
            }
            */
            foreach (var rc in b.board)
            {
                foreach (var c in rc.Key)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(rc.Value);
                }
            }
              
        }
    }
}
