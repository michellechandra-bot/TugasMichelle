using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEmpty_Click(object sender, EventArgs e)
        {

        }

        private void textUbah_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            labelEmpty.Text = textUbah.Text;
            labelEmpty.ForeColor = Color.Black;

            if (textUbah.Text.Equals("BLUE"))
            {
                labelEmpty.ForeColor = Color.Blue;
            }
            else if (textUbah.Text.Equals("RED"))
            {
                labelEmpty.ForeColor = Color.Red;
            }
            else if (textUbah.Text.Equals("GREEN"))
            {
                labelEmpty.ForeColor = Color.Green;
            }

            if (textUbah.Text.Equals("DELETE"))
            {
                labelEmpty.Text = "[EMPTY]";
                labelEmpty.ForeColor = Color.Black;
            }

            if (textUbah.Text.Equals("HIDE"))
            {
                labelEmpty.Visible = false;
                labelEmpty.ForeColor = Color.Black;
            }
            else if (textUbah.Text.Equals("SHOWN"))
            {
                labelEmpty.Visible = true;
                labelEmpty.Text = "[EMPTY]";
                labelEmpty.ForeColor = Color.Black;
            }
        }
    }
}
