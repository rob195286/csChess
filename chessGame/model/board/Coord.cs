using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model.board
{
    public class Coord
    {
        private int _row;
        public int Row { get => _row; set => _row = value; }

        private char _column;
        public char Column { get => _column; set => _column = value; }


        public Coord():this(0 , ' ')
        {
        }
        public Coord(int row, char column)
        {
            _row = row;
            _column = column;
        }

        public override string ToString()
        {
            return base.ToString()+" "+string.Format("[{0},{1}]",_row, _column);
        }
    }
}
