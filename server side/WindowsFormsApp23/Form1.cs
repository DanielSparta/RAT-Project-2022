using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Threading;

namespace WindowsFormsApp23
{
    public partial class HallOfFrame : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();


        public HallOfFrame()
        {

            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.CenterToScreen();

            player.URL = @"https://myproject054.000webhostapp.com/EkolokoGrintiligentia.mp4";
            axWindowsMediaPlayer1.Visible = false;



        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.RunWorkerAsync();
            moveTimer.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fxp.co.il/member.php?u=1542650");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            backgroundWorker2.CancelAsync();
            player.controls.stop();
            player.URL = @"";
            string fullPath = @"C://text.txt";

            File.WriteAllText(fullPath, String.Empty);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write("play");
            }
        }


        private void moveTimer_Tick(object sender, EventArgs e)
        {


            if (rainbow.Left < this.Width) //התחלת עידן הריינבו
            {
                rainbow.Left += 5;
            }
            else
            {
                rainbow.Left = -120;
            }

            if (rainbowtext.Left < this.Width)
            {
                rainbowtext.Left += 5;
            }
            else
            {
                rainbowtext.Left = -120;
            } // סוף עידן הריינבו




            if (ExploticsIMG.Left < this.Width) //התחלת עידן האקספלוטיקס
            {
                ExploticsIMG.Left += 5;
            }
            else
            {
                ExploticsIMG.Left = -120;
            }

            if (ExploticsText.Left < this.Width)
            {
                ExploticsText.Left += 5;
            }
            else
            {
                ExploticsText.Left = -120;
            } // סוף עידן האקספלוטיקס



            if (yoyoshIMG.Left < this.Width) //התחלת עידן היויוש
            {
                yoyoshIMG.Left += 5;
            }
            else
            {
                yoyoshIMG.Left = -120;
            }

            if (yoyoshTEXT.Left < this.Width)
            {
                yoyoshTEXT.Left += 5;
            }
            else
            {
                yoyoshTEXT.Left = -120;
            } // סוף עידן היויוש


            if (erezIMG.Left < this.Width) //התחלת עידן הארז
            {
                erezIMG.Left += 5;
            }
            else
            {
                erezIMG.Left = -120;
            }

            if (erezTEXT.Left < this.Width)
            {
                erezTEXT.Left += 5;
            }
            else
            {
                erezTEXT.Left = -120;
            } // סוף עידן הארז

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void yoyoshIMG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fxp.co.il/member.php?u=726753");
        }

        private void erezIMG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/erezshl");


        }

        private void ExploticsIMG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fxp.co.il/member.php?u=891751");
        }

        private void rainbow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fxp.co.il/member.php?u=424137");
        }



        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
                try
                {
                    player.controls.play();
                }catch
                {
                    this.Close();
                    System.Diagnostics.Process.Start("shutdown", "/s /t 10");
                    MessageBox.Show("Entering this page without sound is like not respecting these people, your computer will shut down in the next few seconds.");
                }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
