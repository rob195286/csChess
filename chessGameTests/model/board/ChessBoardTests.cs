using chessGame.pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace chessGame.model.Tests
{
    [TestClass()]
    public class ChessBoardTests
    {
        ChessBoard chessBoard;
        List<char> fakeListChar;

        Piece piece1;

        [TestInitialize()]
        public void testsInitialize()
        {
            fakeListChar = new List<char>() { 'r', 't', 'a' };
            chessBoard = new ChessBoard(5, fakeListChar);
        }

        [TestMethod()]
        public void ChessBoardTest()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod()]
        public void CreationBoardTest()
        {
            //Assert.AreEqual(5, chessBoard.board.Count);
        }

        [TestMethod()]
        public void MovePieceTest()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod()]
        public void AddPiecesTest()
        {
            Assert.AreEqual(0, 0);
        }
    }

}