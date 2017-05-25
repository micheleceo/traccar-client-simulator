using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraccarClientSimulator
{
    public partial class ManualSend : Form
    {
        public ManualSend()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            
            RestClient client = new RestClient();

            client.EndPoint = Properties.Settings.Default.Server_Name + ":" + Properties.Settings.Default.Server_Port + textBox_request.Text;

            var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;


            string extraParameters = string.Empty;

            textBox_Response.Text = client.MakeRequest(extraParameters);
        }
    }
}
