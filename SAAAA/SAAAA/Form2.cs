using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAAA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKiri_Click(object sender, EventArgs e)
        {
            if (labelPlayer.Text == "PLAYER 1")
            {
                labelPlayer.Text = "PLAYER 2";
            }
            else if (labelPlayer.Text == "PLAYER 2")
            {
                labelPlayer.Text = "PLAYER 1";
            }

            buttonKiri.Enabled = false;
            buttonKanan.Enabled = true;
        }

        private void buttonKanan_Click(object sender, EventArgs e)
        {
            if (labelPlayer.Text == "PLAYER 1")
            {
                labelPlayer.Text = "PLAYER 2";
            }
            else if (labelPlayer.Text == "PLAYER 2")
            {
                labelPlayer.Text = "PLAYER 1";
            }
            buttonKanan.Enabled = false;
            buttonKiri.Enabled = true;
        }

        private void labelPlayer_Click(object sender, EventArgs e)
        {
        }
    }
}
