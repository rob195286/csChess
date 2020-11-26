using System;
using System.Collections.Generic;
using System.Text;

namespace chessGame.controller
{
    public class ChessGameController
    {
        /*
        private ChessView _chessView;
        
         */
        private ChessBoard _chessBoard;


        public ChessGameController(ChessView cv, ChessBoard cb) 
        {
            _chessView = cv;
            _chessBoard = cb;
        }


        public void LoadView()
        {
            _chessView.ClearGrid();
            // todo : charger les pieces, joueurs etc...
        }

        public bool MovePiece(Pieces p, Direction d)
        {
            // todo : vérifier que le mouvement peut être fait
            //_chessView.ChangePieceCoord(Piece, coord)
        }

    }
}
