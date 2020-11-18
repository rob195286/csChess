using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model
{
    public class Player
    {
        private int _id;
        public int Id { get => _id; }

        private PiecesColor _piecesColor;
        public PiecesColor PiecesColor { get => _piecesColor; }

        private List<Piece> _pieces;
        public List<Piece> Pieces { get => _pieces; set => _pieces = value; }


        public Player(int id, PiecesColor piecesColor) : this(id, piecesColor, new List<Piece>() { })
        {
        }
        public Player(int id, PiecesColor piecesColor, List<Piece> pieces)
        {
            _id = id;
            _piecesColor = piecesColor;
            _pieces = pieces;
        }

        public void RemovePiece(Piece piece)
        {
            // todo : remove piece
        }
    }
}
