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
        ChessBoard chessBoard;

        King king1;
        King king2;
        Coord coord1;
        Coord coord2;

        [TestInitialize()]
        public void testsInitialize()
        {
            chessBoard = new ChessBoard();

            king1 = new King();
            king2 = new King(PiecesColor.black);
            coord1 = new Coord();
            coord2 = new Coord(1,'e');
        }

        [TestMethod()]
        public void CreationBoardTest()
        {
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(8, chessBoard.board.Count);
            Assert.AreEqual(8, chessBoard.board.Values.Count);
            Assert.AreEqual(32, chessBoard.getNumberOfPieces);

            int i = 1;
            Piece p = null;
            foreach(KeyValuePair<Coord , Piece> kv in chessBoard.pieceAtCoord)
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
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            chessBoard = chessBoardBuilder.GetChessBoard();

            Pawn p = (Pawn)chessBoard.GetPieceAtCoord(new Coord(2, 'e'));

            Assert.AreEqual(true, chessBoard.pieceAtCoord.ContainsKey(new Coord(2, 'e')));

            chessBoard.MovePiece(new Coord(2, 'e'), new Coord(3,'a'));
            Assert.AreEqual(p, chessBoard.GetPieceAtCoord(new Coord(3, 'a')));
            Assert.AreEqual(false, chessBoard.pieceAtCoord.ContainsKey(new Coord(2, 'e')));
        }

        [TestMethod()]
        public void AddPiecesTest()
        {
            Assert.AreEqual(0, chessBoard.getNumberOfPieces);
            chessBoard.AddPiece(king1, coord1);
            Assert.AreEqual(1, chessBoard.getNumberOfPieces);
            Assert.AreEqual(king1, chessBoard.GetPieceByID(1));
        }

        [TestMethod()]
        public void GetPieceByIDTest()
        {
            chessBoard.AddPieces(new List<Piece>() { king1, king2 }, 
                                new List<Coord>() { coord1, coord2 });
            Assert.AreEqual(king1, chessBoard.GetPieceByID(1));
            Assert.AreEqual(king2, chessBoard.GetPieceByID(2));
        }
        
        [TestMethod()]
        public void GetPiecAtCoordTest()
        {
            ChessBoardBuilder chessBoardBuilder = new ChessBoardBuilder();
            chessBoardBuilder.SetDefaultChessBoard();
            chessBoard = chessBoardBuilder.GetChessBoard();

            Assert.AreEqual(PiecesColor.white, ((Rook)chessBoard.GetPieceAtCoord(new Coord(1,'a'))).color);
            Assert.AreEqual(PiecesColor.white, ((Pawn)chessBoard.GetPieceAtCoord(new Coord(2,'b'))).color);
            Assert.AreEqual(PiecesColor.black, ((Queen)chessBoard.GetPieceAtCoord(new Coord(8,'d'))).color);
        }
    }

}