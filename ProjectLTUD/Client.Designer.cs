
namespace ProjectLTUD
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectClientBtn = new System.Windows.Forms.Button();
            this.ClientIP = new System.Windows.Forms.Label();
            this.ClientIPTxt = new System.Windows.Forms.TextBox();
            this.ClientPort = new System.Windows.Forms.Label();
            this.ClientPortTxt = new System.Windows.Forms.TextBox();
            this.Sharebtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Client";
            // 
            // ConnectClientBtn
            // 
            this.ConnectClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectClientBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectClientBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ConnectClientBtn.Location = new System.Drawing.Point(135, 151);
            this.ConnectClientBtn.Name = "ConnectClientBtn";
            this.ConnectClientBtn.Size = new System.Drawing.Size(68, 33);
            this.ConnectClientBtn.TabIndex = 17;
            this.ConnectClientBtn.Text = "Connect";
            this.ConnectClientBtn.UseVisualStyleBackColor = true;
            this.ConnectClientBtn.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ClientIP
            // 
            this.ClientIP.AutoSize = true;
            this.ClientIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClientIP.Location = new System.Drawing.Point(19, 58);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(17, 15);
            this.ClientIP.TabIndex = 18;
            this.ClientIP.Text = "IP";
            // 
            // ClientIPTxt
            // 
            this.ClientIPTxt.BackColor = System.Drawing.Color.Silver;
            this.ClientIPTxt.Location = new System.Drawing.Point(19, 76);
            this.ClientIPTxt.Name = "ClientIPTxt";
            this.ClientIPTxt.Size = new System.Drawing.Size(184, 23);
            this.ClientIPTxt.TabIndex = 20;
            // 
            // ClientPort
            // 
            this.ClientPort.AutoSize = true;
            this.ClientPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClientPort.Location = new System.Drawing.Point(19, 104);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(29, 15);
            this.ClientPort.TabIndex = 19;
            this.ClientPort.Text = "Port";
            // 
            // ClientPortTxt
            // 
            this.ClientPortTxt.BackColor = System.Drawing.Color.Silver;
            this.ClientPortTxt.Location = new System.Drawing.Point(19, 122);
            this.ClientPortTxt.Name = "ClientPortTxt";
            this.ClientPortTxt.Size = new System.Drawing.Size(184, 23);
            this.ClientPortTxt.TabIndex = 21;
            // 
            // Sharebtn
            // 
            this.Sharebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sharebtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sharebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Sharebtn.Location = new System.Drawing.Point(19, 151);
            this.Sharebtn.Name = "Sharebtn";
            this.Sharebtn.Size = new System.Drawing.Size(110, 33);
            this.Sharebtn.TabIndex = 17;
            this.Sharebtn.Text = "Share Screen";
            this.Sharebtn.UseVisualStyleBackColor = true;
            this.Sharebtn.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(224, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sharebtn);
            this.Controls.Add(this.ConnectClientBtn);
            this.Controls.Add(this.ClientIP);
            this.Controls.Add(this.ClientIPTxt);
            this.Controls.Add(this.ClientPort);
            this.Controls.Add(this.ClientPortTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectClientBtn;
        private System.Windows.Forms.Label ClientIP;
        private System.Windows.Forms.TextBox ClientIPTxt;
        private System.Windows.Forms.Label ClientPort;
        private System.Windows.Forms.TextBox ClientPortTxt;
        private System.Windows.Forms.Button Sharebtn;
        private System.Windows.Forms.Timer timer1;
    }
}