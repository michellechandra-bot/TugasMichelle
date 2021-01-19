namespace SAAAA
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
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.MaskedTextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonHost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(47, 132);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(47, 29);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP :";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(122, 135);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(258, 26);
            this.textBoxIP.TabIndex = 2;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(426, 130);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(116, 36);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonHost
            // 
            this.buttonHost.Location = new System.Drawing.Point(85, 213);
            this.buttonHost.Name = "buttonHost";
            this.buttonHost.Size = new System.Drawing.Size(394, 51);
            this.buttonHost.TabIndex = 4;
            this.buttonHost.Text = "HOST";
            this.buttonHost.UseVisualStyleBackColor = true;
            this.buttonHost.Click += new System.EventHandler(this.buttonHost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connect to game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHost);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Multiplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.MaskedTextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonHost;
        private System.Windows.Forms.Label label1;
    }
}

