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
    public partial class ScreenLock : Form
    {
        public Socket clientToSend { get; set; }

        public ScreenLock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passkey = key.Text;
            clientToSend.Send(Encoding.ASCII.GetBytes("lock " + passkey + "1"));
            MessageBox.Show("Key sent succesfuly, client has been locked.");
        }
    }
}
