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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace WindowsFormsApp23
{
    public partial class testPaint : Form
    {
        // Variables

        public string ipv4 { get; set; }

        public string penx;
        public string peny;
        public string penl;
        public Socket tosa;

        public int leaver = 0;

        Graphics draw;
        int pen_x = -1, pen_y = -1;
        public string panx;
        public string pany;
        bool pen_moving = false;
        Pen my_pen;
        bool my_dots = true;

        Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint iep;


        Point location;



        public testPaint()
        {



            this.TopMost = false;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            iep = new IPEndPoint(IPAddress.Parse(ipv4), 81);
            sck.Bind(iep);
            sck.Listen(400);
            if (tosa == null)
                tosa = sck.Accept();

            draw = flowLayoutPanel1.CreateGraphics();
            draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            my_pen = new Pen(Color.Black, 3);
            my_pen.StartCap = my_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            my_dots = true;
            my_pen.Width = 8;




        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            pen_moving = true;
            my_pen.Width = 8;
            pen_x = e.X;
            pen_y = e.Y;

        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen_moving && pen_moving && pen_x != -1 && pen_y != -1)
            {

                try
                {
                    

                    location = e.Location;

                    penx = null;
                    peny = null;
                    penl = null;
                    penx = pen_x.ToString();
                    peny = pen_y.ToString();
                    pen_x = e.X;
                    pen_y = e.Y;
                    penl = location.ToString();

                    sendingpaints();



                    draw.DrawLine(my_pen, new Point(int.Parse(penx), int.Parse(peny)), location);



                    //       BinaryFormatter binFormatter = new BinaryFormatter();

                }
                catch
                { }
            }








        }



        public dynamic sendingpaints()
        {

            int x = 5;

            try
            {

                if (!(InvokeRequired))
                {
                    if (tosa.Connected)
                    {

                        if (leaver == 1)
                        {
                            tosa.Send(Encoding.ASCII.GetBytes("exit"));
                            tosa.Close();
                            tosa = null;
                            this.Close();
                        }

                        if (leaver == 0)
                        {

                            tosa.Send(Encoding.ASCII.GetBytes(penx));

                            byte[] buffer1 = new byte[1024];
                            tosa.Receive(buffer1);

                            Thread.Sleep(10);
                            tosa.Send(Encoding.ASCII.GetBytes(peny));

                            byte[] buffer2 = new byte[1024];
                            tosa.Receive(buffer2);

                            Thread.Sleep(10);
                            tosa.Send(Encoding.ASCII.GetBytes(penl));
                        }
                    }
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)(() =>
                    {

                        if (leaver == 1)
                        {
                            tosa.Send(Encoding.ASCII.GetBytes("exit"));
                            tosa.Close();
                            tosa = null;
                            this.Close();
                        }

                    }));
                }
                
                return x;
            }
            catch
            {
                return x;
            }

        }


        private void Dots_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            draw.Clear(BackColor);
            tosa.Send(Encoding.ASCII.GetBytes("clear"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            my_pen = new Pen(Color.White, 3);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            my_pen = new Pen(Color.Black, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            my_pen = new Pen(Color.Red, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tosa.Connected)
            {
                try
                {
                    tosa.Send(Encoding.ASCII.GetBytes("exit"));
                    Thread.Sleep(50);
                    tosa.Close();
                    sck.Close();
                    this.Close();
                }
                catch
                {
                    sck.Close();
                    this.Close();
                }
            }
            else
                tosa.Close();
            sck.Close();
                this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {

                try
                {
                    sck.Send(Encoding.ASCII.GetBytes(" "));
                }catch
                {
                    this.Close();
                    sck.Close();
                    tosa.Close();
                    MessageBox.Show("Client disconnected.");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            try
            {

                sck.Close();
                tosa.Close();

            }catch
            { }
        }

            private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {

            pen_moving = false;
            pen_x = -1;
            pen_y = -1;

        }
    }
}
