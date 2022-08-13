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

namespace WindowsFormsApp23
{
    public partial class Chat : Form
    {

        public Socket clientToSend { get; set; }
        public byte[] receiver;
        string newLine = Environment.NewLine;
        public Chat()
        {
            InitializeComponent();
            receive.ReadOnly = true;
            reader.RunWorkerAsync();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toSend = send.Text;
            try
            {
                receive.Text += "You: " + toSend + newLine;
                clientToSend.Send(Encoding.ASCII.GetBytes(toSend));
            }
            catch
            {
                MessageBox.Show("Lost connection.");
                this.Close();
            }
        }

        private void reader_DoWork(object sender, DoWorkEventArgs e)
        {
            int size = 0;
            try
            {
                receiver = new byte[1024];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            while (clientToSend.Connected)
            {
                try
                {
                    size = clientToSend.Receive(receiver);
                    string message = Encoding.ASCII.GetString(receiver, 0, size);
                    this.BeginInvoke((MethodInvoker)(() =>
                    {
                        receive.Text += "Client: " + message + newLine;
                        send.Text = "";
                    }));
                }
                catch
                {
                    break;
                }
            }
            this.Close();
            MessageBox.Show("Lost connection.");
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!InvokeRequired)
            {
                clientToSend.Send(Encoding.ASCII.GetBytes("SecretBreak"));
                clientToSend.Send(Encoding.ASCII.GetBytes("SecretBreak"));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    clientToSend.Send(Encoding.ASCII.GetBytes("SecretBreak"));
                    clientToSend.Send(Encoding.ASCII.GetBytes("SecretBreak"));
                }));
            }
            
        }
    }
}