using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalDevice
    {
        public int Id { get; set; }
        public int ParentPortalDeviceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string DeviceGIUD { get; set; }
        public bool Active { get; set; }
        public bool ErrorMail { get; set; }
        public bool EmailNotification { get; set; }
        public bool Restart { get; set; }
        public bool Shutdown { get; set; }
        public string Temp { get; set; }
        public List<PortalDevice> PortalDeviceChildern { get; set; }


        public DateTime LastActiveTime { get; set; }
        //FK
    }
}
