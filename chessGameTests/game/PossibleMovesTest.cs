using chessGame.model.piece;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace chessGame.model.piece.Tests
{
    [TestClass()]
    public class PossibleMovesTest
    {
        // todo : enelver si inutile
        //PossibleMoves moves;
       // PossibleMoves movesL;

        [TestInitialize()]
        public void testsInitialize()
        {
            //moves = new PossibleMoves(Directions.diagonal, 2);
            //movesL = new PossibleMoves(new Dictionary<Directions, int>() { { Directions.horizontal, 5 }, { Directions.vertical, 1 } });
        }

        [TestMethod()]
        public void HasDirectionTest()
        {
            //Assert.AreEqual(true, moves.HasDirection(Directions.diagonal));
            //Assert.AreEqual(false, moves.HasDirection(Directions.vertical));
        }

        [TestMethod()]
        public void CreationMoveTest()
        {
            //Assert.AreEqual(2, moves.moves[Directions.diagonal]);

            //Assert.AreEqual(5, movesL.moves[Directions.horizontal]);
           // Assert.AreEqual(1, movesL.moves[Directions.vertical]);
        }
    }
}