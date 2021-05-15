
namespace RussianCheckers
{
    partial class Choice
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
            this.Question = new System.Windows.Forms.Label();
            this.BlackP = new System.Windows.Forms.PictureBox();
            this.WhiteP = new System.Windows.Forms.PictureBox();
            this.btnBlackP = new System.Windows.Forms.RadioButton();
            this.btnWhiteP = new System.Windows.Forms.RadioButton();
            this.btnNextColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BlackP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteP)).BeginInit();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Question.Location = new System.Drawing.Point(125, 7);
            this.Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(366, 31);
            this.Question.TabIndex = 1;
            this.Question.Text = "What color do you choose?";
            // 
            // BlackP
            // 
            this.BlackP.Image = global::RussianCheckers.Properties.Resources.black_man;
            this.BlackP.Location = new System.Drawing.Point(155, 84);
            this.BlackP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BlackP.Name = "BlackP";
            this.BlackP.Size = new System.Drawing.Size(90, 89);
            this.BlackP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlackP.TabIndex = 0;
            this.BlackP.TabStop = false;
            // 
            // WhiteP
            // 
            this.WhiteP.Image = global::RussianCheckers.Properties.Resources.white_man;
            this.WhiteP.Location = new System.Drawing.Point(325, 84);
            this.WhiteP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WhiteP.Name = "WhiteP";
            this.WhiteP.Size = new System.Drawing.Size(90, 89);
            this.WhiteP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WhiteP.TabIndex = 2;
            this.WhiteP.TabStop = false;
            // 
            // btnBlackP
            // 
            this.btnBlackP.AutoSize = true;
            this.btnBlackP.Location = new System.Drawing.Point(194, 179);
            this.btnBlackP.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlackP.Name = "btnBlackP";
            this.btnBlackP.Size = new System.Drawing.Size(14, 13);
            this.btnBlackP.TabIndex = 3;
            this.btnBlackP.UseVisualStyleBackColor = true;
            this.btnBlackP.CheckedChanged += new System.EventHandler(this.btnBlackP_CheckedChanged);
            // 
            // btnWhiteP
            // 
            this.btnWhiteP.AutoSize = true;
            this.btnWhiteP.Location = new System.Drawing.Point(364, 179);
            this.btnWhiteP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWhiteP.Name = "btnWhiteP";
            this.btnWhiteP.Size = new System.Drawing.Size(14, 13);
            this.btnWhiteP.TabIndex = 4;
            this.btnWhiteP.UseVisualStyleBackColor = true;
            // 
            // btnNextColor
            // 
            this.btnNextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextColor.Location = new System.Drawing.Point(236, 250);
            this.btnNextColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextColor.Name = "btnNextColor";
            this.btnNextColor.Size = new System.Drawing.Size(97, 37);
            this.btnNextColor.TabIndex = 6;
            this.btnNextColor.Text = "Next";
            this.btnNextColor.UseVisualStyleBackColor = true;
            this.btnNextColor.Click += new System.EventHandler(this.btnNextColor_Click);
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNextColor);
            this.Controls.Add(this.btnWhiteP);
            this.Controls.Add(this.btnBlackP);
            this.Controls.Add(this.WhiteP);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.BlackP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice";
            this.Load += new System.EventHandler(this.Choice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BlackP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BlackP;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox WhiteP;
        private System.Windows.Forms.RadioButton btnWhiteP;
        private System.Windows.Forms.Button btnNextColor;
        private System.Windows.Forms.RadioButton btnBlackP;
    }
}