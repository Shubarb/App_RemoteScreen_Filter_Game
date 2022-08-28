
namespace ProjectLTUD
{
    partial class SelectServerClient
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
            this.Server = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.pnlSeclect = new System.Windows.Forms.Panel();
            this.pnlSelect2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.BackColor = System.Drawing.Color.MidnightBlue;
            this.Server.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Server.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Server.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Server.Location = new System.Drawing.Point(93, 22);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(381, 250);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = false;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.Color.MidnightBlue;
            this.Client.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Client.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Client.Location = new System.Drawing.Point(775, 22);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(381, 250);
            this.Client.TabIndex = 0;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // pnlSeclect
            // 
            this.pnlSeclect.Location = new System.Drawing.Point(93, 368);
            this.pnlSeclect.Name = "pnlSeclect";
            this.pnlSeclect.Size = new System.Drawing.Size(342, 301);
            this.pnlSeclect.TabIndex = 1;
            // 
            // pnlSelect2
            // 
            this.pnlSelect2.Location = new System.Drawing.Point(814, 368);
            this.pnlSelect2.Name = "pnlSelect2";
            this.pnlSelect2.Size = new System.Drawing.Size(342, 301);
            this.pnlSelect2.TabIndex = 1;
            // 
            // SelectServerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlSeclect);
            this.Controls.Add(this.pnlSelect2);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectServerClient";
            this.Text = "SelectServerClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Server;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Panel pnlSeclect;
        private System.Windows.Forms.Panel pnlSelect2;
    }
}