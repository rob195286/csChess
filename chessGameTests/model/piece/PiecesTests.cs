using Microsoft.VisualStudio.TestTools.UnitTesting;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;
using chessGame.model;

namespace chessGame.pieces.Tests
{
    [TestClass()]
    public class PiecesTests
    {
        King king;

        [TestInitialize()]
        public void testsInitialize()
        {
            king = new King();
        }
        
        [TestMethod()]
        public void PiecesCreationTest()
        {            
            Assert.AreEqual(PiecesColor.white, king.color);

            king = new King(PiecesColor.black);
            Assert.AreEqual(PiecesColor.black, king.color);
        }
    }
}