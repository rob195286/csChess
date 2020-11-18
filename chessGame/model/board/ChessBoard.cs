using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chessGame.model
{
    // todo : demander si on peut faire une classe static avec une fonction reset pour faire une nouvelle partie.
    public class ChessBoard
    {
        private Dictionary<int, List<char>> _board;
        public Dictionary<int, List<char>> board { get => _board; set => _board = value; }

        private List<Coord> _coordAvailable;
        //public List<Coord> coordAvailable { get => _coordAvailable; }

        private Dictionary<Piece, Coord> _pieces;
        public Dictionary<Piece, Coord> pieces { get => _pieces; }


        // todo : faire en builder dans le controller ou dans une classe
/*public ChessBoard(List<King> kings,
             List<Rook> rooks,
             List<Bishop> bishops,
             List<Queen> queens,
             List<Knight> knights,
             List<Pawn> pawns,
             List<int> rows,
             List<char> columns)*/
        public ChessBoard():this(5, new List<char>() { 'r' })
        {
            //todo : virer l('autre
        }
        public ChessBoard(int rows, List<char> columns)
        {
            _pieces = new Dictionary<Piece, Coord>() { };
            //InitBoard(rows, columns);
            InitCoordAvailable();
        }

        private void InitBoard(int rows, List<char> columns)
        {
            // todo : virer si inutile
            _board = new Dictionary<int, List<char>>() { };
            foreach (int rowNumber in Enumerable.Range(1, rows))
                board.Add(rowNumber, columns);
        }

        private void InitCoordAvailable()
        {
            // todo : en faire une fonction qui renvois les coord dynamiquement, enlever var.
            _coordAvailable = new List<Coord>() { };
            foreach(KeyValuePair<int, List<char>> rowsAndColumns in _board)
                foreach(char column in rowsAndColumns.Value)
                    _coordAvailable.Add(new Coord(rowsAndColumns.Key, column));
        }

        public void AddPieces(Piece piece, Coord coord)
        {
            // todo : faire erreur lorsqu'on ajoute une pièce à un mauvais endroit
            _pieces.Add(piece, coord);
            _coordAvailable.Remove(coord);
        }

        public void MovePiece(Dictionary<int, char> pieceCoord)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    keys/rows : " + String.Join(", ", _board.Keys) + "\n"
                + "    values/columns : " + String.Join(", ",_board.Values.ElementAt(0)) + "\n"
                + "    values/columns : " + String.Join(", ",_board.Values.ElementAt(0)) + "\n"
                + "    coords available : " + String.Join(" , ", _coordAvailable) + "\n";
        }
    }
}
