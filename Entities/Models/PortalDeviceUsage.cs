using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalDeviceUsage
    {
        public int Id { get; set; }
        public int PortalDeviceId { get; set; }
        public string Temps { get; set; }
        public DateTime WhenCreated { get; set; }
        public List<DateTime> WhenCreatedList { get; set; }

        public PortalDevice PortalDevice { get; set; }

    }
}
