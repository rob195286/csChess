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
        protected int _id;
        public int id
        {
            get => _id;
            set => _id = value;
        }

        protected PiecesColor _color;
        public virtual PiecesColor color
        {
            get => _color;
        }


        protected Piece() : this(PiecesColor.white)
        {
        }
        protected Piece(PiecesColor pieceColor)
        {
            _id = 0;
            _color = pieceColor;
        }


        public override string ToString()
        {
            return base.ToString()
                + "\n   piece id : " + this._id
                + "\n   Piece Type : " + this.GetType()
                + "\n   Piece Color : " + this._color;
        }
    }
}
