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
        String select;

        public Choice()
        {
            InitializeComponent();
        }

        private void Choice_Load(object sender, EventArgs e)
        {

        }

        private void btnNextColor_Click(object sender, EventArgs e)
        {
            string value = "";

            bool isChecked = btnBlackP.Checked;

            if (isChecked)
                value = btnBlackP.Text;
            else
                value = btnWhiteP.Text;

            if (select == "Black")
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }

            else if (select == "White")
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void btnBlackP_CheckedChanged(object sender, EventArgs e)
        {
            select = "Black";
        }

        private void btnWhiteP_CheckedChanged(object sender, EventArgs e)
        {
            select = "White";
        }
    }
}
