using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model.board
{
    public class Coord
    {
        public int row { get; set; }

        public char column { get; set; }


        public Coord():this(0 , '?')
        {
        }
        public Coord(int row, char column)
        {
            this.row = row;
            this.column = column;
        }


        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (!(obj is Coord))
                return isEqual;

            Coord c = (Coord)obj;

            if (row == c.row && this.GetType() == c.GetType() && column == c.column)
                isEqual = true;

            return isEqual;
        }

        public static bool operator ==(Coord x, Coord y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Coord x, Coord y)
        {
            return !(x.Equals(y));
        }

        public override string ToString()
        {
            return string.Format(" [{0}{1}]",row, column);
        }

        public override int GetHashCode()
        {
            return row.GetHashCode() + column.GetHashCode();
        }
    }
}
