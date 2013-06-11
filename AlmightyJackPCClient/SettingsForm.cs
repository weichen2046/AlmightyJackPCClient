using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlmightyJackPCClient
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            int phone = Properties.Settings.Default.PhonePort;
            int pc = Properties.Settings.Default.PCPort;

            if ( phone < 1024)
            {
                phone = DEFAULT_PHONE_PORT;
            }

            if ( pc < 1024)
            {
                pc = DEFAULT_PC_PORT;
            }

            this.txbPhonePort.Text = phone.ToString();
            this.txbPCPort.Text = pc.ToString();
        }

        private void btnSetOK_Click(object sender, EventArgs e)
        {
            int phone;
            int pc;
            if (!int.TryParse(txbPhonePort.Text, out phone))
            {
                phone = DEFAULT_PHONE_PORT;
            }
            if (!int.TryParse(txbPCPort.Text, out pc))
            {
                pc = DEFAULT_PC_PORT;
            }

            Properties.Settings.Default.PhonePort = phone;
            Properties.Settings.Default.PCPort = pc;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private const int DEFAULT_PHONE_PORT = 8989;
        private const int DEFAULT_PC_PORT = 12580;
    }
}
