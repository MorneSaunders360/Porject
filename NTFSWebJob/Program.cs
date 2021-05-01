using System;
using System.Threading;

namespace NTFSWebJob
{
    class Program
    {
       
        static void Main(string[] args)
        {
            LogicLayer.Logic.UOW.PortalDeviceLogic.SendEmailsForOfflineDevices().Wait();
        }


    }
}
