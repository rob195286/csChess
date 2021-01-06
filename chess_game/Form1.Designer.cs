
namespace chess_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardPanel = new System.Windows.Forms.Panel();
            this.PiecesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardPanel.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardPanel.Location = new System.Drawing.Point(14, 32);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(719, 583);
            this.boardPanel.TabIndex = 0;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            // 
            // PiecesList
            // 
            this.PiecesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PiecesList.FormattingEnabled = true;
            this.PiecesList.Location = new System.Drawing.Point(763, 32);
            this.PiecesList.Name = "PiecesList";
            this.PiecesList.Size = new System.Drawing.Size(121, 21);
            this.PiecesList.TabIndex = 2;
            this.PiecesList.SelectedIndexChanged += new System.EventHandler(this.PiecesList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 781);
            this.Controls.Add(this.PiecesList);
            this.Controls.Add(this.boardPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.ComboBox PiecesList;
    }
}

