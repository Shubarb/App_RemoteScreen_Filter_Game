using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectLTUD
{
    public partial class SelectServerClient : Form
    {
        public SelectServerClient()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            //Server f3 = new Server();
            //this.Hide();
            // KTCancel = false;
            //f3.ShowDialog();

            
            Server ser_vrb = new Server() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ser_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlSeclect.Controls.Add(ser_vrb);
            ser_vrb.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client f4 = new Client() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f4.FormBorderStyle = FormBorderStyle.None;
            this.pnlSelect2.Controls.Add(f4);
            f4.Show();
        }
    }
}
