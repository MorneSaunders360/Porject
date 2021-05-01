using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Models
{
    public class PortalUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //FK
        public string AspNetId { get; set; }
    }
}
