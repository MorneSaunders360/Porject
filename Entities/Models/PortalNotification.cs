using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalNotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PortalUserId { get; set; }
        public bool SoftDelete { get; set; }
        public int NotificationTypeId { get; set; }
        public int PortalDeviceId { get; set; }
    }
}
