using Microsoft.VisualStudio.TestTools.UnitTesting;
using chessGame.model;
using System.Collections.Generic;
using chessGame.pieces;

namespace chessGame.model.Tests
{
    [TestClass()]
    public class BoardTests
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
        public void CreationBoardTest()
        {
            Assert.AreEqual(5, chessBoard.board.Count);
        }

        [TestMethod()]
        public void MovePieceTest()
        {
            Assert.AreEqual(0,0);
        }
    }
}