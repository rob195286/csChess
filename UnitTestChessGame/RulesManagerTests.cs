using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace chessGame.game.Tests
{
    [TestClass()]
    public class RulesManagerTests
    {
        ChessBoard chessBoard;
        ChessBoardBuilder chessBoardBuilder;
        ChessBoardDirector ChessBoardDirector;

        Queen queen;
        King king;
        Coord coord;

        [TestInitialize()]
        public void testsInitialize()
        {
            chessBoard = new ChessBoard();
            chessBoardBuilder = new ChessBoardBuilder();
            ChessBoardDirector = new ChessBoardDirector();

            queen = new Queen(PiecesColor.white, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
            king = new King(PiecesColor.black, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
            coord = new Coord(4, 'b');
        }

        [TestMethod()]
        public void PossibleMovesOfPieceTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            List<Coord> comparisonKingMoves = new List<Coord>() { new Coord(4,'a'),
                                                            new Coord(4,'c'),
                                                            new Coord(3,'b'),
                                                            new Coord(5,'b')};
            Assert.AreEqual(comparisonKingMoves, chessBoard.LegalMoves(king, coord));
        }
    }
}