using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public static class UOW
    {
        public static PortalDeviceLogic PortalDeviceLogic = new PortalDeviceLogic();
        public static PortalUserDeviceLogic PortalUserDeviceLogic = new PortalUserDeviceLogic();
        public static PortalUserLogic PortalUserLogic = new PortalUserLogic();
        public static PortalUserOrganizationLogic PortalUserOrganizationLogic = new PortalUserOrganizationLogic();
    }
}
