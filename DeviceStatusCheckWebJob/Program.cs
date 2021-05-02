using System;
using System.Linq;

namespace DeviceStatusCheckWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var PortalDeviceList = LogicLayer.Logic.UOW.PortalUserDeviceLogic.GetItemListInActive();
            foreach (var item in PortalDeviceList.Where(x => x.PortalDevice.Active))
            {
                TimeSpan ts = DateTime.Now - item.PortalDevice.LastActiveTime;
                if (ts.TotalSeconds > 10)
                {
                    item.PortalDevice.Active = false;
                    item.PortalDevice.ErrorMail = false;
                    LogicLayer.Logic.UOW.PortalDeviceLogic.SaveDeviceStatus(item.PortalDevice);
                }

            }
        }
    }
}
