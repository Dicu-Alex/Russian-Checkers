namespace RussianCheckers
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
            this.board = new System.Windows.Forms.Panel();
            this.White_player = new System.Windows.Forms.PictureBox();
            this.Black_player = new System.Windows.Forms.PictureBox();
            this.Score_white = new System.Windows.Forms.Label();
            this.Score_black = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player_white = new System.Windows.Forms.TextBox();
            this.player_black = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.White_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black_player)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.White;
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.board.Location = new System.Drawing.Point(11, 10);
            this.board.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(880, 810);
            this.board.TabIndex = 0;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint);
            // 
            // White_player
            // 
            this.White_player.Image = global::RussianCheckers.Properties.Resources.white_man;
            this.White_player.Location = new System.Drawing.Point(897, 12);
            this.White_player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.White_player.Name = "White_player";
            this.White_player.Size = new System.Drawing.Size(117, 112);
            this.White_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.White_player.TabIndex = 1;
            this.White_player.TabStop = false;
            // 
            // Black_player
            // 
            this.Black_player.Image = global::RussianCheckers.Properties.Resources.black_man;
            this.Black_player.Location = new System.Drawing.Point(897, 706);
            this.Black_player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Black_player.Name = "Black_player";
            this.Black_player.Size = new System.Drawing.Size(117, 112);
            this.Black_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Black_player.TabIndex = 2;
            this.Black_player.TabStop = false;
            // 
            // Score_white
            // 
            this.Score_white.AutoSize = true;
            this.Score_white.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score_white.Location = new System.Drawing.Point(1021, 46);
            this.Score_white.Name = "Score_white";
            this.Score_white.Size = new System.Drawing.Size(66, 46);
            this.Score_white.TabIndex = 3;
            this.Score_white.Text = "12";
            this.Score_white.Click += new System.EventHandler(this.label1_Click);
            // 
            // Score_black
            // 
            this.Score_black.AutoSize = true;
            this.Score_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score_black.Location = new System.Drawing.Point(1021, 743);
            this.Score_black.Name = "Score_black";
            this.Score_black.Size = new System.Drawing.Size(66, 46);
            this.Score_black.TabIndex = 4;
            this.Score_black.Text = "12";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1.Location = new System.Drawing.Point(897, 146);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(91, 25);
            this.player1.TabIndex = 5;
            this.player1.Text = "Player 1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2.Location = new System.Drawing.Point(897, 662);
            this.player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(91, 25);
            this.player2.TabIndex = 6;
            this.player2.Text = "Player 2";
            // 
            // player_white
            // 
            this.player_white.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_white.Location = new System.Drawing.Point(1003, 143);
            this.player_white.Margin = new System.Windows.Forms.Padding(4);
            this.player_white.Name = "player_white";
            this.player_white.Size = new System.Drawing.Size(248, 30);
            this.player_white.TabIndex = 7;
            this.player_white.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player_white_KeyPress);
            // 
            // player_black
            // 
            this.player_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_black.Location = new System.Drawing.Point(1003, 658);
            this.player_black.Margin = new System.Windows.Forms.Padding(4);
            this.player_black.Name = "player_black";
            this.player_black.Size = new System.Drawing.Size(241, 30);
            this.player_black.TabIndex = 8;
            this.player_black.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player_white_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1268, 831);
            this.Controls.Add(this.player_black);
            this.Controls.Add(this.player_white);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.Score_black);
            this.Controls.Add(this.Score_white);
            this.Controls.Add(this.Black_player);
            this.Controls.Add(this.White_player);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Checkers";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.White_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.PictureBox White_player;
        private System.Windows.Forms.PictureBox Black_player;
        private System.Windows.Forms.Label Score_white;
        private System.Windows.Forms.Label Score_black;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.TextBox player_white;
        private System.Windows.Forms.TextBox player_black;
    }
}

