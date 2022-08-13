using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Chat : Form
    {
        public Socket sck { get; set; }
        string newLine = Environment.NewLine;

        public Chat()
        {
            InitializeComponent();
            receive.ReadOnly = true;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            reader.RunWorkerAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toSend = send.Text;
            try
            {
                receive.Text += "You: " + toSend + newLine;
                sck.Send(Encoding.ASCII.GetBytes(toSend));
                sck.Send(Encoding.ASCII.GetBytes(toSend));
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
                this.Close();
            }
        }

        private void reader_DoWork(object sender, DoWorkEventArgs e)
        {
            int size = 0;
            byte[] receiver = new byte[1024];
            
            while(sck.Connected)
            {
                try
                {
                    size = sck.Receive(receiver);
                    string message = Encoding.ASCII.GetString(receiver, 0, size);
                    if (message != "SecretBreak")
                    {
                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            if(message != "" && message != " ")
                            receive.Text += "Hacker: " + message + newLine;
                            send.Text = "";
                        }));

                    }
                    else
                    {
                        if (!InvokeRequired)
                        {
                            send.Visible = false;
                        }
                        MessageBox.Show("Server has been closed the chat.");
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }
            try
            {
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    this.Close();
                    send.Visible = false;
                }));
            }
            catch { }
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
