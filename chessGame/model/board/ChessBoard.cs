﻿using chessGame.model.board;
using chessGame.model.piece;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chessGame.model
{
    public class ChessBoard
    {
        /// <summary>
        /// Retourne les dimensions du board (lignes et colonnes).
        /// </summary>
        public Dictionary<int, List<char>> board { get; set; }
        /*
        public List<Coord> coordAvailable
        { 
            get 
            {
                List<Coord> coord = new List<Coord>() { };
                foreach (KeyValuePair<int, List<char>> rowsAndColumns in board)
                    foreach (char column in rowsAndColumns.Value)
                        coord.Add(new Coord(rowsAndColumns.Key, column));
                return coord; 
            }
        }*/
        /// <summary>
        /// Retourne un dictinnaire contenant toutes les pièces dans le board,
        ///     avec comme clé les coordonnées et comme valeur la pièce correspondante. 
        /// </summary>
        public Dictionary<Coord, Piece> pieceAtCoord { get; }

        public int getNumberOfPieces { get => pieceAtCoord.Count; }


        public ChessBoard()
        {
            pieceAtCoord = new Dictionary<Coord, Piece>() { };
            board = new Dictionary<int, List<char>>() { };
        }


        private void _IsCoordInBoardRange(Coord c)
        {
            // todo RE : refre ex
            if (c.row > board.Count)
                throw new IndexOutOfRangeException(Texts.coordOutOfRange + c);
            // On regarde si la vaeur de la colonne est supérieur au dernier élément de la liste 
            //    car comme ce sont des char, on a bien une valeur numérique.
            foreach (List<char> column in board.Values)
            {
                if (c.column > column.Last())
                throw new IndexOutOfRangeException(Texts.coordOutOfRange + c);
            }
        }

        private void _ChangeCoordPiece(Coord oldc, Coord newc)
        {
            Piece p = pieceAtCoord[oldc];
            pieceAtCoord.Add(newc, p);
            pieceAtCoord.Remove(oldc);
        }
        
        public void RemovePieceAtCoord(Coord c)
        {
            pieceAtCoord.Remove(c);
        }

        public void AddPiece(Piece p, Coord c)
        {
            // todo RE : cr&er propre except
            _IsCoordInBoardRange(c);
            if(pieceAtCoord.Keys.Contains(c))
                throw new InvalidOperationException(Texts.pieceAlreadyInCase + c);
            p.id = getNumberOfPieces + 1;
            pieceAtCoord.Add(c, p);
        }
        
        public void AddPieces(List<Piece> ps, List<Coord> c)
        {
            int i = 0;
            foreach(Piece p in ps)
                AddPiece(p, c.ElementAt(i++));
        }
        /// <summary>
        /// Regarde dans le board si la pièce passée en paramètre existe.
        /// </summary>
        /// <param name="piece"> Pièce à chercher dans le board. </param>
        /// <returns> Retourne true si elle se trouve dans le board, false sinon. </returns>
        public bool PieceExist(Piece p)
        {
            return pieceAtCoord.ContainsValue(p);
        }
        /// <summary>
        /// Retourne la piece correspondante à l'id donné.
        /// </summary>
        /// <param name="id"> Id de la pièce à rechercher. </param>
        /// <returns> Retourne la pièce trouvé. </returns>
        public Piece GetPieceByID(int id)
        {
            Piece piece = null;
            foreach (Piece p in pieceAtCoord.Values)
            {
                if (p.id == id)
                {
                    piece = p;
                    break;
                }                
            }
            if(piece == null)// todo RE : refaire exception
                throw new IndexOutOfRangeException(Texts.pieceByIDNotFound + id);
            return piece;
        }             
        /// <summary>
        /// Retourne la piece correspondante aux coordonnées donné.
        /// </summary>
        /// <param name="c"> Coordonnées de la pièce à rechercher. </param>
        /// <returns> Retourne la pièce trouvé ou nul si elle n'est pas trouvé. </returns>
        public Piece GetPieceAtCoord(Coord c)
        {
            Piece p = null;
            foreach (Coord coord in pieceAtCoord.Keys)
            {
                if (coord == c)
                {
                    p = pieceAtCoord[coord];
                    break;
                }
            }
            if (p == null)// todo RE : refaire exception
                throw new NullReferenceException(Texts.pieceAtCoordNotFound + c);
            return p;
        }    
        
        public void MovePiece(Coord oldc, Coord newc)
        {
            _IsCoordInBoardRange(oldc);
            _IsCoordInBoardRange(newc);
            _ChangeCoordPiece(oldc, newc);
        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    keys/rows : " + String.Join(", ", board.Keys) + "\n"
                + "    values/columns : " + String.Join(", ",board.Values.ElementAt(0)) + "\n"
                + "    pieceAtCoord : " + String.Join(", ",pieceAtCoord.Values) + "\n"
                + "    coord take : " + String.Join(", ",pieceAtCoord.Keys) + "\n"
                + "    coords available : " + String.Join(" , ", coordAvailable) + "\n";
        }
    }
}
