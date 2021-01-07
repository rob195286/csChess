using System.Collections.Generic;
using System.Linq;

namespace chess_game.utils
{
    public static class ChessConverter
    {
        /// <summary>
        /// Permet de convertire un numéro de colonne sous forme d'entier en un char qui exist dans
        ///     une liste de char donnée.
        /// </summary>
        /// <param name="columnInt"> Numéro sous forme d'int de la colonne que l'on veut convertir. </param>
        /// <param name="listOfCharColumn"> Liste de char dans laquelle on veut convertir l'entier en entrée. </param>
        /// <returns> Retourne le char qui est le résultat converti de l'entier fournit en entrée. </returns>
        public static char IntToCharColumnConverter(int columnInt, List<char> listOfCharColumn)
        {
            return listOfCharColumn.ElementAt(columnInt);
        }
    }
}
