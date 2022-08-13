using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class taskbar : Form
    {
        public Socket clientToSend { get; set; }

        public taskbar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_lock"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_top"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_down"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_right"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_left"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskbar_unlock"));
        }
    }
}
