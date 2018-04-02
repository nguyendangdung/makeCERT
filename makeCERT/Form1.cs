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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("batchfile1.bat")
            {
                UseShellExecute = false
            };

            Process batchProcess = new Process
            {
                StartInfo = processInfo
            };

            batchProcess.Start();

        }
    }
}
