﻿using chessGame.model;
using chessGame.model.board;
using chessGame.pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_game
{
    public partial class Form1 : Form
    {
        ChessBoard chessBoard;
        public Button[,] buttons;


        public Form1()
        {
            ChessBoardBuilder cbb = new ChessBoardBuilder();
            ChessBoardDirector cbd = new ChessBoardDirector();
            cbd.ConstructDefaultChessBoard(cbb);
            chessBoard = cbb.GetChessBoard();

            buttons = new Button[chessBoard.getSize[0], chessBoard.getSize[1]];

            InitializeComponent();
            _PopulateGrid();
            _PopulatePiecesList();

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
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = buttonHeight;
                    buttons[i, j].Width = buttonWidth;

                    buttons[i, j].Click += _Grid_Button_Click;

                    boardPanel.Controls.Add(buttons[i, j]);
                    // règle l'espacement entre les boutons sur l'axe des x et y.
                    buttons[i, j].Location = new Point((i * buttonCoord), (j * buttonCoord));
                    buttons[i, j].Tag = new Point(i , j);
                    //buttons[i, j].Location = new Point(i * boardPanel.Width/5, j * boardPanel.Width/10);
                    
                    //buttons[i, j].Text = String.Format("{0}|{1}", buttonHeight, buttonHeight);
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

            int x = location.X;
            int y = location.Y;
            //Cell currentCelle = 
            DataGridCell currentCelle = chessBoard.
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
