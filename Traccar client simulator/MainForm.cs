using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TraccarClientSimulator
{
    public partial class MainForm : Form
    {
        private object values;
        List<COORD_POINT> listCoord;

        public MainForm()
        {
            InitializeComponent();
        }

        public String GpxFileName = string.Empty;
        private void openGPXFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "GPX Files|*.gpx";
            openFileDialog1.Title = "Select a GPX File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GpxFileName = openFileDialog1.FileName;
                GPXLoader gpxlist = new GPXLoader();
                listCoord = new List<COORD_POINT>();

                // Load coordinates from file
                listCoord = gpxlist.Load_TP_coordinates(openFileDialog1.FileName);
                
                // Update datagridview
                dataGridView1.Rows.Clear();
                for (int i = 0; i < listCoord.Count; i++)
                    dataGridView1.Rows.Add(listCoord[i].lat, listCoord[i].lon);
            }
          
        }

        #region SETTINGS FORMS
        private void serverParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConf formServer = new ServerConf();
            var result = formServer.ShowDialog();
        }

        private void clientParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientConf formClient = new ClientConf();
            var result = formClient.ShowDialog();
        }

        #endregion SETTINGS FORMS


        private void button_start_Click(object sender, EventArgs e)
        {
            if (listCoord != null && listCoord.Count != 0)
            {
                timer_invio.Interval = Properties.Settings.Default.Client_Timer * 1000;
                timer_invio.Start();
            }
            else MessageBox.Show("Caricare un file delle coordinate");
        }

        #region TIMER

        int packetCount = 0;
        private void timer_invio_Tick(object sender, EventArgs e)
        {
            if (packetCount < listCoord.Count)
            {
                RestClient client = new RestClient();

                var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

                client.EndPoint = Properties.Settings.Default.Server_Name + ":" + Properties.Settings.Default.Server_Port;
                client.EndPoint += "/?id=" + Properties.Settings.Default.Client_ID; 
                client.EndPoint += "&lat=" + listCoord[packetCount].lat.ToString().Replace(',', '.');
                client.EndPoint += "&lon=" + listCoord[packetCount].lon.ToString().Replace(',', '.');
                dataGridView1.Rows[packetCount].Selected = true;

                // Extra parameters
                string extraParameters = string.Empty;

                if (checkBox_s1.Checked == true)
                    extraParameters += "&" + textBox_p1.Text + "=" + textBox_v1.Text;

                if (checkBox_s2.Checked == true)
                    extraParameters += "&" + textBox_p2.Text + "=" + textBox_v2.Text;

                if (checkBox_s3.Checked == true)
                    extraParameters += "&" + textBox_p3.Text + "=" + textBox_v3.Text;

                if (checkBox_s4.Checked == true)
                    extraParameters += "&" + textBox_p4.Text + "=" + textBox_v4.Text;

                client.MakeRequest(extraParameters);
                packetCount++;
            }
            else timer_invio.Stop();
        }

        #endregion TIMER


        private void directSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualSend F_ManualSend = new ManualSend();
            F_ManualSend.Show();
        }
    }
}
