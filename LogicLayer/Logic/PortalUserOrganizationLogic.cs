using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalUserOrganizationLogic : Baselogic<Entities.Models.PortalUserOrganization>
    {
        public PortalUserOrganizationLogic()
        {

        }
        public List<Entities.Models.PortalUserOrganization> GetItemsByPortalUserId(int PortalUserId)
        {
            return base.PortalUserOrganizationRepo.GetItemFiltered(new { PortalUserId= PortalUserId }).ToList();
        }  
        public Entities.Models.PortalUserOrganization GetItemByPortalUserId(int PortalUserId)
        {
            return base.PortalUserOrganizationRepo.FindItem(new { PortalUserId= PortalUserId });
        } 
        public Entities.Models.PortalUserOrganization GetItemById(int Id)
        {
            var PortalUserOrganization = base.PortalUserOrganizationRepo.GetItemById(Id);
            if (PortalUserOrganization==null)
            {
                PortalUserOrganization = new();
            }
            return PortalUserOrganization;
        }
        public Entities.Models.PortalUserOrganization GetItemByOrganizationName(string Name)
        {
            return base.PortalUserOrganizationRepo.FindItem(new { Name = Name });
        }
        public Entities.Models.PortalUserOrganization SaveItem(Entities.Models.PortalUserOrganization model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                model.Name = GenerateName(10);
            }
            return base.PortalUserOrganizationRepo.SaveItem(model);
        }
        public  string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    }
}
