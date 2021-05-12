using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalSettings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public bool SoftDelete { get; set; }
    }
}
