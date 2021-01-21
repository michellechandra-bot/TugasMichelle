using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15_MichelleChandra_0706022010019
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        public string[,] Makanan = new string[10, 1];
        public string[,] Minuman = new string[10, 1];
        public string[,] Food = new string[10, 1];
        public string[,] Drink = new string[10, 1];
        public int save = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, panel2.DisplayRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMakanan.Checked)
            {
                listBoxSatu.Items.Remove("Susu Sapi");
                listBoxSatu.Items.Remove("Kopi");
                listBoxSatu.Items.Remove("Teh");
                listBoxSatu.Items.Remove("Bir");
                for (int i = 0; i < 10; i++)
                {
                    listBoxSatu.Items.Remove(Minuman[i, 0]);
                }
            }
            else
            {
                listBoxSatu.Items.Add("Susu Sapi");
                listBoxSatu.Items.Add("Kopi");
                listBoxSatu.Items.Add("Teh");
                listBoxSatu.Items.Add("Bir");
            }
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinuman.Checked)
            {
                
                listBoxSatu.Items.Remove("Mie Instan");
                listBoxSatu.Items.Remove("Telor");
                listBoxSatu.Items.Remove("Roti");
                listBoxSatu.Items.Remove("Keju");
                listBoxSatu.Items.Remove("Daging Giling");
                for (int i = 0; i < 10; i++)
                {
                    listBoxSatu.Items.Remove(Makanan[i, 0]);
                }
            }
            else
            {
                listBoxSatu.Items.Add("Mie Instan");
                listBoxSatu.Items.Add("Telor");
                listBoxSatu.Items.Add("Roti");
                listBoxSatu.Items.Add("Keju");
                listBoxSatu.Items.Add("Daging Giling");
            }
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (textBoxNamaItem.Text == "" || radioButtonMakanan.Checked == false && radioButtonMinuman.Checked == false)
            {
                MessageBox.Show("Data Belum Dimasukkan! Input Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!listBoxSatu.Items.Contains(textBoxNamaItem.Text))
            {
                listBoxSatu.Items.Add(textBoxNamaItem.Text);
            }
            else
            {
                MessageBox.Show("Data sudah ada! Input Data Lain!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (radioButtonMinuman.Checked)
            {
                if (save != 10)
                {
                    Minuman[save, 0] = textBoxNamaItem.Text;
                    save++;
                }
                else
                {
                    MessageBox.Show("Full!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                }
            }
            if (radioButtonMakanan.Checked)
            {
                if (save != 10)
                {
                    Makanan[save, 0] = textBoxNamaItem.Text;
                    save++;
                }
                else
                {
                    MessageBox.Show("Full!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            textBoxNamaItem.Text = "";
        }

        private void buttonSalin_Click(object sender, EventArgs e)
        {
            while (listBoxSatu.SelectedItems.Count > 0)
            {
                string item = (string)listBoxSatu.SelectedItems[0];
                if (!listBoxDua.Items.Contains(item))
                {
                    listBoxDua.Items.Add(item);
                    listBoxSatu.Items.Remove(item);
                    listBoxSatu.Items.Add(item);
                }
                else
                {
                    listBoxDua.Items.Remove(item);
                    MessageBox.Show("Data sudah ada! Input Data Lain", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
            }  
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (listBoxDua.SelectedItems.Count > 0)
            {
                listBoxDua.Items.Remove(listBoxDua.SelectedItem);
            }
            else
            {
                listBoxDua.Items.Clear();
            }
        }
    }
}
