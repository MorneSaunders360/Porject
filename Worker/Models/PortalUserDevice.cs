using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Models
{
    public class PortalUserDevice
    {
        public int Id { get; set; }
        //FK
        public int PortalDeviceId { get; set; }
        public PortalDevice PortalDevice { get; set; }
        public int PortalUserId { get; set; }
    }
}
