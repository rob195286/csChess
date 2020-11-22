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

        /// <summary>
        /// Initialise le board concernant les colonnes et les lignes.
        /// </summary>
        /// <param name="rows"> Nombre de lignes qu'aura le board. </param>
        /// <param name="columns"> Nombre de colonnes qu'aura le board. </param>
        public void SetBoard(int rows, List<char> columns)
        {
            foreach (int rowNumber in Enumerable.Range(1, rows))
                _chessBoard.board.Add(rowNumber, columns);
        }

        /// <summary>
        /// Fonction permettant de mettre les pièces dans le board pour un joueur,
        ///     l'autre coté du board sera dupliqué par rapport à celui étant créé.
        /// </summary>
        /// <param name="pieces"> Pièce à placer sur le board. </param>
        /// <param name="coord"> Coordonnées où placée les pièces. </param>
        public void SetPieceAtCoord(Piece piece, Coord coord)
        {
            // todo : faire une except au cas ou on mettrais des pièces de couleurs différentes
            _chessBoard.AddPieces(piece, coord);
        }
        
        /// <summary>
        /// Configure le board comme le jeu officiel. Les lignes et colonnes sont au nombres de 8,
        ///     le nimbre de pièces est de 2x8 etc..
        /// </summary>
        public void SetDefaultBoard()
        {
            List<char> defaultColumn = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            PiecesColor piecesColor = PiecesColor.white;
            Player player = new Player(1, piecesColor);
            SetBoard(8, defaultColumn);
            King kingW = new King();
            Rook RookW = new Rook();

            List<Piece> pieces = new List<Piece>() { };
            Coord coord = new Coord();
            char column = 'x';
            int i = 0;

            foreach (Piece piece in pieces)
            {
                if(piece is Pawn)
                {
                    column = defaultColumn.ElementAt(i);
                    coord = new Coord(2, column);
                    _chessBoard.AddPieces(piece, coord);
                }
                //_chessBoard.AddPieces(piece, coord);

            }
        }

        public ChessBoard GetChessBoard()
        {
            return _chessBoard;
        }
    }
}
