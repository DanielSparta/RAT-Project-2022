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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace WindowsFormsApp26
{

    public partial class Paint : Form
    {
        
        Graphics draw;
        Pen my_pen;
        bool my_dots = true;
        int leaver = 0;
        public Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint iep;





        Socket client;

        public Paint()
        {

            

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = false;

            InitializeComponent();

            string path1 = @"C:\ip.txt";
            var fs = new FileStream(path1, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            string ipadd = sr.ReadToEnd();

            iep = new IPEndPoint(IPAddress.Parse(ipadd), 81);
            if (!(InvokeRequired))
            {
                draw = flowLayoutPanel1.CreateGraphics();
                draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                my_pen = new Pen(Color.Black, 3);
                my_pen.StartCap = my_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                my_dots = true;
            }
            else
            {
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    
                    draw = flowLayoutPanel1.CreateGraphics();
                    draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    my_pen = new Pen(Color.Black, 3);
                    my_pen.StartCap = my_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    my_dots = true;

                }));
            }
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {



            int i = 1;
            
            while (true)
            {

            again:
                if (i == 1)
                {

                    try
                    {
                        if (sck == null)
                        {
                            this.WindowState = FormWindowState.Minimized;
                            this.ShowInTaskbar = false;
                            this.Close();
                        }
                        else
                        {
                            sck.Connect(iep);
                            i--;
                        }
                    }catch
                    {
                        goto again;
                    }
                }


                try
                {

                againn:


                    if (sck != null)
                    {

                        int size1 = 0;
                        byte[] buffer1 = new byte[1024];
                        size1 = sck.Receive(buffer1);
                        string pen_x = Encoding.ASCII.GetString(buffer1, 0, size1);






                        if (pen_x == "clear")
                        {
                            pen_x = null;
                            draw.Clear(BackColor);
                            goto againn;
                        }

                        if (pen_x == "exit")
                        {
                            try
                            {
                                pen_x = null;
                                sck.Close();
                                sck = null;
                                leaver++;
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                                this.Close();
                                break;

                            }
                            catch {
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                                this.Close(); break; }
                        }


                        sck.Send(Encoding.ASCII.GetBytes(" "));

                        int size2 = 0;
                        byte[] buffer2 = new byte[1024];
                        size2 = sck.Receive(buffer2);
                        string pen_y = Encoding.ASCII.GetString(buffer2, 0, size2);

                        if (pen_y == "exit")
                        {
                            try
                            {
                                pen_x = null;
                                sck.Close();
                                sck = null;
                                leaver++;
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                                this.Close();
                                break;

                            }
                            catch {
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false; this.Close(); break; }
                        }

                        sck.Send(Encoding.ASCII.GetBytes(" "));

                        int size3 = 0;
                        byte[] buffer3 = new byte[1024];
                        size3 = sck.Receive(buffer3);
                        string loc = Encoding.ASCII.GetString(buffer3, 0, size3);

                        if (loc == "exit")
                        {
                            try
                            {
                                pen_x = null;
                                sck.Close();
                                sck = null;
                                leaver++;
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                                this.Close();
                                break;

                            }
                            catch {
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false; this.Close(); break; }
                        }

                        var myStringWhichCantBeChanged = loc;
                        var g = Regex.Replace(myStringWhichCantBeChanged, @"[\{\}a-zA-Z=]", "").Split(',');

                        Point locaxx = new Point(int.Parse(g[0]), int.Parse(g[1]));


                        draw.DrawLine(my_pen, new Point(int.Parse(pen_x), int.Parse(pen_y)), locaxx);


                        pen_x = null;
                        pen_y = null;


                    }


                }
                catch { i++; }
            }
            try
            {
                sck = null;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.Close();
                
            }
            catch
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.Close();
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(sck.Connected))
            {

                try
                {
                    if (sck != null)
                    {
                        sck.Close();
                        this.WindowState = FormWindowState.Minimized;
                        this.ShowInTaskbar = false;
                        this.Close();
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Minimized;
                        this.ShowInTaskbar = false;
                        this.Close();
                    }
                }
                catch
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Dumb kid, you can close the window only if the another script kid that control your computer close the connection. (in fact you can disconnect from wifi yourself.)");
            }
        }
    }
}
