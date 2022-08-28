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
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjectLTUD
{
    public partial class Client : Form
    {
        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber;

        private static Image GrabDesktop()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        private void SendDesktopImage()
        {

            BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            binFormatter.Serialize(mainStream, GrabDesktop());

        }

        public Client()
        {
            InitializeComponent();
        }
        private void Client_Load(object sender, EventArgs e)
        {
            Sharebtn.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            portNumber = int.Parse(ClientPortTxt.Text);
            try
            {
                client.Connect(ClientIPTxt.Text, portNumber);
                ConnectClientBtn.Text = "Connected";
                // btnConnect.Enabled = false;
                // btnConnect.ForeColor = Color.White;
                MessageBox.Show("Connected");
                ConnectClientBtn.Enabled = false;
                Sharebtn.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect..");
                ConnectClientBtn.Text = "Not Connected";
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (Sharebtn.Text.StartsWith("Share"))
            {
                timer1.Start();
                Sharebtn.Text = "Stop Sharing";
            }
            else
            {
                timer1.Stop();
                Sharebtn.Text = "Share My Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }


    }

}
