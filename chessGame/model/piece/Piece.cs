using chessGame.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public enum PiecesColor
    {
        white,
        black
    }

    public abstract class Piece
    {
        public int id { get; set; }

        public virtual PiecesColor color { get; }


        protected Piece() : this(PiecesColor.white)
        {
        }
        protected Piece(PiecesColor pieceColor)
        {
            id = 0;
            color = pieceColor;
        }


        // public abstract Piece ShallowCopy();

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Piece))
                return false;

            Piece piece = (Piece)obj;

            //if (_id == piece.id && _color == piece._color && this.GetType() == piece.GetType())
            if (id == piece.id && this.GetType() == piece.GetType())
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
            return base.ToString()
                + "\n   piece id : " + this.id
                + "\n   Piece Type : " + this.GetType()
                + "\n   Piece Color : " + this.color;
        }
    }
}
