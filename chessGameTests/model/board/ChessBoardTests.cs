﻿using chessGame.model;
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
        King king2;
        Coord coord1;
        Coord coord2;

        [TestInitialize()]
        public void testsInitialize()
        {
            fakeListChar = new List<char>() { 'r', 't', 'a' };
            chessBoard = new ChessBoard();

            king1 = new King();
            king2 = new King(PiecesColor.black);
            coord1 = new Coord();
            coord2 = new Coord();
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
            foreach(KeyValuePair<Coord , Piece> kv in chessBoard.pieces)
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
            // todo : finir
            Assert.AreEqual(0, 10);
        }

        [TestMethod()]
        public void AddPiecesTest()
        {
            Assert.AreEqual(0, chessBoard.getNumberOfPieces);
            chessBoard.AddPieces(king1, coord1);
            Assert.AreEqual(1, chessBoard.getNumberOfPieces);
            Assert.AreEqual(king1, chessBoard.GetPieceByID(1));
        }

        [TestMethod()]
        public void GetPieceByIDTest()
        {
            chessBoard.AddPieces(new List<Piece>() { king1, king2 }, 
                                new List<Coord>() { coord1, coord2 });
            Assert.AreEqual(1, king1.id);
            Assert.AreEqual(2, king2.id);
        }
    }

}