using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form2 : Form
    {
        public string key { get; set; }

        public Form2()
        {
            InitializeComponent();
            locked.Left = (this.ClientSize.Width - locked.Size.Width) / 2;
            this.WindowState = FormWindowState.Maximized;
            timer1.Enabled = true;
            this.TopMost = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (unlock_btn.Left < this.Width) //התחלת עידן הריינבו
            {
                unlock_btn.Left += 5;
            }
            else
            {
                unlock_btn.Left = -120;
            }

            if (unlock_text.Left < this.Width)
            {
                unlock_text.Left += 5;
            }
            else
            {
                unlock_text.Left = -120;
            }

            if (unlock_label.Left < this.Width)
            {
                unlock_label.Left += 5;
            }
            else
            {
                unlock_label.Left = -120;
            }
        }

        private void unlock_btn_Click(object sender, EventArgs e)
        {
            if (unlock_text.Text == key)
            {
                this.Close();
            }
        }
    }
}
