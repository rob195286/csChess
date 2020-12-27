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
        Queen queen;
        Queen queen2;

        [TestInitialize()]
        public void testsInitialize()
        {
            king = new King();
            queen = new Queen();
            queen2 = new Queen(PiecesColor.white);
        }
        
        [TestMethod()]
        public void PiecesCreationTest()
        {            
            Assert.AreEqual(PiecesColor.white, king.color);

            king = new King(PiecesColor.black);
            Assert.AreEqual(PiecesColor.black, king.color);

            Assert.AreEqual(true, king.HasDirection(Directions.diagonal));
            Assert.AreEqual(true, king.HasDirection(Directions.horizontal));
            Assert.AreEqual(true, king.HasDirection(Directions.vertical));
            Assert.AreEqual(false, king.HasDirection(Directions.verticalFront));
        }

        [TestMethod()]
        public void ObjectsComparaisonTest()
        {
            Assert.AreEqual(true, queen==queen2);
            queen.id = 5;
            queen2.id = 5;
            Assert.AreEqual(true, queen==queen2);
            queen.id = 0;
            queen2.id = 5;
            Assert.AreEqual(false, queen==queen2);
        }
    }
}