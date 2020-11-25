using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace chessGame.model.Tests
{
    [TestClass()]
    public class ChessBoardTests
    {
        List<char> fakeListChar;
        ChessBoard chessBoard;

        King king1;
        Coord coord1;

        [TestInitialize()]
        public void testsInitialize()
        {
            fakeListChar = new List<char>() { 'r', 't', 'a' };
            chessBoard = new ChessBoard();

            king1 = new King(PiecesColor.black);
            king1 = new King();
            coord1 = new Coord();
        }

        [TestMethod()]
        public void CreationBoardTest()
        {
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultBoard();
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(8, chessBoard.board.Count);
            Assert.AreEqual(8, chessBoard.board.Values.Count);
            Assert.AreEqual(16, chessBoard.getNumberOfPieces);
        }

        [TestMethod()]
        public void MovePieceTest()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod()]
        public void AddPiecesTest()
        {
            Assert.AreEqual(0, chessBoard.getNumberOfPieces);
            chessBoard.AddPieces(king1, coord1);
            Assert.AreEqual(1, chessBoard.getNumberOfPieces);
            //todo : terminer
            //Assert.AreEqual(1, chessBoard.GetPieceByID(1));
        }

        [TestMethod()]
        public void GetPieceByIDTest()
        {
            int id = king1.id; 
            Assert.AreEqual(4, id);
        }
    }

}