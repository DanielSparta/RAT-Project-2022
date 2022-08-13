using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (light.Text == "Off")
            {
                try
                {
                    string fullPath = @"C://theme.txt";
                    using (StreamWriter sw = File.CreateText(fullPath));

                        File.WriteAllText(fullPath, String.Empty);
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {
                        writer.Write("darkTheme");
                    }
                }
                catch { }
                
            }

            if (light.Text == "On")
            {
                try
                {
                    string fullPath = @"C://theme.txt";
                    using (StreamWriter sw = File.CreateText(fullPath)) ;

                        File.WriteAllText(fullPath, String.Empty);
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {
                        writer.Write("lightTheme");
                    }
                }
                catch { }

        }
            MessageBox.Show("restart the application so the theme color will change.");
            this.Close();
        }
    }
}
