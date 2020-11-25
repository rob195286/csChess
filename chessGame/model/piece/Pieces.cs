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

        // todo : enlever shallowcopy
        public King ShallowCopy()
        {
            return (King)this.MemberwiseClone();
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

        public Queen ShallowCopy()
        {
            return (Queen)this.MemberwiseClone();
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

        public Rook ShallowCopy()
        {
            return (Rook)this.MemberwiseClone();
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


        public Bishop ShallowCopy()
        {
            return (Bishop)this.MemberwiseClone();
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


        public Knight ShallowCopy()
        {
            return (Knight)this.MemberwiseClone();
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

        public Pawn ShallowCopy()
        {
            return (Pawn)this.MemberwiseClone();
        }
    }
    
}
