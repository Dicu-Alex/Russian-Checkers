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
        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choice c = new Choice();
            c.ShowDialog();
        }
    }
}
