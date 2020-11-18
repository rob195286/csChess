using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model
{
    public class Board
    {
        private Dictionary<List<int>, List<char>> _board;
        public Dictionary<List<int>, List<char>> board { get => _board; }

        private List<Coord> _coordAvailable;
        public List<Coord> coordAvailable { get => _coordAvailable; }

        private Dictionary<Coord, Piece> _pieces;
        public Dictionary<Coord, Piece> pieces { get => _pieces; }

        // todo : faire en builder dans le controller ou dans une classe
        public Board(List<King> kings,
                     List<Rook> rooks,
                     List<Bishop> bishops,
                     List<Queen> queens,
                     List<Knight> knights,
                     List<Pawn> pawns,
                     List<int> rows,
                     List<char> columns)
        {
            _board = new Dictionary<List<int>, List<char>>() { };
            _board.Add(rows, columns);
            //_board.Add(rooks);
        }

        private void BuildBoard(List<Piece> pieces, Coord coord)
        {
            foreach(Piece piece in pieces)
            {
                //_board.Add(coord, piece);
            }
        }

        public void MovePiece(Dictionary<int, char> pieceCoord)
        {

        }

        public Dictionary<string, string> GetPiece()
        {
            // todo : voir si utile
            Dictionary<string, string> x = new Dictionary<string, string>();
            return x;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
