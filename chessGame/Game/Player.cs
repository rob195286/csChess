using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model
{
    public class Player
    {
        private int _id;
        public int id { get => _id; }

        private PiecesColor _piecesColor;
        public PiecesColor PiecesColor { get => _piecesColor; }

        //private List<Piece> _pieces;
        //public List<Piece> Pieces { get => _pieces; set => _pieces = value; }


        public Player(int id, PiecesColor piecesColor) //: this(id, piecesColor, new List<Piece>() { })
        {
            _id = id;
            _piecesColor = piecesColor;
        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    id : " + _id
                + "    pieces color : " + _piecesColor;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Player))
                return false;

            Player player = (Player)obj;

            if (_id == player.id && _piecesColor == player._piecesColor)
                isEqual = true;

            return isEqual;
        }

        public static bool operator ==(Player x, Player y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Player x, Player y)
        {
            return !(x.Equals(y));
        }
    }
}
