
namespace ProjectLTUD
{
    partial class Screens
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectClientBtn = new System.Windows.Forms.Button();
            this.ClientIP = new System.Windows.Forms.Label();
            this.ClientIPTxt = new System.Windows.Forms.TextBox();
            this.ClientPort = new System.Windows.Forms.Label();
            this.ClientPortTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerIPTxt = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.ServerPortTxt = new System.Windows.Forms.TextBox();
            this.ServerIP = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(632, 735);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Client";
            // 
            // ConnectClientBtn
            // 
            this.ConnectClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectClientBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectClientBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ConnectClientBtn.Location = new System.Drawing.Point(1083, 746);
            this.ConnectClientBtn.Name = "ConnectClientBtn";
            this.ConnectClientBtn.Size = new System.Drawing.Size(68, 33);
            this.ConnectClientBtn.TabIndex = 23;
            this.ConnectClientBtn.Text = "Connect";
            this.ConnectClientBtn.UseVisualStyleBackColor = true;
            // 
            // ClientIP
            // 
            this.ClientIP.AutoSize = true;
            this.ClientIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClientIP.Location = new System.Drawing.Point(688, 738);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(17, 15);
            this.ClientIP.TabIndex = 24;
            this.ClientIP.Text = "IP";
            // 
            // ClientIPTxt
            // 
            this.ClientIPTxt.BackColor = System.Drawing.Color.Silver;
            this.ClientIPTxt.Location = new System.Drawing.Point(688, 756);
            this.ClientIPTxt.Name = "ClientIPTxt";
            this.ClientIPTxt.Size = new System.Drawing.Size(184, 23);
            this.ClientIPTxt.TabIndex = 26;
            // 
            // ClientPort
            // 
            this.ClientPort.AutoSize = true;
            this.ClientPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClientPort.Location = new System.Drawing.Point(878, 738);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(29, 15);
            this.ClientPort.TabIndex = 25;
            this.ClientPort.Text = "Port";
            // 
            // ClientPortTxt
            // 
            this.ClientPortTxt.BackColor = System.Drawing.Color.Silver;
            this.ClientPortTxt.Location = new System.Drawing.Point(878, 756);
            this.ClientPortTxt.Name = "ClientPortTxt";
            this.ClientPortTxt.Size = new System.Drawing.Size(184, 23);
            this.ClientPortTxt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(24, 738);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServerIPTxt
            // 
            this.ServerIPTxt.BackColor = System.Drawing.Color.Silver;
            this.ServerIPTxt.Location = new System.Drawing.Point(88, 756);
            this.ServerIPTxt.Name = "ServerIPTxt";
            this.ServerIPTxt.Size = new System.Drawing.Size(184, 23);
            this.ServerIPTxt.TabIndex = 33;
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ServerPort.Location = new System.Drawing.Point(281, 738);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(29, 15);
            this.ServerPort.TabIndex = 32;
            this.ServerPort.Text = "Port";
            // 
            // ServerPortTxt
            // 
            this.ServerPortTxt.BackColor = System.Drawing.Color.Silver;
            this.ServerPortTxt.Location = new System.Drawing.Point(278, 756);
            this.ServerPortTxt.Name = "ServerPortTxt";
            this.ServerPortTxt.Size = new System.Drawing.Size(184, 23);
            this.ServerPortTxt.TabIndex = 34;
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ServerIP.Location = new System.Drawing.Point(90, 738);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(17, 15);
            this.ServerIP.TabIndex = 31;
            this.ServerIP.Text = "IP";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(481, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 30;
            this.button2.Text = "Start Chat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Screens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1541, 791);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIPTxt);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.ServerPortTxt);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectClientBtn);
            this.Controls.Add(this.ClientIP);
            this.Controls.Add(this.ClientIPTxt);
            this.Controls.Add(this.ClientPort);
            this.Controls.Add(this.ClientPortTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Screens";
            this.Text = "Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectClientBtn;
        private System.Windows.Forms.Label ClientIP;
        private System.Windows.Forms.TextBox ClientIPTxt;
        private System.Windows.Forms.Label ClientPort;
        private System.Windows.Forms.TextBox ClientPortTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerIPTxt;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.TextBox ServerPortTxt;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.Button button2;
    }
}