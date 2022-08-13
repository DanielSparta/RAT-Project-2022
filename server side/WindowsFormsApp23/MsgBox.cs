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
    public partial class MsgBox : Form
    {

        public Socket clientToSend { get; set; }

        public MsgBox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }

        private void ComputerSpeak_Load(object sender, EventArgs e)
        {

        }


        


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                string toSend2 = "mess " + textBox1.Text + "1";
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
