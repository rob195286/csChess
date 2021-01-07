using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.game
{
    public static class RulesManager
    {
        /// <summary>
        /// Permet de donner le nombre de cases en fonction des directions par lesquelle
        ///     une pièce peut se déplacer.
        /// </summary>
        /// <param name="p"> L'argument p prend une pièce dont il faudra récupérer ses 
        ///     déplacements possibles. </param>
        /// <param name="lengthDimension"> Prend la taille en longueur du board. </param>
        /// <param name="widthDimension"> Prend la taille en largeur du board. </param>
        /// <returns> Retourne un dictionnaire avec pour chaque type de direction (longueur, largeur, horizontal etc)
        ///     la valeur à laquel la pièce peut se déplacer. </returns>
        public static Dictionary<Directions, int> MovesOfPiece(Piece p, 
                                                                int lengthDimension, 
                                                                int widthDimension)
        {
            Dictionary<Directions, int> move = new Dictionary<Directions, int>() { };
            // On enlève 1 car vu qu'on ne compte pas la case sur laquelle la pièce se trouve,
            //  cela donne bien la dimension du board - 1.
            lengthDimension -= 1;
            widthDimension -= 1;
            // todo : switch case
            if (p is King)
            {
                move.Add(Directions.diagonal, 1);
                move.Add(Directions.horizontal, 1);
                move.Add(Directions.vertical, 1);
            }                
            else if (p is Rook)
            {
                move.Add(Directions.horizontal, widthDimension);
                move.Add(Directions.vertical, lengthDimension);
            }
            else if (p is Bishop)
            {
                move.Add(Directions.diagonal, lengthDimension);
            }
            else if (p is Queen)
            {
                move.Add(Directions.diagonal, lengthDimension);
                move.Add(Directions.horizontal, widthDimension);
                move.Add(Directions.vertical, lengthDimension);
            }
            else if (p is Knight)
            {
                move.Add(Directions.horizontal, 1);
                move.Add(Directions.vertical, 2);
            }
            else if (p is Pawn)
            {
                move.Add(Directions.verticalUP, 1);
            }
            return move;
        }

        //public static bool IsPawnCanMoveForSecondTime(Pawn pa) { }
        
        //todo : implémenter les autres règle, roque, promotion, prise en passant.
        
        public static List<Coord> NexLegalMoves(Piece pieceToCheck, Coord currentCoord, int[] boardSize)
        {
            // Le boardSize en 0 est le nombre de ligne, et en 1 le nombre de colonnes.
            for(int i = 0; i < boardSize[0]; i++)
            {
                for (int j = 0; j < boardSize[1]; j++)
                {

                }
            }
            // todo : implémenter une enum avec tous les type de piece pour pas avoir qlq chose d'ardcodé.
            switch (pieceToCheck.getType)
            {
                case "Knight":
                    break;
                case "King":
                    break;
                case "Rook":
                    break;
                case "Queen":
                    break;
                case "Pawn":
                    break;
                case "Bishop":
                    break;
                default:
                    break;
            }

                return null;
        }
    }
}
