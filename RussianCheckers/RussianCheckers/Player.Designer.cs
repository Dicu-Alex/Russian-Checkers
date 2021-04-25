
namespace RussianCheckers
{
    partial class Player
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
            this.SingleP = new System.Windows.Forms.RadioButton();
            this.TwoP = new System.Windows.Forms.RadioButton();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SingleP
            // 
            this.SingleP.AutoSize = true;
            this.SingleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SingleP.Location = new System.Drawing.Point(12, 12);
            this.SingleP.Name = "SingleP";
            this.SingleP.Size = new System.Drawing.Size(249, 43);
            this.SingleP.TabIndex = 1;
            this.SingleP.TabStop = true;
            this.SingleP.Text = "Single player";
            this.SingleP.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SingleP.UseVisualStyleBackColor = true;
            // 
            // TwoP
            // 
            this.TwoP.AutoSize = true;
            this.TwoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwoP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwoP.Location = new System.Drawing.Point(12, 66);
            this.TwoP.Name = "TwoP";
            this.TwoP.Size = new System.Drawing.Size(233, 43);
            this.TwoP.TabIndex = 2;
            this.TwoP.TabStop = true;
            this.TwoP.Text = "Two players";
            this.TwoP.UseVisualStyleBackColor = true;
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextPlayer.Location = new System.Drawing.Point(74, 138);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(129, 46);
            this.btnNextPlayer.TabIndex = 4;
            this.btnNextPlayer.Text = "Next";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 196);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.TwoP);
            this.Controls.Add(this.SingleP);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton SingleP;
        private System.Windows.Forms.RadioButton TwoP;
        private System.Windows.Forms.Button btnNextPlayer;
    }
}