namespace TugasWeek15_MichelleChandra_0706022010019
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxSatu = new System.Windows.Forms.ListBox();
            this.listBoxDua = new System.Windows.Forms.ListBox();
            this.buttonSalin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(30, 29);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(87, 20);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(208, 26);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(181, 26);
            this.textBoxNamaItem.TabIndex = 1;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(30, 79);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(68, 20);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonMinuman);
            this.panel1.Controls.Add(this.radioButtonMakanan);
            this.panel1.Location = new System.Drawing.Point(208, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 46);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(144, 5);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMinuman.TabIndex = 5;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(5, 5);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonMakanan.TabIndex = 4;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(208, 142);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(103, 33);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxSatu
            // 
            this.listBoxSatu.FormattingEnabled = true;
            this.listBoxSatu.ItemHeight = 20;
            this.listBoxSatu.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxSatu.Location = new System.Drawing.Point(34, 208);
            this.listBoxSatu.Name = "listBoxSatu";
            this.listBoxSatu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSatu.Size = new System.Drawing.Size(218, 264);
            this.listBoxSatu.TabIndex = 5;
            // 
            // listBoxDua
            // 
            this.listBoxDua.FormattingEnabled = true;
            this.listBoxDua.ItemHeight = 20;
            this.listBoxDua.Location = new System.Drawing.Point(462, 208);
            this.listBoxDua.Name = "listBoxDua";
            this.listBoxDua.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDua.Size = new System.Drawing.Size(216, 264);
            this.listBoxDua.TabIndex = 6;
            // 
            // buttonSalin
            // 
            this.buttonSalin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSalin.Location = new System.Drawing.Point(291, 208);
            this.buttonSalin.Name = "buttonSalin";
            this.buttonSalin.Size = new System.Drawing.Size(132, 33);
            this.buttonSalin.TabIndex = 7;
            this.buttonSalin.Text = ">";
            this.buttonSalin.UseVisualStyleBackColor = true;
            this.buttonSalin.Click += new System.EventHandler(this.buttonSalin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(291, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "X";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxMinuman);
            this.panel2.Controls.Add(this.checkBoxMakanan);
            this.panel2.Location = new System.Drawing.Point(291, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 117);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(16, 66);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(100, 24);
            this.checkBoxMinuman.TabIndex = 1;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(16, 22);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(101, 24);
            this.checkBoxMakanan.TabIndex = 0;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(294, 295);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(42, 19);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Filter";
            this.labelFilter.UseWaitCursor = true;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 604);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSalin);
            this.Controls.Add(this.listBoxDua);
            this.Controls.Add(this.listBoxSatu);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxSatu;
        private System.Windows.Forms.ListBox listBoxDua;
        private System.Windows.Forms.Button buttonSalin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.Label labelFilter;
    }
}

