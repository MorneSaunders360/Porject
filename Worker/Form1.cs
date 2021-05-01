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
            timer = new System.Timers.Timer();
            timer.Interval = 1500;

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = false;
            if ((string.IsNullOrEmpty(Properties.Settings.Default.DeviceGIUD))==false)
            {
                timer.Enabled = true;
                timer.Start();
                button1.Visible = false;
            }
            else
            {
                button4.Visible = false;
            }
        }
        public async void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
        
            HttpClient client = new HttpClient();
            Entities.Models.PortalDevice PortalDevice = new Entities.Models.PortalDevice();
            PortalDevice.DeviceGIUD = Properties.Settings.Default.DeviceGIUD;
            PortalDevice.LastActiveTime = DateTime.Now;
            PortalDevice.Active = true;
            if (string.IsNullOrEmpty(PortalDevice.DeviceGIUD)==false)
            {
                var jsonstring = JsonConvert.SerializeObject(PortalDevice);
                client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
                var response = await client.PostAsync("https://portaldevice.azurewebsites.net/Api/PortalDevice/SaveDeviceStatus/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    Invoke(new Action(() => { button4.Text = "Online"; }));
                }
            }
          
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Portal.Models.LoginViewModel loginViewModel = new Portal.Models.LoginViewModel();
            loginViewModel.Username = "mornesaunders32@gmail.com";
            loginViewModel.Password = "Pass@word123";
            var jsonstring = JsonConvert.SerializeObject(loginViewModel);
            var response = await client.PostAsync("https://portaldevice.azurewebsites.net/Api/Account/LoginApi/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var model = JsonConvert.DeserializeObject<Entities.Models.PortalToken>(response.Content.ReadAsStringAsync().Result);
                Properties.Settings.Default.Token = "bearer " + model.token;
                Properties.Settings.Default.Save();
                client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
                var responseUser = await client.GetAsync("https://portaldevice.azurewebsites.net/Api/PortalUser/GetItemByName/" + loginViewModel.Username);
                if (responseUser.IsSuccessStatusCode)
                {
                    var modelUser = JsonConvert.DeserializeObject<Entities.Models.PortalUser>(responseUser.Content.ReadAsStringAsync().Result);
                    Properties.Settings.Default.PortalUserId = modelUser.Id;
                    Properties.Settings.Default.Save();
                    button1.Visible = false;
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
            Entities.Models.PortalUserDevice PortalUserDevice = new Entities.Models.PortalUserDevice();
            PortalUserDevice.PortalDevice = new Entities.Models.PortalDevice();
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
                var model = JsonConvert.DeserializeObject<Entities.Models.PortalUserDevice>(response.Content.ReadAsStringAsync().Result);
                Properties.Settings.Default.DeviceGIUD = model.PortalDevice.DeviceGIUD;
                Properties.Settings.Default.Save();
                timer.Enabled = true;
                button4.Visible=true;
                button4.Text = "Online";
                timer.Start();
            }
        }


 

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                timer.Stop();
                button4.Text = "Offline";
            }
            else
            {
                timer.Enabled = true;
                timer.Start();
                button4.Text = "Online";
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
            button1.Visible = true;
            button4.Text = "Offline";
            button4.Visible = false;
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }
    }
}
