using chessGame.model.piece;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace chessGame.model.piece.Tests
{
    [TestClass()]
    public class PossibleMovesTest
    {
        PossibleMoves moves;
        PossibleMoves movesL;

        [TestInitialize()]
        public void testsInitialize()
        {
            moves = new PossibleMoves(EDirections.diagonal, 2);
            movesL = new PossibleMoves(new Dictionary<EDirections, int>() { { EDirections.horizontal, 5 }, { EDirections.vertical, 1 } });
        }

        [TestMethod()]
        public void HasDirectionTest()
        {
            Assert.AreEqual(true, moves.HasDirection(EDirections.diagonal));
            Assert.AreEqual(false, moves.HasDirection(EDirections.vertical));
        }

        [TestMethod()]
        public void CreationMoveTest()
        {
            Assert.AreEqual(2, moves.moves[EDirections.diagonal]);

            Assert.AreEqual(5, movesL.moves[EDirections.horizontal]);
            Assert.AreEqual(1, movesL.moves[EDirections.vertical]);
        }
    }
}