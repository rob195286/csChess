using chess_game.utils;
using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chess_game
{
    public partial class ChessGame : Form
    {
        ChessBoard chessBoard;
        public Button[,] buttonsGrid;

        public ChessGame()
        {
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            ChessBoardDirector cbd = new ChessBoardDirector();
            cbd.ConstructDefaultChessBoard(cbb);
            chessBoard = cbb.GetChessBoard();

            buttonsGrid = new Button[chessBoard.getSize[0], chessBoard.getSize[1]];

            InitializeComponent();
            _PopulateGrid();
            _SetPieceOnGrid();
            _PopulatePiecesList();

            //MessageBox.Show("");
        }


        /// <summary>
        /// Remplit le board de cases où seront mise les pièces.
        /// </summary>
        private void _PopulateGrid()
        {
            // Dimensionne les blocks des bouttons.
            int buttonHeight = (boardPanel.Height / chessBoard.getSize[0]);
            //int buttonWidth = (boardPanel.Width / chessBoard.getSize[1]);

            int buttonCoord = (boardPanel.Height / chessBoard.getSize[0]);

            for (int row = 0; row < chessBoard.getSize[0]; row++)
            {
                for (int column = 0; column < chessBoard.getSize[1]; column++)
                {
                    buttonsGrid[row, column] = new Button();
                    buttonsGrid[row, column].Height = buttonHeight;
                    //buttonsGrid[i, j].Width = buttonWidth;
                    buttonsGrid[row, column].Width = buttonHeight;

                    buttonsGrid[row, column].Click += _Grid_Button_Click;

                    boardPanel.Controls.Add(buttonsGrid[row, column]);
                    // règle l'espacement entre les boutons sur l'axe des x et y.
                    buttonsGrid[row, column].Location = new Point((row * buttonCoord), (column * buttonCoord));
                    buttonsGrid[row, column].Tag = new Point(row, column);
                    //buttonsGrid[i, j].Location = new Point(i * boardPanel.Width/5, j * boardPanel.Width/10);
                }
            }
        }
        /// <summary>
        /// Place les pièces à leurs coordonnées respective.
        /// </summary>
        private void _SetPieceOnGrid()
        {
            Coord coord;
            for (int row = 0; row < chessBoard.getSize[0]; row++)
            {
                for (int column = 0; column < chessBoard.getSize[1]; column++)
                {
                    coord = new Coord(row + 1, ChessConverter.IntToCharColumnConverter(column, chessBoard.GetColumnsAtRow(row + 1)));
                    if (chessBoard.getOccupiedCoord.Contains(coord))
                    {
                        buttonsGrid[column, row].Text = chessBoard.GetPieceAtCoord(coord).getType;
                    }
                }
            }
        }
        /// <summary>
        /// Remplit la liste des pièces qui seront jouable.
        /// </summary>
        private void _PopulatePiecesList()
        {
            PiecesList.BeginUpdate();
            List<string> psl = new List<string>() { };
            foreach (Piece p in chessBoard.getPieces)
            {
                // évite la duplication dans la fenêtre de pièces qui ont déjà été ajoutées.
                if (!psl.Contains(p.getType))
                {
                    PiecesList.Items.Add(p.getType);
                    psl.Add(p.getType);
                }
            }
            PiecesList.EndUpdate();
        }
        /// <summary>
        /// Affiche la pièce à l'endroit cliqué sur le board de l'interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Grid_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int column = location.X;
            int row = location.Y + 1;
            // On enlève 1 à row car dans la liste on commence de 0 à la taille max., hors on a ajouté +1 en haut afin 
            //      d'être fidèle à la représentation du board.
            Coord currentCoord = new Coord(row, ChessConverter.IntToCharColumnConverter(column, chessBoard.GetColumnsAtRow(row)));
            MessageBox.Show(currentCoord.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PiecesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
               
    }
}
