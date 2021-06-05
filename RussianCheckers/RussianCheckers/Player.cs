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
    public partial class Player : Form
    {
        String select;

        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            if (select == "Single player")
            {
                this.Hide();
                Choice c = new Choice();
                c.ShowDialog();
            }

            else if (select == "Two players")
            {
                string select = "Two players";

                this.Hide();
                Form1 f = new Form1(select);
                f.ShowDialog();
            }

            else if (select == "Online")
            {
                string select = "Online";

                this.Hide();
                Form1 f = new Form1(select);
                f.ShowDialog();
            }

            else {
                MessageBox.Show("No option selected!");
            }
            
        }

        private void SingleP_CheckedChanged(object sender, EventArgs e)
        {
            select = "Single player";
        }

        private void TwoP_CheckedChanged(object sender, EventArgs e)
        {
            select = "Two players";
        }

        private void OnlineP_CheckedChanged(object sender, EventArgs e)
        {
            select = "Online";
        }
    }
}
