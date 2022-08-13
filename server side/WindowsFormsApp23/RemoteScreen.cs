using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp23
{
    public partial class RemoteScreen : Form
    {
        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;
        public string ipv4 { get; set; }


        private readonly Thread Listening;
        private readonly Thread GetImage;


        public RemoteScreen(int Port = 443)
        {


            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            InitializeComponent();
            this.CenterToScreen();
            this.ShowInTaskbar = false;

            this.TopMost = true;

        }

        private void StartListening()
        {
            while (!(client.Connected))
            {
                server.Start(443);
                try
                {
                    client = server.AcceptTcpClient();
                }
                catch { }
            }
            GetImage.Start();

        }

        private void StopListening()
        {
            //server.Stop();
            //client.Close();
            client = null;
            if (Listening.IsAlive) Listening.Abort();
            if (GetImage.IsAlive) Listening.Abort();
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {

                while (true)
                {
                    try
                    {
                        if (client != null)
                        {
                            mainStream = client.GetStream();
                            mema.Image = (Image)binFormatter.Deserialize(mainStream);
                        }else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }catch
            {
                this.Close();
            }



        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Parse(ipv4), port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }





        private void RemoteScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                server.Stop();
                client.Close();
                client = null;
                server = null;
                if (Listening.IsAlive) Listening.Abort();
                if (GetImage.IsAlive) Listening.Abort();
                this.Close();
            }
            catch
            {
                MessageBox.Show("on the catch server side");
                this.Close();
            }
            
            
            
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (mouse.Text == "Change to zoom view")
            {
                mema.SizeMode = PictureBoxSizeMode.Zoom;
                mouse.Text = "Change to Stretch view";
            }
            else
            {
                mema.SizeMode = PictureBoxSizeMode.StretchImage;
                mouse.Text = "Change to zoom view";
            }
        }
    }
}
