using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model
{
    public class Player
    {
        public int id { get; }

        public PiecesColor piecesColor { get; }


        public Player(int id, PiecesColor piecesColor)
        {
            this.id = id;
            this.piecesColor = piecesColor;
        }


        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    id : " + id
                + "    getAllPiecesAtCoord color : " + piecesColor;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Player))
                return false;

            Player player = (Player)obj;

            if (id == player.id && piecesColor == player.piecesColor)
                isEqual = true;

            return isEqual;
        }

        public override int GetHashCode()
        {
            int hashCode = 1821491413;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + piecesColor.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Player x, Player y)
        {
            if (object.ReferenceEquals(x, null))
                return object.ReferenceEquals(y, null);
            return x.Equals(y);
        }

        public static bool operator !=(Player x, Player y)
        {
            if (!object.ReferenceEquals(x, null))
                return !object.ReferenceEquals(y, null);
            return !(x.Equals(y));
        }
    }
}
