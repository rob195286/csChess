using chessGame.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public class King : Piece
    {
        // todo PROF : demander si le mécanisme 'base/this' est bon.
        public King() : base()
        {
        }
        public King(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Queen : Piece
    {
        public Queen() : this(PiecesColor.white)
        {
        }
        public Queen(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Rook : Piece
    {
        public Rook() : this(PiecesColor.white)
        {
        }
        public Rook(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Bishop : Piece
    {
        public Bishop() : this(PiecesColor.white)
        {
        }
        public Bishop(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Knight : Piece
    {
        public Knight() : this(PiecesColor.white)
        {
        }
        public Knight(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Pawn : Piece
    {
        public Pawn() : this(PiecesColor.white)
        {
        }
        public Pawn(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }
}
