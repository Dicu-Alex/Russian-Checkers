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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();


        }

        private void Choice_Load(object sender, EventArgs e)
        {

        }

        public void btnNextColor_Click(object sender, EventArgs e)
        {
            if (btnBlackP.Checked == true)
            {
                string select = "Black";

                this.Hide();
                //Form1 f = new Form1(select);
                Form1 f = new Form1();
                f.ShowDialog();
            }

            if (btnWhiteP.Checked == true)
            {
                string select = "White";

                this.Hide();
                //Form1 f = new Form1(select);
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        public void btnBlackP_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void btnWhiteP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BlackP_Click(object sender, EventArgs e)
        {

        }
    }
}
