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
        Coord badCoord1;
        Coord badCoord2;
        Coord badCoord3;
        Coord badCoord4;

        [TestInitialize()]
        public void testsInitialize()
        {
            chessBoard = new ChessBoard();
            chessBoardBuilder = new ChessBoardBuilder();
            ChessBoardDirector = new ChessBoardDirector();

            king1 = new King();
            king2 = new King(PiecesColor.black, new List<Directions>() { });
            coord1 = new Coord(2, 'a');
            coord2 = new Coord(3, 'a');
            coord3 = new Coord(3, 'b');
            badCoord1 = new Coord(9, 'b');
            badCoord2 = new Coord(3, 'z');
            badCoord3 = new Coord(-1, 'b');
            badCoord4 = new Coord(2, 'z');
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
        public void GetPieceByBadIDTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();
            // Doit retourner une exception.
            chessBoard.GetPieceByID(125);
            chessBoard.GetPieceByID(-2);
        }

        [TestMethod()]
        public void CreationBoardTest()
        {
            PiecesColor piecesColor = PiecesColor.white;
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
                        p = new King(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
                    else if (kv.Value is Rook)
                        p = new Rook(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                    Directions.vertical});
                    else if (kv.Value is Bishop)
                        p = new Bishop(piecesColor, new List<Directions>() { Directions.diagonal });
                    else if (kv.Value is Queen)
                        p = new Queen(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
                    else if (kv.Value is Knight)
                        p = new Knight(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                    Directions.vertical });
                    else if (kv.Value is Pawn)
                        p = new Pawn(piecesColor, new List<Directions>() { Directions.verticalUP });

                    p.id = i++;
                    Assert.AreEqual(p, kv.Value);
                }

                else if (i > 16)
                {
                    piecesColor = PiecesColor.black;
                    if (kv.Value is King)
                        p = new King(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
                    else if (kv.Value is Rook)
                        p = new Rook(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                    Directions.vertical});
                    else if (kv.Value is Bishop)
                        p = new Bishop(piecesColor, new List<Directions>() { Directions.diagonal });
                    else if (kv.Value is Queen)
                        p = new Queen(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                   Directions.vertical,
                                                                                   Directions.diagonal});
                    else if (kv.Value is Knight)
                        p = new Knight(piecesColor, new List<Directions>() { Directions.horizontal,
                                                                                    Directions.vertical });
                    else if (kv.Value is Pawn)
                        p = new Pawn(piecesColor, new List<Directions>() { Directions.verticalDOWN });

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
        [ExpectedException(typeof(IndexOutOfRangeException),
        "La pièce n'a pas pu être déplacée.")]
        public void MovePieceAtBadCoordTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Pawn p = (Pawn)chessBoard.GetPieceAtCoord(coord1);
            // Doit retourner une execption.
            chessBoard.MovePiece(coord1, badCoord1);
            chessBoard.MovePiece(coord1, badCoord2);
            chessBoard.MovePiece(coord1, badCoord3);
            // Vérification que la piece n'as pas bougé.
            Assert.AreEqual(p, chessBoard.GetPieceAtCoord(coord1));
            // Vérification que les coord sont ok.
            Assert.AreEqual(true, chessBoard.pieceAtCoord.ContainsKey(coord1));
            // Doit retourner une execption.
            chessBoard.MovePiece(coord1, badCoord4);          
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
        public void GetPiecAtBadCoordTest()
        {
            ChessBoardDirector.ConstructDefaultChessBoard(chessBoardBuilder);
            chessBoard = chessBoardBuilder.GetChessBoard();

            Pawn p = (Pawn)chessBoard.GetPieceAtCoord(coord1);
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(badCoord1));
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(badCoord2));
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(badCoord3));
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(badCoord4));
            // Doit retourner une execption.
            Assert.AreEqual(null, chessBoard.GetPieceAtCoord(badCoord1));
            Assert.AreEqual(null, chessBoard.GetPieceAtCoord(badCoord2));
            Assert.AreEqual(null, chessBoard.GetPieceAtCoord(badCoord3));
            Assert.AreEqual(null, chessBoard.GetPieceAtCoord(badCoord4));
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