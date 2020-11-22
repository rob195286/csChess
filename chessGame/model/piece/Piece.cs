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
        protected static int _id = 0;
        protected int _pieceId;
        public int id
        {
            get => _pieceId;
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
            _id++;
            _pieceId = _id;
            _color = pieceColor;
        }


        public override string ToString()
        {
            return base.ToString()
                + "piece id" + this._pieceId
                + "Piece Type" + this.GetType()
                + "Piece Color" + this._color;
        }
    }
}
