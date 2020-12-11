namespace Praktikum_Week_13
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUbah = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUbah
            // 
            this.textUbah.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textUbah.Location = new System.Drawing.Point(44, 65);
            this.textUbah.Name = "textUbah";
            this.textUbah.Size = new System.Drawing.Size(288, 26);
            this.textUbah.TabIndex = 1;
            this.textUbah.TextChanged += new System.EventHandler(this.textUbah_TextChanged);
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(44, 124);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(126, 35);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpty.Location = new System.Drawing.Point(37, 211);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(152, 37);
            this.labelEmpty.TabIndex = 3;
            this.labelEmpty.Text = "[EMPTY]";
            this.labelEmpty.Click += new System.EventHandler(this.labelEmpty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 314);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textUbah);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUbah;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelEmpty;
    }
}

