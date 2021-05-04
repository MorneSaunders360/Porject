using System;
using System.Linq;
using System.Threading;

namespace DeviceStatusCheckWebJob
{
    class Program
    {
        public static System.Timers.Timer timer;
        static void Main(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            new ManualResetEvent(false).WaitOne();
        }
        public static void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {

            var PortalDeviceList = LogicLayer.Logic.UOW.PortalUserDeviceLogic.GetItemListInActive();
            foreach (var item in PortalDeviceList)
            {
                TimeSpan ts = DateTime.Now - item.PortalDevice.LastActiveTime;
                if (ts.TotalMilliseconds > 10)
                {
                    item.PortalDevice.Active = false;
                    LogicLayer.Logic.UOW.PortalDeviceLogic.SaveDeviceStatus(item.PortalDevice);
                }

            }
        }
    }
}
