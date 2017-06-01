using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.ComponentModel;


namespace TraccarClientSimulator
{
    public partial class ManualSend : Form
    {
        request_parameters req;

        string request_str = string.Empty;
      
        /// <summary>
        /// Implementing manual send requests with manual button press
        /// </summary>
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


        private void ManualSend_Load(object sender, EventArgs e)
        {
            textBox_request.Text = URI_build();
        }


        #region BUTTTONS

        private void button_send_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.EndPoint = textBox_request.Text;
            textBox_Response.Text = client.MakeRequest(client.EndPoint);
        }

        private void buttonGetDevices_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.EndPoint = "http://localhost:8082/api/devices/";
            textBox_Response.Text = client.MakeRequest(client.EndPoint);

            List<Device> dispositivi = JsonConvert.DeserializeObject<List<Device>>(textBox_Response.Text);

            var list = new BindingList<Device>(dispositivi);
            dataGridView_Devices.DataSource = list;
        }

        private void button_GetUsersList_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.EndPoint = "http://localhost:8082/api/users/";
            textBox_Response.Text = client.MakeRequest(client.EndPoint);

            List<User> users = JsonConvert.DeserializeObject<List<User>>(textBox_Response.Text);

            var list = new BindingList<User>(users);
            dataGridView_Devices.DataSource = list;
        }

        #endregion BUTTONS


        #region UTILITIES

        /// <summary>
        /// Update time
        /// </summary>
        /// <returns></returns>
        private string updateTime()
        {
            double totalSecond = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            return ((int)totalSecond).ToString();
        }


        /// <summary>
        /// Build URI string
        /// </summary>
        /// <returns></returns>
        private string URI_build()
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
            return builder.ToString();
        }


        //  string sampleString = "http://localhost:5055/?id=111111&timestamp=1495181394&lat=40.9948996&lon=17.222538900000018&speed=0&bearing=355.43&altitude=111.379&batt=11";

        #endregion UTILITIES
    }

    #region STRUCTURES
    /// <summary>
    /// Device description
    /// </summary>
    public class Device
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uniqueId { get; set; }
        public string status { get; set; }
        public string lastUpdate { get; set; }
        public int positionId { get; set; }
        public int groupId { get; set; }
        public List<int> geofenceIds { get; set; }
        public string phone { get; set; }
        public string model { get; set; }
        public string contact { get; set; }
        public string category { get; set; }
        //Variable attributes list
        public Dictionary<string, string> attributes { get; set; }
    }

    /// <summary>
    /// User description
    /// </summary>
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        [JsonProperty("readonly")]
        public bool read { get; set; }
        public bool admin { get; set; }
    }

    /// <summary>
    /// Request standard parameters
    /// </summary>
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

    #endregion STRUCTURES

}
