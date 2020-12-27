using chessGame.model.board;
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
        }
        /// <summary>
        /// Retourne un dictinnaire contenant toutes les pièces dans le board,
        ///     avec comme clé les coordonnées et comme valeur la pièce correspondante. 
        /// </summary>
        public Dictionary<Coord, Piece> pieces { get; }

        public int getNumberOfPieces { get => pieces.Count; }


        public ChessBoard()
        {
            pieces = new Dictionary<Coord, Piece>() { };
            board = new Dictionary<int, List<char>>() { };
        }


        private void _ChangeCoordPiece(Piece p, Coord newc)
        {
            foreach(KeyValuePair<Coord, Piece> kv in pieces)
            {
                if(kv.Value == p)
                {
                    pieces.Remove(kv.Key);
                    pieces.Add(newc, p);
                    break;
                }
            }
        }

        public void AddPiece(Piece p, Coord c)
        {
            // todo : faire erreur lorsqu'on ajoute une pièce à un mauvais endroit
            p.id = getNumberOfPieces + 1;
            //if(piece not in _pieces.)
                pieces.Add(c, p);
        }
        
        public void AddPieces(List<Piece> pieces, List<Coord> c)
        {
            int i = 0;
            foreach(Piece p in pieces)
                AddPiece(p, c.ElementAt(i++));
        }
        /// <summary>
        /// Regarde dans le board si la pièce passée en paramètre existe.
        /// </summary>
        /// <param name="piece"> Pièce à chercher dans le board. </param>
        /// <returns> Retourne true si elle se trouve dans le board, false sinon. </returns>
        public bool PieceExist(Piece p)
        {
            return pieces.ContainsValue(p);
        }
        /// <summary>
        /// Retourne la piece correspondante à l'id donné.
        /// </summary>
        /// <param name="id"> Id de la pièce à rechercher. </param>
        /// <returns> Retourne la pièce trouvé. </returns>
        public Piece GetPieceByID(int id)
        {
            Piece piece = null;
            foreach (Piece p in pieces.Values)
            {
                if (p.id == id)
                {
                    piece = p;
                    break;
                }
                // todo : implémenter une exception
            }
            return piece;
        }             
        /// <summary>
        /// Retourne la piece correspondante aux coordonnées donné.
        /// </summary>
        /// <param name="c"> Coordonnées de la pièce à rechercher. </param>
        /// <returns> Retourne la pièce trouvé ou nul si elle n'est pas trouvé. </returns>
        public Piece GetPieceAtCoord(Coord c)
        {
            Piece piece = null;
            foreach (Coord coord in pieces.Keys)
            {
                if (coord == c)
                {
                    piece = pieces[coord];
                    break;
                }
                 // todo : implémenter une exception dans le cas ou sa trouea pas
            }
            return piece;
        }    
        
        public void MovePiece(Piece p, Coord newc)
        {
            // todo : except
            _ChangeCoordPiece(p, newc);
        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    keys/rows : " + String.Join(", ", board.Keys) + "\n"
                + "    values/columns : " + String.Join(", ",board.Values.ElementAt(0)) + "\n"
                + "    pieces : " + String.Join(", ",pieces.Values) + "\n"
                + "    coord take : " + String.Join(", ",pieces.Keys) + "\n"
                + "    coords available : " + String.Join(" , ", coordAvailable) + "\n";
        }
    }
}
