
namespace ProjectLTUD
{
    partial class XO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiVớiNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiVớiMáyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Select";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiVớiNgườiToolStripMenuItem,
            this.chơiVớiMáyToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // chơiVớiNgườiToolStripMenuItem
            // 
            this.chơiVớiNgườiToolStripMenuItem.Name = "chơiVớiNgườiToolStripMenuItem";
            this.chơiVớiNgườiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.chơiVớiNgườiToolStripMenuItem.Text = "Play with people";
            this.chơiVớiNgườiToolStripMenuItem.Click += new System.EventHandler(this.chơiVớiNgườiToolStripMenuItem_Click);
            // 
            // chơiVớiMáyToolStripMenuItem1
            // 
            this.chơiVớiMáyToolStripMenuItem1.Name = "chơiVớiMáyToolStripMenuItem1";
            this.chơiVớiMáyToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.chơiVớiMáyToolStripMenuItem1.Text = "Play with AI";
            this.chơiVớiMáyToolStripMenuItem1.Click += new System.EventHandler(this.chơiVớiMáyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Leave";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlBanCo.BackgroundImage = global::ProjectLTUD.Properties.Resources.nen;
            this.pnlBanCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBanCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBanCo.Location = new System.Drawing.Point(0, 24);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(901, 602);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // XO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 626);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XO";
            this.Text = "XO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiVớiNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiVớiMáyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBanCo;
    }
}