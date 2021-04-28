﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalDevice
    {
        public int PortalDeviceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeviceGIUD { get; set; }
        public bool Active { get; set; }
        public DateTime LastActiveTime { get; set; }
        //FK
    }
}
