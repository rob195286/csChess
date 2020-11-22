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
        public void SetDimensions(int rows, List<char> columns)
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
        /// Configure le board comme le jeu de base. Les lignes et colonnes sont au nombres de 8,
        ///     le nimbre de pièces est de 2x8 etc..
        /// </summary>
        public void SetDefaultBoard()
        {
            List<char> defaultColumn = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            SetDimensions(8, defaultColumn);
            King kingW = new King();
            Rook rookW = new Rook();
            Bishop bishopW = new Bishop();
            Queen queenW = new Queen();
            Knight knightW = new Knight();
            Pawn pawnW = new Pawn();


            SetPieceAtCoord(kingW, new Coord(1, 'e'));

            SetPieceAtCoord(rookW, new Coord(1, 'a'));
            SetPieceAtCoord(rookW, new Coord(1, 'h'));
            
            SetPieceAtCoord(bishopW, new Coord(1, 'c'));
            SetPieceAtCoord(bishopW, new Coord(1, 'f'));

            SetPieceAtCoord(queenW, new Coord(1, 'd'));

            SetPieceAtCoord(knightW, new Coord(1, 'b'));
            SetPieceAtCoord(knightW, new Coord(1, 'g'));

            for (int i = 0; i<8; i++)
                SetPieceAtCoord(pawnW, new Coord(2, defaultColumn.ElementAt(i)));

            CopySide();
        }

        public void CopySide()
        {
            int i = 0;
            int distance = 0;
            int min = 0;
            foreach(KeyValuePair<Piece, Coord> pieceNcoord in _chessBoard.pieces)
            {
                min = _chessBoard.board.Count - pieceNcoord.Value.Row;
                //if (_chessBoard.board.Count - pieceNcoord.Value.Row > _chessBoard.board.Count / 2)
                    //distance = min;
                //else
                    //distance = 0;

                SetPieceAtCoord(pieceNcoord.Key, new Coord(min, pieceNcoord.Value.Column));
            }
        }

        public ChessBoard GetChessBoard()
        {
            return _chessBoard;
        }
    }
}
