using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chess_game.utils;

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
            _PopulatePiecesList();

            //MessageBox.Show("erreur");
        }


        /// <summary>
        /// Remplit le board de cases où seront mise les pièces.
        /// </summary>
        private void _PopulateGrid()
        {
            // dimensionne les block des bouttons.
            int buttonHeight = boardPanel.Height / chessBoard.getSize[0];
            int buttonWidth = boardPanel.Width / chessBoard.getSize[1];
            
            int buttonCoord = boardPanel.Height / chessBoard.getSize[0];

            for(int i = 0; i < chessBoard.getSize[0]; i++)
            {
                for(int j = 0; j < chessBoard.getSize[1]; j++)
                {
                    buttonsGrid[i, j] = new Button();
                    buttonsGrid[i, j].Height = buttonHeight;
                    buttonsGrid[i, j].Width = buttonWidth;

                    buttonsGrid[i, j].Click += _Grid_Button_Click;

                    boardPanel.Controls.Add(buttonsGrid[i, j]);
                    // règle l'espacement entre les boutons sur l'axe des x et y.
                    buttonsGrid[i, j].Location = new Point((i * buttonCoord), (j * buttonCoord));
                    buttonsGrid[i, j].Tag = new Point(i , j);
                    //buttonsGrid[i, j].Location = new Point(i * boardPanel.Width/5, j * boardPanel.Width/10);
                    
                    //buttonsGrid[i, j].Text = String.Format("{0}|{1}", buttonHeight, buttonHeight);
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
            foreach(Piece p in chessBoard.getPieces)
            {
                if (!psl.Contains(p.getType))
                {
                    PiecesList.Items.Add(p.getType);
                    psl.Add(p.getType);
                }
            }           
            PiecesList.EndUpdate();
        }

        private void _Grid_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            
            int column = location.X+1;
            int row = location.Y+1;
            // On enlève 1 à row car dans la liste on commence de 0 à la taille max., hors on a ajouté +1 en haut afin 
            //      d'être fidèle à la représentation du board.
            Coord currentCoord = new Coord(row, ChessConverter.IntToCharCoordConverter(column-1, chessBoard.GetColumnsAtRow(row)));

            //MessageBox.Show(currentCoord.ToString());
            buttonsGrid[location.X, location.Y].Text = chessBoard.GetPieceAtCoord(currentCoord).getType;
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
