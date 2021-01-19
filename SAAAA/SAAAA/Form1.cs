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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string textdariButton = "";
        private void buttonConnect_Click(object sender, EventArgs e)
        {

        }

        private void buttonHost_Click(object sender, EventArgs e)
        {
            textdariButton = "";
            Form2 newform = new Form2();
            newform.Show();
        }
    }
}
