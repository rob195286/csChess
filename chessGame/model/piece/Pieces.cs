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
        public Queen() : base()
        {
        }
        public Queen(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Rook : Piece
    {
        public Rook() : base()
        {
        }
        public Rook(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Bishop : Piece
    {
        public Bishop() : base()
        {
        }
        public Bishop(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Knight : Piece
    {
        public Knight() : base()
        {
        }
        public Knight(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }

    public class Pawn : Piece
    {
        public Pawn() : base()
        {
        }
        public Pawn(PiecesColor pieceColor) : base(pieceColor)
        {
        }
    }
}
