﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianCheckers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;

        PictureBox[,] P;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            n = 8;
            P = new PictureBox[n, n];

            int left = 2, top = 2;

            Color[] colors = new Color[] {
                Color.White, Color.Black
            };

            for (int i = 0; i < n; i++)
            {
                left = 2;

                if (i % 2 == 0)
                {
                    colors[0] = Color.White;
                    colors[1] = Color.Black;
                }

                else
                {
                    colors[0] = Color.Black;
                    colors[1] = Color.White;
                }

                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(82, 82);

                    left += 82;

                    board.Controls.Add(P[i, j]);
                }

                top += 82;
            }
        }
    }
}
