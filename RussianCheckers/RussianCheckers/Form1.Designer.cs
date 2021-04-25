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
            this.White_player.Name = "White_player";
            this.White_player.Size = new System.Drawing.Size(118, 112);
            this.White_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.White_player.TabIndex = 1;
            this.White_player.TabStop = false;
            // 
            // Black_player
            // 
            this.Black_player.Image = global::RussianCheckers.Properties.Resources.black_man;
            this.Black_player.Location = new System.Drawing.Point(897, 707);
            this.Black_player.Name = "Black_player";
            this.Black_player.Size = new System.Drawing.Size(118, 112);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1268, 831);
            this.Controls.Add(this.Score_black);
            this.Controls.Add(this.Score_white);
            this.Controls.Add(this.Black_player);
            this.Controls.Add(this.White_player);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
    }
}

