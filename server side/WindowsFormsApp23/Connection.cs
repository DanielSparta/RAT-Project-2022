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

namespace WindowsFormsApp23
{
    public partial class Connection : Form
    {
        public string username { get; set; }
        public string ipaddress { get; set; }

        public Connection()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.ShowInTaskbar = false;
            this.TopMost = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            text.Text = ipaddress + ", " + username;
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 10; i>=0; i--)
            {
                Thread.Sleep(1000);
                if (!(InvokeRequired))
                    timer.Text = i.ToString();
                else
                    this.BeginInvoke((MethodInvoker)(() => timer.Text = i.ToString()));
                if (i == 0)
                {
                    if (!(InvokeRequired))
                        this.Close();
                    else
                        this.BeginInvoke((MethodInvoker)(() => this.Close()));
                }

            }
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }
    }
}
