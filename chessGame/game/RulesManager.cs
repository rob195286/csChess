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
        public static Dictionary<Directions, int> GetPieceMove(Piece p, 
                                                                int lengthDimension, 
                                                                int widthDimension)
        {
            Dictionary<Directions, int> casesNumber = new Dictionary<Directions, int>() { };
            // On enlève 1 car vu qu'on ne compte pas la case sur laquelle la pièce se trouve,
            //  cela donne bien la dimension du board - 1.
            lengthDimension -= 1;
            widthDimension -= 1;

            if (p is King)
            {
                casesNumber.Add(Directions.diagonal, 1);
                casesNumber.Add(Directions.horizontal, 1);
                casesNumber.Add(Directions.vertical, 1);
            }                
            else if (p is Rook)
            {
                casesNumber.Add(Directions.horizontal, widthDimension);
                casesNumber.Add(Directions.vertical, lengthDimension);
            }
            else if (p is Bishop)
            {
                casesNumber.Add(Directions.diagonal, lengthDimension);
            }
            else if (p is Queen)
            {
                casesNumber.Add(Directions.diagonal, lengthDimension);
                casesNumber.Add(Directions.horizontal, widthDimension);
                casesNumber.Add(Directions.vertical, lengthDimension);
            }
            else if (p is King)
            {
                casesNumber.Add(Directions.horizontal, 1);
                casesNumber.Add(Directions.vertical, 2);
            }
            else if (p is King)
            {
                casesNumber.Add(Directions.verticalFront, 1);
            }
            return casesNumber;
        }
    }
}
