using Microsoft.VisualStudio.TestTools.UnitTesting;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.pieces.Tests
{
    [TestClass()]
    public class PiecesTests
    {
        [TestMethod()]
        public void getNameTest()
        {
            Pieces p = new Pieces();
            Assert.AreEqual("piece", p.getName());
        }
    }
}