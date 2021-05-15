using System;
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
        int n;
        PictureBox[,] Picture;
        string color = "white_man", k1 = "", k2 = "", B1 = "", B2 = "", win;
        int black = 12, white = 12;

        private Choice choice;

        public Form1(string select)
        {
            InitializeComponent();

            choice = new Choice();

            if (select == "Black")
            {
                player_white.Text = "Computer";
                player_white.BackColor = Color.LightGray;
                player_white_text.Hide();
                player_black_text.Hide();
            }

            if (select == "White")
            {
                player_black.Text = "Computer";
                player_black.BackColor = Color.LightGray;
                player_black_text.Hide();
                player_white_text.Hide();
            }
                
        }

        private void player_black_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void player_white_Click(object sender, EventArgs e)
        {
            
        }

        private void player_white_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                TextBox player = sender as TextBox;
                
                if (player.Text != "" && player_white.Text != player_black.Text)
                {
                    player.ReadOnly = true;

                    if (player.Name == "player_black")
                    {
                        player.BackColor = Color.LightGray;
                    }

                    else
                    {
                        player.BackColor = Color.LightGray;
                    }
                }

                else
                {
                    if(player.Text == "")
                    {
                        MessageBox.Show("Player name can't be blank");
                    }

                    if(player_white.Text == player_black.Text)
                    {
                        MessageBox.Show("Players cannot have the same name!");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void board_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            n = 8;
            Picture = new PictureBox[n, n];

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
                    Picture[i, j] = new PictureBox();
                    Picture[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    Picture[i, j].Location = new Point(left, top);
                    Picture[i, j].Size = new Size(82, 82);

                    left += 82;

                    Picture[i, j].Name = i + " " + j;

                    if (i < (n / 2) - 1 && Picture[i, j].BackColor == Color.Black)
                    {
                        Picture[i, j].Image = Properties.Resources.white_man;
                        Picture[i, j].Name += " white_man";
                    }

                    else if (i > (n / 2) && Picture[i, j].BackColor == Color.Black) {
                        Picture[i, j].Image = Properties.Resources.black_man;
                        Picture[i, j].Name += " black_man";
                    }

                    Picture[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    Picture[i, j].MouseHover += (sender2, e2) => {
                        PictureBox p = sender2 as PictureBox;

                        if (p.Image != null)
                        {
                            p.BackColor = Color.FromArgb(255, 120, 85, 138);
                        }
                    };

                    Picture[i, j].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;

                        if (p.Image != null)
                        {
                            p.BackColor = Color.Black;
                        }
                    };

                    Picture[i, j].Click += (sender3, e3) =>
                     {
                         if (player_white.ReadOnly && player_black.ReadOnly)
                         {


                             PictureBox p = sender3 as PictureBox;

                             if (p.Image != null)
                             {
                                 int c = -1, x, y;

                                 F();

                                 if (p.Name.Split(' ')[2] == "next_possition")
                                 {
                                     if (color == "white_man")
                                     {
                                         color = "black_man";
                                     }

                                     else
                                     {
                                         color = "white_man";
                                     }

                                     x = Convert.ToInt32(k1.Split(' ')[0]);
                                     y = Convert.ToInt32(k1.Split(' ')[1]);

                                     B1 = "";
                                     B2 = "";

                                     if (k1.Split(' ')[2] == "white_man")
                                     {
                                         p.Image = Properties.Resources.white_man;
                                         p.Name = p.Name.Replace("next_possition", "white_man");
                                     }

                                     else if (k1.Split(' ')[2] == "black_man")
                                     {
                                         p.Image = Properties.Resources.black_man;
                                         p.Name = p.Name.Replace("next_possition", "black_man");
                                     }

                                     Picture[x, y].Image = null;

                                     if (k2 != "")
                                     {
                                         x = Convert.ToInt32(k2.Split(' ')[0]);
                                         y = Convert.ToInt32(k2.Split(' ')[1]);

                                         Picture[x, y].Image = null;

                                         if (k2.Split(' ')[2] == "black_man")
                                         {
                                             black--;
                                         }

                                         else
                                         {
                                             white--;
                                         }

                                         Score_white.Text = white + "";
                                         Score_black.Text = black + "";

                                         k2 = "";

                                         if (white == 1)
                                         {
                                             win = "Black win";
                                             MessageBox.Show(win);
                                         }

                                         if (black == 1)
                                         {
                                             win = "White win";
                                             MessageBox.Show(win);
                                         }
                                     }
                                 }

                                 else
                                 {
                                     if (p.Name.Split(' ')[2] == color)
                                     {
                                         x = Convert.ToInt32(p.Name.Split(' ')[0]);
                                         y = Convert.ToInt32(p.Name.Split(' ')[1]);
                                         k1 = p.Name;

                                         if (p.Name.Split(' ')[2] == "white_man")
                                         {
                                             c = 1;
                                         }

                                         try
                                         {
                                             if (Picture[x + c, y + 1].Image == null)
                                             {
                                                 Picture[x + c, y + 1].Image = Properties.Resources.next_possition;
                                                 Picture[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " next_possition";
                                                 B1 = (x + c) + " " + (y + 1);
                                             }

                                             else if (Picture[x + c, y + 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && Picture[x + (c * 2), y + 2].Image == null)
                                             {
                                                 Picture[x + (c * 2), y + 2].Image = Properties.Resources.next_possition;
                                                 Picture[x + (c * 2), y + 2].Name = (x + (c * 2)) + " " + (y + 2) + " next_possition";

                                                 B1 = (x + (c * 2)) + " " + (y + 2);
                                                 k2 = (x + c) + " " + (y + 1) + " " + Picture[x + c, y + 1].Name.Split(' ')[2];
                                             }
                                         }

                                         catch { }

                                         try
                                         {
                                             if (Picture[x + c, y - 1].Image == null)
                                             {
                                                 Picture[x + c, y - 1].Image = Properties.Resources.next_possition;
                                                 Picture[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " next_possition";
                                                 B2 = (x + c) + " " + (y - 1);
                                             }

                                             else if (Picture[x + c, y - 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && Picture[x + (c * 2), y - 2].Image == null)
                                             {
                                                 Picture[x + (c * 2), y - 2].Image = Properties.Resources.next_possition;
                                                 Picture[x + (c * 2), y - 2].Name = (x + (c * 2)) + " " + (y - 2) + " next_possition";

                                                 B1 = (x + (c * 2)) + " " + (y - 2);
                                                 k2 = (x + c) + " " + (y - 1) + " " + Picture[x + c, y - 1].Name.Split(' ')[2];
                                             }
                                         }

                                         catch { }
                                     }
                                 }
                             }
                         }
                     };

                    board.Controls.Add(Picture[i, j]);
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
                Picture[x, y].Image = null;
            }

            if (B2 != "")
            {
                int x, y;

                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                Picture[x, y].Image = null;
            }
        }
    }
}