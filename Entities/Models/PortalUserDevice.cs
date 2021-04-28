using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class PortalUserDevice
    {
        public int PortalUserDeviceId { get; set; }
        //FK
        public int PortalDeviceId { get; set; }
        public PortalDevice PortalDevice { get; set; }
        public int PortalUserId { get; set; }


    }
}
