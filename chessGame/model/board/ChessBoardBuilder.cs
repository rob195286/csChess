using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chessGame.model.board
{
    public class ChessBoardBuilder
    {
        private ChessBoard _chessBoard = new ChessBoard();

        public void SetBoard(int rows, List<char> columns)
        {
            _chessBoard.board = new Dictionary<int, List<char>>() { };
            foreach (int rowNumber in Enumerable.Range(1, rows))
                _chessBoard.board.Add(rowNumber, columns);
        }

        public void SetPiecesAtCoord(List<Piece> pieces)
        {
            foreach(Piece p in pieces)
            {
                if(p is Piece)
                {

                }
                //_chessBoard.Add
            }
        }
    }
}
