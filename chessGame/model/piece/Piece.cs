﻿using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces
{
    public enum PieceType
    {
        king,
        Rook,
        bishop,
        queen,
        knight,
        pawn
    }

    public enum PieceColor
    {
        white,
        black
    }

    public enum Player
    {
        one,
        two
    }

    public abstract class Piece
    {
        protected int _id;
        public int id
        {
            get => _id;
        }

        protected PieceType _pieceType;
        public virtual PieceType pieceType
        {
            get => _pieceType;
        }

        protected PieceColor _pieceColor;
        public virtual PieceColor pieceColor
        {
            get => _pieceColor;
        }

        protected Player _player;
        public virtual Player player
        {
            get => _player;
        }

        // todo : implement move in piece
        //private Moves _moves;
        //private Moves _moves;

        protected Piece(int id, PieceColor pieceColor, Player player)
        {
            _id = id;
            _pieceColor = pieceColor;
            _player = player;
        }

        //public abstract 

        public override string ToString()
        {
            return base.ToString()
                + "id" + _id
                + "Piece Type" + _pieceType
                + "Piece Color" + _pieceColor
                + "Player" + _player;
        }
    }
}