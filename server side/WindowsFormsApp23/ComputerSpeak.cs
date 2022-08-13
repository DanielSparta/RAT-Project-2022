using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace WindowsFormsApp23
{
    public partial class ComputerSpeak : Form
    {

        public Socket clientToSend { get; set; }

        public ComputerSpeak()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ComputerSpeak_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string toSend2 = "voice " + textBox1.Text + "1";
                byte[] Message2 = System.Text.Encoding.ASCII.GetBytes(toSend2);
                clientToSend.Send(Message2);
                toSend2 = null;

            }
            catch
            {
                //הצד לקוח התנתק

            }


            button1.Text = "Sent.";
            

        }
    }
}
