using chessGame.model.board;
using chessGame.model.piece;
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

        public List<Coord> coordAvailable
        { 
            get 
            {
                List<Coord> coord = new List<Coord>() { };
                foreach (KeyValuePair<int, List<char>> rowsAndColumns in _board)
                    foreach (char column in rowsAndColumns.Value)
                        coord.Add(new Coord(rowsAndColumns.Key, column));
                return coord; 
            }
        }

        private Dictionary<Piece, Coord> _pieces;
        public Dictionary<Piece, Coord> pieces { get => _pieces; }

        public int getNumberOfPieces { get => _pieces.Count; }


        public ChessBoard()
        {
            _pieces = new Dictionary<Piece, Coord>() { };
            _board = new Dictionary<int, List<char>>() { };
        }


        private void ChangeCoordPiece(Piece piece)
        {
            // todo : finnir
        }

        public void AddPieces(Piece piece, Coord coord)
        {
            // todo : faire erreur lorsqu'on ajoute une pièce à un mauvais endroit
            piece.id = getNumberOfPieces + 1;
            //if(piece in _pieces.)
                _pieces.Add(piece, coord);
            //coordAvailable.Remove(coord);
        }
        
        public void AddPieces(List<Piece> pieces, List<Coord> coord)
        {
            int i = 0;
            foreach(Piece p in pieces)
                AddPieces(p, coord.ElementAt(i++));
        }

        public Piece GetPieceByID(int id)
        {
            Piece piece = null;
            foreach (Piece p in _pieces.Keys)
            {
                if (p.id == id)
                    piece = p;
                else // todo : implémenter une exception
                    piece = null;
            }
            return piece;
        }    
        
        public void MovePiece(Piece piece, Move move)
        {
            // todo : finnir
            // ChangeCoordPiece()
        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    keys/rows : " + String.Join(", ", _board.Keys) + "\n"
                + "    values/columns : " + String.Join(", ",_board.Values.ElementAt(0)) + "\n"
                + "    values/columns : " + String.Join(", ",_board.Values.ElementAt(0)) + "\n"
                + "    coords available : " + String.Join(" , ", coordAvailable) + "\n";
        }
    }
}
