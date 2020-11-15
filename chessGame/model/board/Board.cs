using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model
{
    public class Board
    {
        
        private List<King> _kings;
        public List<King> kings
        {
            get => _kings;
        }
         
        private List<Rook> _rooks;
        public List<Rook> rooks
        {
            get => _rooks;
        }

        private List<Bishop> _bishops;
        public List<Bishop> bishops
        {
            get => _bishops;
        }

        private List<Queen> _queens;
        public List<Queen> queens
        {
            get => _queens;
        }

        private List<Knight> _knights;
        public List<Knight> knights
        {
            get => _knights;
        }

        private List<Pawn> _pawns;
        public List<Pawn> pawns
        {
            get => _pawns;
        }

       // private Dictionary<int, char>

        // todo : faire en builder dans le controller ou dans une classe
        public Board(List<King> kings,
                     List<Rook> rooks,
                     List<Bishop> bishops,
                     List<Queen> queens,
                     List<Knight> knights,
                     List<Pawn> pawns)
        {
            this._rooks = rooks;
            this._bishops = bishops;
            this._queens = queens;
            this._knights = knights;
            this._pawns = pawns;
        }

        public void MovePiece(Dictionary<int, char> pieceCoord)
        {

        }

        public Dictionary<string, string> GetPiece()
        {
            // todo : voir si utile
            Dictionary<string, string> x = new Dictionary<string, string>();
            return x;
        }

        public override string ToString()
        {
            return base.ToString() 
                + "Piece in game : \n"
                + "     kings" + _kings
                + "     rooks" + _rooks
                + "     bishops" + _bishops
                + "     queens" + _queens
                + "     knights" + _knights
                + "     pawns" + _pawns;
        }
    }
}
