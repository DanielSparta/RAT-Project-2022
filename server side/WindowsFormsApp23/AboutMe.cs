using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.fxp.co.il/member.php?u=1542650");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
