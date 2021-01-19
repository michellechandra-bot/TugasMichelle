namespace SAAAA
{
    partial class Form2
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
            this.buttonKiri = new System.Windows.Forms.Button();
            this.buttonKanan = new System.Windows.Forms.Button();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKiri
            // 
            this.buttonKiri.Location = new System.Drawing.Point(46, 151);
            this.buttonKiri.Name = "buttonKiri";
            this.buttonKiri.Size = new System.Drawing.Size(187, 147);
            this.buttonKiri.TabIndex = 0;
            this.buttonKiri.UseVisualStyleBackColor = true;
            this.buttonKiri.Click += new System.EventHandler(this.buttonKiri_Click);
            // 
            // buttonKanan
            // 
            this.buttonKanan.Location = new System.Drawing.Point(290, 151);
            this.buttonKanan.Name = "buttonKanan";
            this.buttonKanan.Size = new System.Drawing.Size(187, 147);
            this.buttonKanan.TabIndex = 1;
            this.buttonKanan.UseVisualStyleBackColor = true;
            this.buttonKanan.Click += new System.EventHandler(this.buttonKanan_Click);
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(179, 75);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(211, 46);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "PLAYER 1";
            this.labelPlayer.Click += new System.EventHandler(this.labelPlayer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 374);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.buttonKanan);
            this.Controls.Add(this.buttonKiri);
            this.Name = "Form2";
            this.Text = "Tic Tac Toe Multiplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKiri;
        private System.Windows.Forms.Button buttonKanan;
        private System.Windows.Forms.Label labelPlayer;
    }
}