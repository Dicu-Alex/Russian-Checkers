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
        string color = "black_man", k = "", B1 = "", B2 = "";

        private void board_Paint(object sender, PaintEventArgs e)
        {

        }

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

                    P[i, j].Name = i + " " + j;

                    if (i < (n / 2) - 1 && P[i, j].BackColor == Color.Black)
                    {
                        P[i, j].Image = Properties.Resources.black_man;
                        P[i, j].Name += " black_man";
                    }

                    else if (i > (n / 2) && P[i, j].BackColor == Color.Black) {
                        P[i, j].Image = Properties.Resources.white_man;
                        P[i, j].Name += " white_man";
                    }

                    P[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    P[i, j].MouseHover += (sender2, e2) => {
                        PictureBox p = sender2 as PictureBox;

                        if (p.Image != null)
                        {
                            p.BackColor = Color.FromArgb(255, 120, 85, 138);
                        }
                    };

                    P[i, j].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;

                        if (p.Image != null)
                        {
                            p.BackColor = Color.Black;
                        }
                    };

                    P[i, j].Click += (sender3, e3) =>
                     {
                         PictureBox p = sender3 as PictureBox;

                         if (p.Image != null)
                         {
                             int c = -1, x, y;

                             F();

                             if (p.Name.Split(' ')[2] == "next_possition")
                             {
                                 if (color == "black_man")
                                 {
                                     color = "white_man";
                                 }

                                 else
                                 {
                                     color = "black_man";
                                 }

                                 x = Convert.ToInt32(k.Split(' ')[0]);
                                 y = Convert.ToInt32(k.Split(' ')[1]);
                                 B1 = "";
                                 B2 = "";

                                 if (k.Split(' ')[2] == "black_man")
                                 {
                                     p.Image = Properties.Resources.black_man;
                                     p.Name = p.Name.Replace("next_possition", "black_man");
                                 }

                                 if (k.Split(' ')[2] == "white_man")
                                 {
                                     p.Image = Properties.Resources.white_man;
                                     p.Name = p.Name.Replace("next_possition", "white_man");
                                 }

                                 P[x, y].Image = null;
                             }

                             else
                             {

                                 if (p.Name.Split(' ')[2] == color)
                                 {
                                     x = Convert.ToInt32(p.Name.Split(' ')[0]);
                                     y = Convert.ToInt32(p.Name.Split(' ')[1]);
                                     k = p.Name;

                                     if (p.Name.Split(' ')[2] == "r")
                                     {
                                         c = 1;
                                     }

                                     try
                                     {
                                         if (P[x + c, y + 1].Image == null)
                                         {
                                             P[x + c, y + 1].Image = Properties.Resources.next_possition;
                                             P[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " next_possition";
                                             B1 = (x + c) + " " + (y + 1);
                                         }
                                     }

                                     catch { }

                                     try
                                     {
                                         if (P[x + c, y - 1].Image == null)
                                         {
                                             P[x + c, y - 1].Image = Properties.Resources.next_possition;
                                             P[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " next_possition";
                                             B2 = (x + c) + " " + (y - 1);
                                         }
                                     }

                                     catch { }
                                 }
                             }
                         }

                     };

                    board.Controls.Add(P[i, j]);
                }

                top += 82;
            }
        }

        public void F() 
        {
            if (B1 != "") {
                int x, y;

                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                P[x, y].Image = null;
            }

            if (B2 != "")
            {
                int x, y;

                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                P[x, y].Image = null;
            }
        }
    }
}
