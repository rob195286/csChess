using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public class King : Piece
    {
        public King(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public King(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.king;
        }
    }

    public class Queen : Piece
    {
        public Queen(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public Queen(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.queen;
        }
    }

    public class Rook : Piece
    {
        public Rook(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public Rook(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.Rook;
        }
    }

    public class Bishop : Piece
    {
        public Bishop(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public Bishop(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.bishop;
        }
    }

    public class Knight : Piece
    {
        public Knight(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public Knight(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.knight;
        }
    }

    public class Pawn : Piece
    {
        public Pawn(int id) : this(id, PieceColor.white, Player.one)
        {
        }
        public Pawn(int id, PieceColor pieceColor, Player player) : base(id, pieceColor, player)
        {
            this._pieceType = PieceType.pawn;
        }
    }
}
