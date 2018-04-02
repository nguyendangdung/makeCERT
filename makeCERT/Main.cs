using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace makeCERT
{
    public partial class Main : Form
    {
        private string _hostName = "example";
        private string _email = "webmaster@example.com";
        private string batText = @"
@echo off

REM IN YOUR SSL FOLDER, SAVE THIS FILE AS: makeCERT.bat
REM AT COMMAND LINE IN YOUR SSL FOLDER, RUN: makecert
REM IT WILL CREATE THESE FILES: example.cnf, example.crt, example.key
REM IMPORT THE .crt FILE INTO CHROME Trusted Root Certification Authorities
REM REMEMBER TO RESTART APACHE OR NGINX AFTER YOU CONFIGURE FOR THESE FILES

REM PLEASE UPDATE THE FOLLOWING VARIABLES FOR YOUR NEEDS.
SET HOSTNAME={0}
SET DOT=com
SET COUNTRY=US
SET STATE=KS
SET CITY=Olathe
SET ORGANIZATION=IT
SET ORGANIZATION_UNIT=IT Department
SET EMAIL={1}

(
echo [req]
echo default_bits = 2048
echo prompt = no
echo default_md = sha256
echo x509_extensions = v3_req
echo distinguished_name = dn
echo:
echo [dn]
echo C = %COUNTRY%
echo ST = %STATE%
echo L = %CITY%
echo O = %ORGANIZATION%
echo OU = %ORGANIZATION_UNIT%
echo emailAddress = %EMAIL%
echo CN = %HOSTNAME%.%DOT%
echo:
echo [v3_req]
echo subjectAltName = @alt_names
echo:
echo [alt_names]
echo DNS.1 = *.%HOSTNAME%.%DOT%
echo DNS.2 = %HOSTNAME%.%DOT%
)>%HOSTNAME%.cnf

openssl req -new -x509 -newkey rsa:2048 -sha256 -nodes -keyout %HOSTNAME%.key -days 3560 -out %HOSTNAME%.crt -config %HOSTNAME%.cnf
";
        public Main()
        {
            InitializeComponent();
            hostNameTextBox.Text = _hostName;
            emailTextBox.Text = _email;
        }

        Process process;
        private void genCertBtn_Click(object sender, EventArgs e)
        {
            process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "cmd";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();

            process.StandardInput.Write(string.Format(batText, _hostName, _email));
        }
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string line;
            while (!process.StandardOutput.EndOfStream)
            {
                line = process.StandardOutput.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    SetText(line);
                }
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.consoleTxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.consoleTxt.Text += text + Environment.NewLine;
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null)
            {
                process.StandardInput.WriteLine("exit");
                process.Close();
            }
        }

        private void hostNameTxt_TextChanged(object sender, EventArgs e)
        {
            _hostName = hostNameTextBox.Text;
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            _email = emailTextBox.Text;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
