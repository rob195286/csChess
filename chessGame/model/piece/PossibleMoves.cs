using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model.piece
{
    // todo : enlever si inutile
    /*
    public class PossibleMoves
    {
        public Dictionary<Directions, int> moves { get; }


        public PossibleMoves(Directions directionMoves, int numberOfCases) : 
            this(new Dictionary<Directions, int>() { { directionMoves, numberOfCases } })
        {
        }
        public PossibleMoves(Dictionary<Directions, int> dictMoves)
        {
            moves = new Dictionary<Directions, int>();
            foreach (KeyValuePair<Directions, int> kvp in dictMoves)
                moves.Add(kvp.Key, kvp.Value);
        }  

        public override string ToString()
        {
            return ""+String.Join(", ", moves);
        }
    }*/
}
