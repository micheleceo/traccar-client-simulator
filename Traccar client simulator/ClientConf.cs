using System;
using System.Windows.Forms;

namespace TraccarClientSimulator
{
    /// <summary>
    /// Traccar client configuration
    /// </summary>
    public partial class ClientConf : Form
    {
        public ClientConf()
        {
            InitializeComponent();
            textBox_ID.Text = Properties.Settings.Default.Client_ID;
            textBox_UserName.Text = Properties.Settings.Default.Client_UserName;
            textBox_Password.Text = Properties.Settings.Default.Client_Password;
            textBox_timer.Text = Properties.Settings.Default.Client_Timer.ToString();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Client_ID = textBox_ID.Text;
            Properties.Settings.Default.Client_UserName = textBox_UserName.Text;
            Properties.Settings.Default.Client_Password = textBox_Password.Text;
            if (Int32.TryParse(textBox_timer.Text, out int timer))
                Properties.Settings.Default.Client_Timer = timer;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
