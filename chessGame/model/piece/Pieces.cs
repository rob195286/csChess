using chessGame.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public class King : Piece
    {
        public King(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public King(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.king;
        }
    }

    public class Queen : Piece
    {
        public Queen(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public Queen(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.queen;
        }
    }

    public class Rook : Piece
    {
        public Rook(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public Rook(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.Rook;
        }
    }

    public class Bishop : Piece
    {
        public Bishop(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public Bishop(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.bishop;
        }
    }

    public class Knight : Piece
    {
        public Knight(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public Knight(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.knight;
        }
    }

    public class Pawn : Piece
    {
        public Pawn(int id) : this(id, PiecesColor.white, new Player(0, PiecesColor.white))
        {
        }
        public Pawn(int id, PiecesColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.pawn;
        }
    }
}
