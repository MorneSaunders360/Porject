using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker
{
    public partial class Form1 : Form
    {
        public System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1500;

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = false;
            if ((string.IsNullOrEmpty(Properties.Settings.Default.DeviceGIUD)) == false)
            {
                timer.Enabled = true;
                timer.Start();
                //button1.Visible = false;
                //textBoxEmail.Visible = false;
                //textBoxPassword.Visible = false;
            }
        }
        public async void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {

            HttpClient client = new HttpClient();
            Models.PortalDevice PortalDevice = new Models.PortalDevice();
            PortalDevice.DeviceGIUD = Properties.Settings.Default.DeviceGIUD;
            PortalDevice.LastActiveTime = DateTime.Now;
            PortalDevice.Active = true;
            if (string.IsNullOrEmpty(PortalDevice.DeviceGIUD) == false)
            {
                var jsonstring = JsonConvert.SerializeObject(PortalDevice);
                client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
                var response = await client.PostAsync("https://portaldevice.azurewebsites.net/Api/PortalDevice/SaveDeviceStatus/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    Invoke(new Action(() =>
                    {
                        bool found = false;
                        foreach (var item in contextMenuStrip1.Items)
                        {
                            if ((item as ToolStripItem).Text == "Online")
                            {
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            contextMenuStrip1.Items.Add("Online");

                        }

                    }));
                }
            }

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Models.LoginViewModel loginViewModel = new Models.LoginViewModel();
            loginViewModel.Username = TextboxEmail.Text;
            loginViewModel.Password = TextboxPassword.Text;
            var jsonstring = JsonConvert.SerializeObject(loginViewModel);
            var response = await client.PostAsync("https://portaldevice.azurewebsites.net/Api/Account/LoginApi/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var model = JsonConvert.DeserializeObject<Models.PortalToken>(response.Content.ReadAsStringAsync().Result);
                Properties.Settings.Default.Token = "bearer " + model.token;
                Properties.Settings.Default.Save();
                client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
                var responseUser = await client.GetAsync("https://portaldevice.azurewebsites.net/Api/PortalUser/GetItemByName/" + loginViewModel.Username);
                if (responseUser.IsSuccessStatusCode)
                {
                    var modelUser = JsonConvert.DeserializeObject<Models.PortalUser>(responseUser.Content.ReadAsStringAsync().Result);
                    Properties.Settings.Default.PortalUserId = modelUser.Id;
                    Properties.Settings.Default.Save();
                    ButtonLogIn.Visible = false;
                    TextboxEmail.Visible = false;
                    TextboxPassword.Visible = false;
                    RegisterDevice();
                }
            }
        }
        public async void RegisterDevice()
        {
            var macAddr =
                            (
                                from nic in NetworkInterface.GetAllNetworkInterfaces()
                                where nic.OperationalStatus == OperationalStatus.Up
                                select nic.GetPhysicalAddress().ToString()
                            ).FirstOrDefault();
            HttpClient client = new HttpClient();
            Models.PortalUserDevice PortalUserDevice = new Models.PortalUserDevice();
            PortalUserDevice.PortalDevice = new Models.PortalDevice();
            PortalUserDevice.PortalDevice.DeviceGIUD = macAddr;
            PortalUserDevice.PortalDevice.Name = System.Environment.MachineName;
            PortalUserDevice.PortalDevice.Description = System.Environment.MachineName;
            PortalUserDevice.PortalDevice.LastActiveTime = DateTime.Now;
            PortalUserDevice.PortalUserId = Properties.Settings.Default.PortalUserId;
            var jsonstring = JsonConvert.SerializeObject(PortalUserDevice);
            client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
            var response = await client.PostAsync("https://portaldevice.azurewebsites.net/Api/PortalUserDevice/SaveItem/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var model = JsonConvert.DeserializeObject<Models.PortalUserDevice>(response.Content.ReadAsStringAsync().Result);
                Properties.Settings.Default.DeviceGIUD = model.PortalDevice.DeviceGIUD;
                Properties.Settings.Default.Save();
                timer.Enabled = true;
                contextMenuStrip1.Items.Add("Online");
                timer.Start();
            }
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;
            if (clickedItem.Text.Contains("Exit"))
            {
                Environment.Exit(0);
            }
            else if (clickedItem.Text.Contains("Reset"))
            {
                timer.Enabled = false;
                timer.Stop();
                //button1.Visible = true;
                //textBoxEmail.Visible = true;
                //textBoxPassword.Visible = true;
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
            else if (clickedItem.Text.Contains("Online") || clickedItem.Text.Contains("Offline"))
            {
                if (timer.Enabled)
                {
                    timer.Enabled = false;
                    timer.Stop();
                    clickedItem.Text = "Offline";
                }
                else
                {
                    timer.Enabled = true;
                    timer.Start();
                    clickedItem.Text = "Online";
                }
            }
        }
    }
}
