using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalUserOrganization
    {
        public int Id { get; set; }
        public int PortalUserId { get; set; }
        public string Name { get; set; }
    }
}
