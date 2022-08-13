using System.Diagnostics;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp23
{
    public partial class taskmanager : Form
    {
        public Socket clientToSend { get; set; }
        public int i = 0;
        int leaver = 0;

        public taskmanager()
        {
            InitializeComponent();
            this.listView1.ColumnWidthChanging += new ColumnWidthChangingEventHandler(listView1_ColumnWidthChanging);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }




        private void taskmanager_Load(object sender, EventArgs e)
        {
            clientToSend.Send(Encoding.ASCII.GetBytes("taskmgr"));
            if (!(InvokeRequired))
            {

                backgroundWorker1.RunWorkerAsync();
            }
        }





        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                string selectitem = listView1.SelectedItems[0].ToString();
                
                int g1 = selectitem.IndexOf("ListViewItem {") + 16;
                int g2 = selectitem.LastIndexOf("}");
                string selecteditem = selectitem.Substring(g1, g2 - g1);

                clientToSend.Send(Encoding.ASCII.GetBytes("murder" + selecteditem + "1"));

            }
            catch
            { }

            
        }



        private void MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip1.ShowImageMargin = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            //contextMenuStrip1.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] proc;

            proc = Process.GetProcesses();
            listView1.Items.Clear();
            int i = 0;
            foreach (Process p in proc)
            {

                listView1.Items.Add(p.ProcessName);
                label1.Text = i++.ToString();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
        }
        

       
            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket mysocket = clientToSend;


                int size = 1;
                byte[] buffer;
                         buffer = new byte[1024];
        again:
                          size = mysocket.Receive(buffer);
                    
                   
                string output = Encoding.ASCII.GetString(buffer, 0, size);
            i += 1;
            this.BeginInvoke((MethodInvoker)(() => label1.Text = i.ToString()));
            if (!InvokeRequired)
                listView1.Items.Add(output);
            else
                this.BeginInvoke((MethodInvoker)(() => listView1.Items.Add(output)));
            
            goto again;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            i = 0;
            listView1.Items.Clear();
            clientToSend.Send(Encoding.ASCII.GetBytes("taskmgr"));
        }
    }
}