using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace chessGame.model.Tests
{
    [TestClass()]
    public class ChessBoardTests
    {
        ChessBoard chessBoard;
        ChessBoardBuilder chessBoardBuilder;
        ChessBoardDirector ChessBoardDirector;

        King king1;
        King king2;
        Coord coord1;
        Coord coord2;
        Coord coord3;

        [TestInitialize()]
        public void testsInitialize()
        {
            chessBoard = new ChessBoard();
            chessBoardBuilder = new ChessBoardBuilder();
            ChessBoardDirector = new ChessBoardDirector();

            king1 = new King();
            king2 = new King(PiecesColor.black);
            coord1 = new Coord(2, 'a');
            coord2 = new Coord(3, 'a');
            coord3 = new Coord(3, 'b');
        }

        [TestMethod()]
        public void GetPieceByIDTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            chessBoard.AddPieces(new List<Piece>() { king1, king2 },
                                new List<Coord>() { coord2, coord3 });
            Assert.AreEqual(king1, chessBoard.GetPieceByID(33));
            Assert.AreEqual(king2, chessBoard.GetPieceByID(34));
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException),
        "La pièce n'a pas été trouvé.")]
        public void GetPieceByInexistingIDTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();
            // Doit retourner une exception.
            chessBoard.GetPieceByID(125);
        }

        [TestMethod()]
        public void CreationBoardTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(8, chessBoard.board.Count);
            Assert.AreEqual(8, chessBoard.board.Values.Count);
            Assert.AreEqual(32, chessBoard.getNumberOfPieces);

            int i = 1;
            Piece p = null;
            foreach (KeyValuePair<Coord, Piece> kv in chessBoard.pieceAtCoord)
            {
                if (i <= 16)
                {
                    if (kv.Value is King)
                        p = new King();
                    else if (kv.Value is Rook)
                        p = new Rook();
                    else if (kv.Value is Bishop)
                        p = new Bishop();
                    else if (kv.Value is Queen)
                        p = new Queen();
                    else if (kv.Value is Knight)
                        p = new Knight();
                    else if (kv.Value is Pawn)
                        p = new Pawn();

                    p.id = i++;
                    Assert.AreEqual(p, kv.Value);
                }

                else if (i > 16)
                {
                    if (kv.Value is King)
                        p = new King(PiecesColor.black);
                    else if (kv.Value is Rook)
                        p = new Rook(PiecesColor.black);
                    else if (kv.Value is Bishop)
                        p = new Bishop(PiecesColor.black);
                    else if (kv.Value is Queen)
                        p = new Queen(PiecesColor.black);
                    else if (kv.Value is Knight)
                        p = new Knight(PiecesColor.black);
                    else if (kv.Value is Pawn)
                        p = new Pawn(PiecesColor.black);

                    p.id = i++;
                    Assert.AreEqual(p, kv.Value);
                }
            }
        }

        [TestMethod()]
        public void MovePieceTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Pawn p = (Pawn)chessBoard.GetPieceAtCoord(coord1);

            Assert.AreEqual(true, chessBoard.pieceAtCoord.ContainsKey(coord1));

            chessBoard.MovePiece(coord1, coord2);
            Assert.AreEqual(p, chessBoard.GetPieceAtCoord(coord2));
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(coord1));
        }

        [TestMethod()]
        public void AddPiecesTest()
        {
            chessBoardBuilder.SetDimensions(4, new List<char>() { 'a', 'b', 'c' });
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(0, chessBoard.getNumberOfPieces);
            chessBoard.AddPiece(king1, coord1);
            Assert.AreEqual(1, chessBoard.getNumberOfPieces);
            Assert.AreEqual(king1, chessBoard.GetPieceByID(1));
        }

        [TestMethod()]
        public void GetPiecAtCoordTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(PiecesColor.white, ((Rook)chessBoard.GetPieceAtCoord(new Coord(1, 'a'))).color);
            Assert.AreEqual(PiecesColor.white, ((Pawn)chessBoard.GetPieceAtCoord(new Coord(2, 'b'))).color);
            Assert.AreEqual(PiecesColor.black, ((Queen)chessBoard.GetPieceAtCoord(new Coord(8, 'd'))).color);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException),
        "La pièce n'a pas été trouvé.")]
        public void RemovePieceAtCoordTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(typeof(Pawn), chessBoard.GetPieceAtCoord(coord1).GetType());
            chessBoard.RemovePieceAtCoord(coord1);
            // Doit retourner une exception.
            chessBoard.GetPieceAtCoord(coord1);
        }
    }

}