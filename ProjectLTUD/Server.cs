using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

namespace ProjectLTUD
{
    public partial class Server : Form
    {   
        public Server()
        {
            InitializeComponent();
        }

        private void ListenBtn_Click(object sender, EventArgs e)
        {

            new Screens(int.Parse(ServerPortTxt.Text)).Show();
            ListenBtn.Enabled = false;
        }
    }
}
