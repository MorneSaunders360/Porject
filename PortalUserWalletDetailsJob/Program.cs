using System;

namespace PortalUserWalletDetailsJob
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicLayer.Logic.UOW.PortalUserWalletDetailsLogic.GetPortalUserUserWallet().Wait();
        }
    }
}
