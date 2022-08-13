using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Alert : Form
    {
        public Alert()
        {
            this.TopMost = true;
            this.ShowInTaskbar = false;
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {

                    this.Text = "sparta. RAT";
                    Thread.Sleep(100);
                    this.Text = "sParta. RAT";
                    Thread.Sleep(100);
                    this.Text = "spArta. RAT";
                    Thread.Sleep(100);
                    this.Text = "spaRta. RAT";
                    Thread.Sleep(100);
                    this.Text = "sparTa. RAT";
                    Thread.Sleep(100);
                    this.Text = "spartA. RAT";
                    Thread.Sleep(100);
                    this.Text = "sparTa. RAT";
                    Thread.Sleep(100);
                    this.Text = "spaRta. RAT";
                    Thread.Sleep(100);
                    this.Text = "spArta. RAT";
                    Thread.Sleep(100);
                    this.Text = "sParta. RAT";
                    Thread.Sleep(100);
                    this.Text = "Sparta. RAT";
                    Thread.Sleep(100);

                });
            }
            catch { }
            backgroundWorker1.CancelAsync();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fxp.co.il/member.php?u=1542650");
        }
    }
}
