using chessGame.game;
using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace chessGame.model
{
    public class ChessBoard
    {
        /// <summary>
        /// Retourne les dimensions du board (lignes et colonnes).
        /// </summary>
        public Dictionary<int, List<char>> board { get; set; }
        /// <summary>
        /// Obtiens la taille du board, le nombre de ligne en premier et les colonnes en second.
        /// </summary>
        public int[] getSize
        {
            get
            {
                // todo : faire en sorte que ca renvois des nombres pour chaque colonne et que ca tienne 
                //          compte d'une taille dynamqiue.
                int[] arr = new int[2] { board.Count, board.First().Value.Count };
                return arr;
            }
        }
        /// <summary>
        /// Retourne un dictinnaire contenant toutes les pièces dans le board,
        ///     avec comme clé les coordonnées et comme valeur la pièce correspondante. 
        /// </summary>
        public Dictionary<Coord, Piece> getPiecesFromCoord { get; }
        public List<Piece> getPieces { get => getPiecesFromCoord.Select(getPieceAtCoord => getPieceAtCoord.Value).ToList(); }
        public int getNumberOfPieces { get => getPiecesFromCoord.Count; }
        /// <summary>
        /// Retourne une liste de toutes les coordonnées se trouvant dans le board.
        /// </summary>
        public List<Coord> getCoord
        {
            get
            {
                List<Coord> tempCoordL = new List<Coord>() { };
                foreach (KeyValuePair<int, List<char>> rowColumnPair in board)
                {
                    foreach (char column in rowColumnPair.Value)
                    {
                        tempCoordL.Add(new Coord(rowColumnPair.Key, column));
                    }
                }
                return tempCoordL;
            }
        }
        /// <summary>
        /// Retourne une liste de toutes les coordonnées occupé par une pièces.
        /// </summary>
        public List<Coord> getOccupiedCoord { get => getPiecesFromCoord.Select(getPieceAtCoord => getPieceAtCoord.Key).ToList(); }


        public ChessBoard()
        {
            getPiecesFromCoord = new Dictionary<Coord, Piece>() { };
            board = new Dictionary<int, List<char>>() { };
        }

        /// <summary>
        /// Vérifie que la coordonnée passé en paramètre est valide par rapport au board construit.
        /// </summary>
        /// <param name="c"> Coordonée à vérifier. </param>
        private void _AreCoordInBoardRange(Coord c)
        {
            // todo RE : refre ex
            if (c.row > board.Count)
                throw new IndexOutOfRangeException(Texts.coordOutOfRange + c);
            // On regarde si la valeur de la colonne appartenant à la coordoonées
            //      passé en paramètre se trouve dans une des colonnes dans le board
            //      à la ligne données.
            List<char> columnsAtRow = board[c.row];
            if (!columnsAtRow.Contains(c.column))
                throw new IndexOutOfRangeException(Texts.coordOutOfRange + c);
        }

        private void _ChangeCoordPiece(Coord oldc, Coord newc)
        {
            Piece p = getPiecesFromCoord[oldc];
            getPiecesFromCoord.Add(newc, p);
            getPiecesFromCoord.Remove(oldc);
        }

        public bool RemovePieceAtCoord(Coord c)
        {
            bool flag = false;
            if (getPiecesFromCoord.ContainsKey(c))
            {
                getPiecesFromCoord.Remove(c);
                flag = true;
            }
            return flag;
        }

        public void AddPiece(Piece p, Coord c)
        {
            // todo RE : cr&er propre except
            _AreCoordInBoardRange(c);
            // Si on ajoute une pièce à une coordoonnée qui existe déja, alors une exception se lève.
            if (getPiecesFromCoord.Keys.Contains(c))
                throw new InvalidOperationException(Texts.pieceAlreadyInCase + c);
            p.id = getNumberOfPieces + 1;
            getPiecesFromCoord.Add(c, p);
        }
        /// <summary>
        /// Ajoute des coordonnées et des pièces dans le board. La fonction prend
        ///     par ordre chaque clé, encommencant par la première de chacune des listes 
        ///     pour ajouter une pièece à une coordoonée dans le board.
        /// </summary>
        /// <param name="ps"> Liste de pièces. </param>
        /// <param name="c"> Liste de coordonnées. </param>
        public void AddPieces(List<Coord> c, List<Piece> ps)
        {
            int i = 0;
            foreach (Piece p in ps)
                AddPiece(p, c.ElementAt(i++));
        }
        /// <summary>
        /// Regarde dans le board si la pièce passée en paramètre existe.
        /// </summary>
        /// <param name="piece"> Pièce à chercher dans le board. </param>
        /// <returns> Retourne true si elle se trouve dans le board, false sinon. </returns>
        /// <summary>
        /// Retourne la piece correspondante à l'id donné.
        /// </summary>
        /// <param name="id"> Id de la pièce à rechercher. </param>
        /// <returns> Retourne la pièce trouvé. </returns>
        public Piece GetPieceByID(int id)
        {
            Piece piece = null;
            foreach (Piece p in getPiecesFromCoord.Values)
            {
                if (p.id == id)
                {
                    piece = p;
                    break;
                }
            }
            if (piece == null)// todo RE : refaire exception
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
            foreach (Coord coord in getPiecesFromCoord.Keys)
            {
                if (coord == c)
                {
                    p = getPiecesFromCoord[coord];
                    break;
                }
            }
            if (p == null)// todo RE : refaire exception
                throw new NullReferenceException(Texts.pieceAtCoordNotFound + c);
            return p;
        }
        public bool PieceExist(Piece p)
        {
            return getPiecesFromCoord.ContainsValue(p);
        }
        /// <summary>
        /// Déplace une pièce d'une ancienne coordonnées à de nouvelle.
        /// </summary>
        /// <param name="oldc"> Prend les premières coordonnées. </param>
        /// <param name="newc"> Prend les secondes coordonnées. </param>
        public void MovePiece(Coord oldc, Coord newc)
        {
            _AreCoordInBoardRange(oldc);
            _AreCoordInBoardRange(newc);
            _ChangeCoordPiece(oldc, newc);
        }
        /// <summary>
        /// Cette fonction se charge de récupérer toutes les colonnes à une ligne données.
        /// </summary>
        /// <param name="row"> Ligne à laquelle on veut récupérer les colonnes. </param>
        /// <returns> Retourne la liste de colonnes à la ligne données. </returns>
        public List<char> GetColumnsAtRow(int row)
        {
            // todo : except lorsqu'il ne la trouve pas
            return board[row];
        }
        /// <summary>
        /// Fonction permettant de retourner une list de coordonées possible en fonction de l'endroit ou elle se trouve
        ///     et du type de la pièce.
        /// </summary>
        /// <param name="p"> Pièce dont il faut checker les movements possible. </param>
        /// <param name="c"> Coordonnées où se trouve la pièce. </param>
        /// <returns> Retourne une liste de coordonnées ou la pièce peut se déplacer. </returns>
        public List<Coord> LegalMoves(Piece p, Coord c)
        {
            List<Coord> coordList = new List<Coord>() { };
            Dictionary<Directions, int> moves = RulesManager.PossibleMovesOfPiece(p, getSize[0], getSize[1]);

            foreach (KeyValuePair<Directions, int> move in moves)
            {
                for (int row = 1; row <= move.Value; row++)
                {
                    //coordList.Add(new Coord(row, ));
                }
            }
            return coordList;
        }

        public override string ToString()
        {
            return base.ToString() + " : \n"
                + "    keys/rows : " + String.Join(", ", board.Keys) + "\n"
                + "    values/columns : " + String.Join(", ", board.Values.ElementAt(0)) + "\n"
                + "    getPiecesFromCoord : " + String.Join(", ", getPiecesFromCoord.Values) + "\n"
                + "    coord take : " + String.Join(", ", getPiecesFromCoord.Keys) + "\n";
        }
    }
}
