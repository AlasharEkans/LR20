using System;
using System.Drawing;
using System.Windows.Forms;

namespace UdpChat
{
    public partial class SettingsForm : Form
    {
        public int LocalPort { get; private set; }
        public int RemotePort { get; private set; }
        public string Host { get; private set; }
        public Font ChatFont { get; private set; }

        public SettingsForm(int localPort, int remotePort, string host, Font chatFont)
        {
            InitializeComponent();
            LocalPort = localPort;
            RemotePort = remotePort;
            Host = host;
            ChatFont = chatFont;

            localPortTextBox.Text = LocalPort.ToString();
            remotePortTextBox.Text = RemotePort.ToString();
            hostTextBox.Text = Host;
            fontTextBox.Text = chatFont.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(localPortTextBox.Text, out int localPort) &&
                int.TryParse(remotePortTextBox.Text, out int remotePort))
            {
                LocalPort = localPort;
                RemotePort = remotePort;
                Host = hostTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильні значення для портів.");
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    ChatFont = fontDialog.Font;
                    fontTextBox.Text = ChatFont.Name;
                }
            }
        }
    }
}