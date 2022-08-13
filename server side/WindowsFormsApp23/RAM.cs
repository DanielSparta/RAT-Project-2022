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
using System.Threading;

namespace WindowsFormsApp23
{
    public partial class RAM : Form
    {
        public string ip3 { get; set; }
        public Socket clientToSend { get; set; }
        public string newLine { get; set; }
        public string publicIP { get; set; }
        public Socket client { get; set; }
        public Thread treadd;

        public RAM()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;



        }

        private void RAM_Load(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Sent.";
            MessageBox.Show("Sent.");
            clientToSend.Send(Encoding.ASCII.GetBytes(input.Text));
            this.Close();


        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                clientToSend.Send(Encoding.ASCII.GetBytes("stopp"));
            }
            catch { }
        }

        
    }
}
