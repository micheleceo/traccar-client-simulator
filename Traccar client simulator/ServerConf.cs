using System;
using System.Windows.Forms;

namespace TraccarClientSimulator
{
    /// <summary>
    /// Traccar server configuration
    /// </summary>
    public partial class ServerConf : Form
    {
        public ServerConf()
        {
            InitializeComponent();
            textBox_ServeName.Text = Properties.Settings.Default.Server_Name;
            textBox_ServerPort.Text = Properties.Settings.Default.Server_Port;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server_Name = textBox_ServeName.Text;
            Properties.Settings.Default.Server_Port = textBox_ServerPort.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
