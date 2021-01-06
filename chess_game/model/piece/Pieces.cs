using chessGame.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public class King : Piece
    {
        public King() : base()
        {           
        }
        public King(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        {
        }

    }
    
    public class Queen : Piece
    {
        public Queen() : base()
        {
        }
        public Queen(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        {
        }

    }

    public class Rook : Piece
    {
        public Rook() : base()
        {
        }
        public Rook(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        {
        }

    }

    public class Bishop : Piece
    {
        public Bishop() : base()
        {
        }
        public Bishop(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        {
        }

    }

    public class Knight : Piece
    {
        public Knight() : base()
        {
        }
        public Knight(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        {
        }

    }

    public class Pawn : Piece
    {
        public Pawn() : base()
        {
        }
        public Pawn(PiecesColor pieceColor, List<Directions> directions) : base(pieceColor, directions)
        { 
        }

    }
    
}
