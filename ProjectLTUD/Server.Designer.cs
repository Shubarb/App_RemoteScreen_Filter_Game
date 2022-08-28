
namespace ProjectLTUD
{
    partial class Server
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
            this.ServerPort = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.Label();
            this.ListenBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ServerPortTxt = new System.Windows.Forms.TextBox();
            this.ServerIPTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ServerPort.Location = new System.Drawing.Point(22, 87);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(29, 15);
            this.ServerPort.TabIndex = 14;
            this.ServerPort.Text = "Port";
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ServerIP.Location = new System.Drawing.Point(21, 37);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(17, 15);
            this.ServerIP.TabIndex = 13;
            this.ServerIP.Text = "IP";
            // 
            // ListenBtn
            // 
            this.ListenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListenBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ListenBtn.Location = new System.Drawing.Point(113, 134);
            this.ListenBtn.Name = "ListenBtn";
            this.ListenBtn.Size = new System.Drawing.Size(90, 33);
            this.ListenBtn.TabIndex = 12;
            this.ListenBtn.Text = "Listen";
            this.ListenBtn.UseVisualStyleBackColor = true;
            this.ListenBtn.Click += new System.EventHandler(this.ListenBtn_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(19, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Start Chat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ServerPortTxt
            // 
            this.ServerPortTxt.BackColor = System.Drawing.Color.Silver;
            this.ServerPortTxt.Location = new System.Drawing.Point(19, 105);
            this.ServerPortTxt.Name = "ServerPortTxt";
            this.ServerPortTxt.Size = new System.Drawing.Size(184, 23);
            this.ServerPortTxt.TabIndex = 16;
            // 
            // ServerIPTxt
            // 
            this.ServerIPTxt.BackColor = System.Drawing.Color.Silver;
            this.ServerIPTxt.Location = new System.Drawing.Point(19, 55);
            this.ServerIPTxt.Name = "ServerIPTxt";
            this.ServerIPTxt.Size = new System.Drawing.Size(184, 23);
            this.ServerIPTxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(224, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIPTxt);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.ServerPortTxt);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.Button ListenBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ServerPortTxt;
        private System.Windows.Forms.TextBox ServerIPTxt;
        private System.Windows.Forms.Label label1;
    }
}