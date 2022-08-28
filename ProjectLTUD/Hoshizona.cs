using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectLTUD
{
    public partial class Hoshizona : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
 (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse

 );
        public Hoshizona()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = Homebtn.Height;
            pnlNav.Top = Homebtn.Top;
            pnlNav.Left = Homebtn.Left;

            lbTitle.Text = "Home";
            Home home_vrb = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(home_vrb);
            home_vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Homebtn.Height;
            pnlNav.Top = Homebtn.Top;
            pnlNav.Left = Homebtn.Left;
            Homebtn.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Home";
            this.pnlMain.Controls.Clear();
            Home home_vrb = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(home_vrb);
            home_vrb.Show();
        }

        private void TeamViewbtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Homebtn.Height;
            pnlNav.Top = Homebtn.Top;
            pnlNav.Left = Homebtn.Left;
            Homebtn.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Select Server Client";
            this.pnlMain.Controls.Clear();
            SelectServerClient sc_vrb = new SelectServerClient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sc_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(sc_vrb);
            sc_vrb.Show();
        }

        private void Gamebtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Gamebtn.Height;
            pnlNav.Top = Gamebtn.Top;
            pnlNav.Left = Gamebtn.Left;
            Gamebtn.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Game";
            this.pnlMain.Controls.Clear();
            Game game_vrb = new Game() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            game_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(game_vrb);
            game_vrb.Show();
        }

        private void ContactUsbtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = ContactUsbtn.Height;
            pnlNav.Top = ContactUsbtn.Top;
            pnlNav.Left = ContactUsbtn.Left;
            ContactUsbtn.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Contact Us";
            this.pnlMain.Controls.Clear();
            ContactUs contact_vrb = new ContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            contact_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(contact_vrb);
            contact_vrb.Show();
        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Filterbtn.Height;
            pnlNav.Top = Filterbtn.Top;
            pnlNav.Left = Filterbtn.Left;
            Filterbtn.BackColor = Color.FromArgb(46, 51, 73);
            lbTitle.Text = "Filter";
            this.pnlMain.Controls.Clear();
            Filter filter_vrb = new Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            filter_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(filter_vrb);
            filter_vrb.Show();
        }

        private void Homebtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void TeamViewbtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Gamebtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Filterbtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void ContactUsbtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Settingbtn_Leave(object sender, EventArgs e)
        {
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
