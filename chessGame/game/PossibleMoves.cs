using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model.piece
{
    public class PossibleMoves
    {
        public Dictionary<EDirections, int> moves { get; }


        public PossibleMoves(EDirections directionMoves, int numberOfCases) : 
            this(new Dictionary<EDirections, int>() { { directionMoves, numberOfCases } })
        {
        }
        public PossibleMoves(Dictionary<EDirections, int> dictMoves)
        {
            moves = new Dictionary<EDirections, int>();
            foreach (KeyValuePair<EDirections, int> kvp in dictMoves)
                moves.Add(kvp.Key, kvp.Value);
        }


        public bool HasDirection(EDirections directionToFind) 
        {
            bool hasDirection = false;
            foreach (EDirections direction in moves.Keys)
                if (direction == directionToFind)
                {
                    hasDirection = true;
                    break;
                }
            return hasDirection;
        }

        public override string ToString()
        {
            return ""+String.Join(", ", moves);
        }
    }

    public enum EDirections
    {
        diagonal,
        horizontal,
        vertical
    }
}
