using chessGame.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chessGame.pieces
{
    public enum PiecesColor
    {
        white,
        black
    }
    /// <summary>
    /// Contient toutes les directions que peuvent avoir les pieceAtCoord.
    /// </summary>
    public enum Directions
    {
        diagonal,
        diagonalUP,
        horizontal,
        vertical,
        verticalUP,
        verticalDOWN
    }

    public abstract class Piece
    {
        public List<Directions> moves { get; }
        public int id { get; set; }
        public PiecesColor color { get; }


        protected Piece() : this(PiecesColor.white, new List<Directions>() {})
        {
        }
        protected Piece(PiecesColor pieceColor, List<Directions> directions)
        {
            this.id = 0;
            this.color = pieceColor;
            this.moves = directions;
        }


        /// <summary>
        /// Check si la pièce contient la direction fournise en argument.
        /// </summary>
        /// <param name="direction"> Direction qu'il faut checker. </param>
        /// <returns> Retourne true s'il elle si trouve, false sinon. </returns>
        public bool HasDirection(Directions direction)
        {
            return this.moves.Contains(direction);
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Piece))
                return isEqual;

            Piece p = (Piece)obj;

            if (id == p.id && 
                        this.GetType() == p.GetType() &&
                        color == p.color &&
                        Enumerable.SequenceEqual(moves, p.moves))
                isEqual = true;

            return isEqual;
        }

        public static bool operator ==(Piece x, Piece y)
        {
            if (object.ReferenceEquals(x, null))
                return object.ReferenceEquals(y, null);
            return x.Equals(y);
        }

        public static bool operator !=(Piece x, Piece y)
        {
            if (!object.ReferenceEquals(x, null))
                return !object.ReferenceEquals(y, null);
            return !(x.Equals(y));
        }

        public override string ToString()
        {
            return "Piece : \n"
                + "   id : " + this.id
                + "\n   Type : " + this.GetType()
                + "\n   Color : " + this.color
                + "\n   directions : " + String.Join(", ", this.moves);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(moves, id, color);
        }
    }
}
