
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
            this.SingleP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SingleP.AutoSize = true;
            this.SingleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SingleP.Location = new System.Drawing.Point(9, 10);
            this.SingleP.Margin = new System.Windows.Forms.Padding(2);
            this.SingleP.Name = "SingleP";
            this.SingleP.Size = new System.Drawing.Size(201, 35);
            this.SingleP.TabIndex = 1;
            this.SingleP.Text = "Single player";
            this.SingleP.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SingleP.UseVisualStyleBackColor = true;
            this.SingleP.CheckedChanged += new System.EventHandler(this.SingleP_CheckedChanged);
            // 
            // TwoP
            // 
            this.TwoP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TwoP.AutoSize = true;
            this.TwoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwoP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwoP.Location = new System.Drawing.Point(9, 54);
            this.TwoP.Margin = new System.Windows.Forms.Padding(2);
            this.TwoP.Name = "TwoP";
            this.TwoP.Size = new System.Drawing.Size(190, 35);
            this.TwoP.TabIndex = 2;
            this.TwoP.Text = "Two players";
            this.TwoP.UseVisualStyleBackColor = true;
            this.TwoP.CheckedChanged += new System.EventHandler(this.TwoP_CheckedChanged);
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextPlayer.Location = new System.Drawing.Point(56, 112);
            this.btnNextPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(97, 37);
            this.btnNextPlayer.TabIndex = 4;
            this.btnNextPlayer.Text = "Next";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 159);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.TwoP);
            this.Controls.Add(this.SingleP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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