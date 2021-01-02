using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace chessGame.model.board
{
    public class ChessBoardBuilder : IChessBoardBuilder
    {
        private ChessBoard _chessBoard;

        public ChessBoardBuilder()
        {
            _chessBoard = new ChessBoard();
        }

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
            _chessBoard.AddPiece(piece, coord);
        }

        public ChessBoard GetChessBoard()
        {
            return _chessBoard;
        }
    }

    public class ChessBoardDirector
    {
        /// <summary>
        /// Configure le board comme le jeu de base. Les lignes et colonnes sont au nombres de 8,
        ///     le nimbre de pièces est de 2x8 etc..
        /// </summary>
        public void ConstructDefaultChessBoard(IChessBoardBuilder chessBoardBuilder)
        {
            // todo : voir MemberwiseClone pour la copie automatique
            //          ou créer un objet pour faire la conversion de type
            List<char> defaultColumn = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            chessBoardBuilder.SetDimensions(8, defaultColumn);
            //---------------------------------------------------------------- set pieces
            chessBoardBuilder.SetPieceAtCoord(new King(), new Coord(1, 'e'));

            chessBoardBuilder.SetPieceAtCoord(new Rook(), new Coord(1, 'a'));
            chessBoardBuilder.SetPieceAtCoord(new Rook(), new Coord(1, 'h'));

            chessBoardBuilder.SetPieceAtCoord(new Bishop(), new Coord(1, 'c'));
            chessBoardBuilder.SetPieceAtCoord(new Bishop(), new Coord(1, 'f'));

            chessBoardBuilder.SetPieceAtCoord(new Queen(), new Coord(1, 'd'));

            chessBoardBuilder.SetPieceAtCoord(new Knight(), new Coord(1, 'b'));
            chessBoardBuilder.SetPieceAtCoord(new Knight(), new Coord(1, 'g'));

            for (int i = 0; i < 8; i++)
                chessBoardBuilder.SetPieceAtCoord(new Pawn(), new Coord(2, defaultColumn.ElementAt(i)));
            //----------------------------------------------------------------------------------------------

            chessBoardBuilder.SetPieceAtCoord(new King(PiecesColor.black), new Coord(8, 'e'));

            chessBoardBuilder.SetPieceAtCoord(new Rook(PiecesColor.black), new Coord(8, 'a'));
            chessBoardBuilder.SetPieceAtCoord(new Rook(PiecesColor.black), new Coord(8, 'h'));

            chessBoardBuilder.SetPieceAtCoord(new Bishop(PiecesColor.black), new Coord(8, 'c'));
            chessBoardBuilder.SetPieceAtCoord(new Bishop(PiecesColor.black), new Coord(8, 'f'));

            chessBoardBuilder.SetPieceAtCoord(new Queen(PiecesColor.black), new Coord(8, 'd'));

            chessBoardBuilder.SetPieceAtCoord(new Knight(PiecesColor.black), new Coord(8, 'b'));
            chessBoardBuilder.SetPieceAtCoord(new Knight(PiecesColor.black), new Coord(8, 'g'));

            // todo : inverser l'endroit du board ou on les met
            for (int i = 0; i < 8; i++)
                chessBoardBuilder.SetPieceAtCoord(new Pawn(PiecesColor.black), new Coord(7, defaultColumn.ElementAt(i)));
        }
    }

    public interface IChessBoardBuilder
    {
        void SetDimensions(int rows, List<char> columns);
        void SetPieceAtCoord(Piece piece, Coord coord);
        ChessBoard GetChessBoard();
    }
}
