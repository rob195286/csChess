using chessGame.model;
using chessGame.model.piece;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chessGame.pieces
{
    public enum PiecesColor
    {
        white,
        black
    }

    public enum Directions
    {
        diagonal,
        horizontal,
        vertical,
        verticalFront
    }

    public abstract class Piece
    {
        protected List<Directions> _moves;
        public List<Directions> moves { get => _moves; }

        public int id { get; set; }
        public PiecesColor color { get; }


        protected Piece() : this(PiecesColor.white)
        {
        }
        protected Piece(PiecesColor pieceColor)
        {
            id = 0;
            color = pieceColor;
        }


        public bool HasDirection(Directions direction)
        {
            return this.moves.Contains(direction);
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Piece))
                return isEqual;

            Piece p = (Piece)obj;

            if (id == p.id && 
                        this.GetType() == p.GetType() &&
                        color == p.color &&
                        Enumerable.SequenceEqual(_moves, p.moves))
                isEqual = true;

            return isEqual;
        }

        public static bool operator ==(Piece x, Piece y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Piece x, Piece y)
        {
            return !(x.Equals(y));
        }

        public override string ToString()
        {
            return "\n   p id : " + this.id
                + "\n   Piece Type : " + this.GetType()
                + "\n   Piece Color : " + this.color;
        }
    }
}
