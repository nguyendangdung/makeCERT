using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace converCERT
{
    public partial class Main : Form
    {
        //private string cmd = "openssl pkcs12 -export -out domain.name.pfx -inkey domain.name.key -in domain.name.crt";
        private string cmd = "openssl pkcs12 -export -out {0} -inkey {1} -in {2}";
        private string _cert;
        string _key;
        Process process;
        public Main()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            var outFile = $"{Path.GetFileNameWithoutExtension(_key)}.pfx";

            process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "cmd";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();

            process.StandardInput.Write(string.Format(cmd, _key, _cert));
        }

        private void certBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _cert = openFileDialog.FileName;
                certTxt.Text = _cert;
            }
        }

        private void keyBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _key = openFileDialog.FileName;
                keyTxt.Text = _key;
            }
        }
    }
}
