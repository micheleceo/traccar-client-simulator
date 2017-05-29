using System;
using System.Text;
using System.Windows.Forms;

namespace TraccarClientSimulator
{
     public partial class ManualSend : Form
    {
        public struct request_parameters
        {
            public string server;
            public string port;
            public string id;
            public string timestamp;
            public string lat;
            public string lon;
            public string altitude;
            public string bearing;
            public string batt;
            public string speed;
        }
        request_parameters req;

        //  string sampleString = "http://localhost:5055/?id=111111&timestamp=1495181394&lat=40.9948996&lon=17.222538900000018&speed=0&bearing=355.43&altitude=111.379&batt=11";
        string request_str = string.Empty;
      
        public ManualSend()
        {
            InitializeComponent();
           
            req.server = Properties.Settings.Default.Server_Name;
            req.port = Properties.Settings.Default.Server_Port;
            req.id = Properties.Settings.Default.Client_ID;
            req.lat = Properties.Settings.Default.Client_lat;
            req.lon = Properties.Settings.Default.Client_lon;
            req.altitude = Properties.Settings.Default.Client_altitude;
            req.bearing = Properties.Settings.Default.Client_bearing;
            req.batt = Properties.Settings.Default.Client_lon;
            req.speed = Properties.Settings.Default.Client_lon;
        }


        private void button_send_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();

            client.EndPoint = textBox_request.Text;

            textBox_Response.Text = client.MakeRequest(client.EndPoint);
        }


        private string updateTime()
        {
          double totalSecond = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
          return ((int)totalSecond).ToString();
        }

        private void ManualSend_Load(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(req.server);
            builder.Append(":");
            builder.Append(req.port);
            builder.Append("/?id=").Append(req.id);
            req.timestamp = updateTime();
            builder.Append("&timestamp=").Append(req.timestamp);
            builder.Append("&lat=").Append(req.lat);
            builder.Append("&lon=").Append(req.lon);
            builder.Append("&speed=").Append(req.speed);
            builder.Append("&bearing=").Append(req.bearing);
            builder.Append("&altitude=").Append(req.altitude);
            builder.Append("&batt=").Append(req.batt);
            textBox_request.Text = builder.ToString();
        }


    }
}
