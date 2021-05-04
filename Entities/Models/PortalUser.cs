using System;
namespace Entities.Models
{
    public class PortalUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //FK
        public string AspNetId { get; set; }
        public PortalUserOrganization PortalUserOrganization { get; set; }
    }
}
