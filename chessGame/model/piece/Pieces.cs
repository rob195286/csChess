using chessGame.model;
using chessGame.model.piece;
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
        public King(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                    { { Directions.horizontal, 1 },
                                                    { Directions.vertical, 1 },
                                                    { Directions.diagonal, 1 } };
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.horizontal, 
                                                   Directions.vertical,
                                                   Directions.diagonal};
        }

    }
    
    public class Queen : Piece
    {
        public Queen() : base()
        {
        }
        public Queen(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                    { { Directions.horizontal, 0 },
                                                    { Directions.vertical, 0 },
                                                    { Directions.diagonal, 0 } };
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.horizontal,
                                                   Directions.vertical,
                                                   Directions.diagonal};
        }

    }

    public class Rook : Piece
    {
        public Rook() : base()
        {
        }
        public Rook(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                    { { Directions.horizontal, 0 },
                                                    { Directions.vertical, 0 } };
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.horizontal,
                                                   Directions.vertical};
        }

    }

    public class Bishop : Piece
    {
        public Bishop() : base()
        {
        }
        public Bishop(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                     { { Directions.diagonal, 0} };
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.diagonal };
        }

    }

    public class Knight : Piece
    {
        public Knight() : base()
        {
        }
        public Knight(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                    { { Directions.horizontal, 1 },
                                                    { Directions.vertical, 2 }};
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.horizontal,
                                                   Directions.vertical };
        }


    }

    public class Pawn : Piece
    {
        public Pawn() : base()
        {
        }
        public Pawn(PiecesColor pieceColor) : base(pieceColor)
        {/*
            Dictionary<Directions, int> tempDic = new Dictionary<Directions, int>()
                                                    { { Directions.horizontal, 1 } };
            this._possibleMoves = new PossibleMoves(tempDic);*/
            this._moves = new List<Directions>() { Directions.verticalFront };
        }

    }
    
}
