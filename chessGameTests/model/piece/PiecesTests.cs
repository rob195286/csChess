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
        King king2;

        [TestInitialize()]
        public void testsInitialize()
        {
            king = new King();
            king2 = new King();
        }

        [TestMethod()]
        public void KingIDTest()
        {
            Assert.AreEqual(1, king.id);
            Assert.AreEqual(2, king2.id);
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