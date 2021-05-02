using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker
{
    public partial class Worker : Form
    {
        string BaseUrl = "https://portaldevice.azurewebsites.net";
        //string BaseUrl = "https://localhost:44363";
        static RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public System.Timers.Timer timer;
        CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();
        int connectionTimeout = 0;
        public Worker()
        {
            if (IsAlreadyRunning() == false)
            {
                InitializeComponent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 2500;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = false;

            ProgressbarIndicator.Left = (this.ClientSize.Width - ProgressbarIndicator.Width) / 2;
            ProgressbarIndicator.Top = (this.ClientSize.Height - ProgressbarIndicator.Height) / 2;
      
            if ((string.IsNullOrEmpty(Properties.Settings.Default.DeviceGIUD)) == false)
            {
                timer.Enabled = true;
                timer.Start();
                timerIndecator.Start();
                panelLogIn.Visible = false;
            }
            if (Properties.Settings.Default.RunOnStartUp)
            {
                runOnStartUpToolStripMenuItem1.Text = "Run on start up - Running";
            }
            else
            {
                runOnStartUpToolStripMenuItem1.Text = "Run on start up - Not Running";
            }

        }
        public async void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {

            HttpClient client = new HttpClient();
            Models.PortalUserDevice PortalUserDevice = new Models.PortalUserDevice();
            Models.PortalDevice PortalDevice = new Models.PortalDevice();
            PortalDevice.DeviceGIUD = Properties.Settings.Default.DeviceGIUD;
            PortalDevice.Name = Properties.Settings.Default.DeviceName;
            PortalDevice.LastActiveTime = DateTime.Now;
            PortalDevice.Active = true;
            PortalUserDevice.PortalDevice = PortalDevice;
            if (string.IsNullOrEmpty(PortalDevice.DeviceGIUD) == false)
            {
                try
                {
                    var jsonstring = JsonConvert.SerializeObject(PortalUserDevice);
                    client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
                    var response = await client.PostAsync($"{BaseUrl}/Api/PortalUserDevice/SaveDeviceStatus/", new StringContent(jsonstring, Encoding.UTF8, "application/json"), CancellationTokenSource.Token);
                    if (response.IsSuccessStatusCode)
                    {

                        Invoke(new Action(() =>
                        {
                        
                            var Result = response.Content.ReadAsStringAsync().Result;
                            var model = JsonConvert.DeserializeObject<Models.PortalUserDevice>(Result);
                            if (model == null)
                            {
                                CancellationTokenSource.Cancel();
                                timer.Stop();
                                panelLogIn.Visible = true;
                                CancellationTokenSource = new CancellationTokenSource();
                            }
                            else
                            {
                                if (model.SoftDelete)
                                {
                                    CancellationTokenSource.Cancel();
                                    timer.Stop();
              
                                    ButtonStatus.Visible = true;
                                    ButtonStatus.Text = "Offline";
                                    ButtonStatus.BackColor = Color.Red;
                                    ButtonStatus.OnHovercolor = Color.Red;
                                    ButtonStatus.Normalcolor = Color.Red;
                                    ButtonStatus.Activecolor = Color.DarkRed;
                                    panelLogIn.Visible = true;
                                    CancellationTokenSource = new CancellationTokenSource();
                                }
                                else
                                {
                                    ButtonStatus.Visible = true;
                                    ButtonStatus.Text = "Online";
                                    ButtonStatus.BackColor = Color.SeaGreen;
                                    ButtonStatus.OnHovercolor = Color.SeaGreen;
                                    ButtonStatus.Normalcolor = Color.SeaGreen;
                                    ButtonStatus.Activecolor = Color.SeaGreen;
                                }
                            }
                            ProgressbarIndicator.Visible = false;
                            timerIndecator.Stop();

                        }));
                    }
                }
                catch (Exception ex)
                {

                }

            }



        }
        private async void button1_Click(object sender, EventArgs e)
        {
            timerIndecator.Start();
            if (CheckForInternetConnection())
            {
                HttpClient client = new HttpClient();
                Models.LoginViewModel loginViewModel = new Models.LoginViewModel();
                loginViewModel.Username = TextboxEmail.Text;
                loginViewModel.Password = TextboxPassword.Text;
                var jsonstring = JsonConvert.SerializeObject(loginViewModel);
                var response = await client.PostAsync($"{BaseUrl}/Api/Account/LoginApi/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
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
                        panelLogIn.Visible = false;
                        RegisterDevice();
                    }
                }
            }

        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch
            {
                return false;
            }
        }
        private static bool IsAlreadyRunning()
        {
            string strLoc = Assembly.GetExecutingAssembly().Location;
            FileSystemInfo fileInfo = new FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            bool bCreatedNew;

            Mutex mutex = new Mutex(true, "Global\\" + sExeName, out bCreatedNew);
            if (bCreatedNew)
                mutex.ReleaseMutex();

            return !bCreatedNew;
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
            PortalUserDevice.SoftDelete = false;
            PortalUserDevice.PortalDevice.DeviceGIUD = macAddr;
            if (string.IsNullOrEmpty(Properties.Settings.Default.DeviceName))
            {
                PortalUserDevice.PortalDevice.Name = System.Environment.MachineName;
            }
            else
            {
                PortalUserDevice.PortalDevice.Name = Properties.Settings.Default.DeviceName;
            }
        
            PortalUserDevice.PortalDevice.Description = System.Environment.MachineName;
            PortalUserDevice.PortalDevice.LastActiveTime = DateTime.Now;
            PortalUserDevice.PortalUserId = Properties.Settings.Default.PortalUserId;
            var jsonstring = JsonConvert.SerializeObject(PortalUserDevice);
            client.DefaultRequestHeaders.Add("Authorization", Properties.Settings.Default.Token);
            var response = await client.PostAsync($"{BaseUrl}/Api/PortalUserDevice/SaveItem/", new StringContent(jsonstring, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var model = JsonConvert.DeserializeObject<Models.PortalUserDevice>(response.Content.ReadAsStringAsync().Result);
                Properties.Settings.Default.DeviceGIUD = model.PortalDevice.DeviceGIUD;
                Properties.Settings.Default.DeviceName = model.PortalDevice.Name;
                Properties.Settings.Default.Save();
                timer.Start();
                timerIndecator.Stop();
                ProgressbarIndicator.Visible = false;
            }
        }

        #region MouseMove
        private bool mouseDown;
        private Point lastLocation;
        private void bunifuForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonStatus_Click(object sender, EventArgs e)
        {

            if (ButtonStatus.Text.Contains("Offline"))
            {
                ButtonStatus.Text = "Connecting...";
                timer.Start();
                timerIndecator.Start();
            }
            else if (ButtonStatus.Text.Contains("Online"))
            {
                CancellationTokenSource.Cancel();
                timer.Stop();
                //ButtonStatus.Text = "Stopping";
                ButtonStatus.Text = "Offline";
                ButtonStatus.BackColor = Color.Red;
                ButtonStatus.OnHovercolor = Color.Red;
                ButtonStatus.Normalcolor = Color.Red;
                ButtonStatus.Activecolor = Color.DarkRed;
                CancellationTokenSource = new CancellationTokenSource();
            }
        }

        private void runOnStartUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;
            Properties.Settings.Default.RunOnStartUp = !Properties.Settings.Default.RunOnStartUp;
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.RunOnStartUp)
            {
                rkApp.SetValue("Worker", Application.ExecutablePath);
                clickedItem.Text = "Run on start up - Running";
            }
            else
            {
                rkApp.DeleteValue("Worker", false);
                clickedItem.Text = "Run on start up - Not Running";
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
            panelLogIn.Visible = true;
            ButtonStatus.Visible = false;
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                connectionTimeout = 0;
            }
            else
            {
                connectionTimeout++;
                if (connectionTimeout == 5)
                {

                    Process.Start("shutdown", "/r /t 0");
                }
            }
        }
        int ProgressbarIndicatorCounter = 0;
        private void timerIndecator_Tick(object sender, EventArgs e)
        {
            if (ProgressbarIndicator.Visible == false)
            {
                ProgressbarIndicatorCounter = 0;
            }
            ProgressbarIndicator.Visible = true;
            ProgressbarIndicatorCounter++;
            if (ProgressbarIndicatorCounter == 100)
            {
                ProgressbarIndicatorCounter = 0;
            }
            ProgressbarIndicator.Value = ProgressbarIndicatorCounter;
        }

        private void TextboxPassword_OnValueChanged(object sender, EventArgs e)
        {
            TextboxPassword.isPassword = true;
        }
    }
}
