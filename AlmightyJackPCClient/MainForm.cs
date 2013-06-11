using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using AlmightyJackPCClient.Tools;

namespace AlmightyJackPCClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemCommandTester_Click(object sender, EventArgs e)
        {
            if (cmdTestFrm == null)
            {
                cmdTestFrm = new CmdTesterForm();
                cmdTestFrm.FormClosed += new FormClosedEventHandler(cmdTestFrm_FormClosed);
                cmdTestFrm.Show();
            }
            else
            {
                cmdTestFrm.BringToFront();
            }
        }

        private void ToolStripMenuItemSetting_Click(object sender, EventArgs e)
        {
            if (settingFrm == null)
            {
                settingFrm = new SettingsForm();
                settingFrm.FormClosed += new FormClosedEventHandler(settingFrm_FormClosed);
                settingFrm.Show();
            }
            else
            {
                settingFrm.BringToFront();
            }
        }

        private void cmdTestFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmdTestFrm.FormClosed -= new FormClosedEventHandler(cmdTestFrm_FormClosed);
            cmdTestFrm = null;
        }

        private void settingFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingFrm.FormClosed -= new FormClosedEventHandler(settingFrm_FormClosed);
            settingFrm = null;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseOtherForms();
        }

        private void CloseOtherForms()
        {
            if (settingFrm != null)
                settingFrm.Close();
            if (cmdTestFrm != null)
                cmdTestFrm.Close();
        }

        private void ToolStripMenuItemStartFWD_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = "cmd.exe";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            process.StartInfo = startInfo;
            process.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
            process.Start();
            process.BeginOutputReadLine();

            process.StandardInput.WriteLine(
                string.Format("adb forward tcp:{0} tcp:{1}",
                Properties.Settings.Default.PCPort,
                Properties.Settings.Default.PhonePort));
            process.Close();
        }

        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
            {
                Debug.WriteLine("Received null.");
            }
            else
            {
                Debug.WriteLine(e.Data);
            }
        }

        private SettingsForm settingFrm = null;
        private CmdTesterForm cmdTestFrm = null;
    }
}
