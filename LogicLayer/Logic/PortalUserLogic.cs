using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicLayer.Logic
{
    public class PortalUserLogic : Baselogic<Entities.Models.PortalUser>
    {
        public PortalUserLogic()
        {
        }
        public List<Entities.Models.PortalUser> GetItemList()
        {
            return base.PortalUserRepo.GetItems().ToList();
        } 
        public Entities.Models.PortalUser GetItemById(int PortalUserId)
        {
            return base.PortalUserRepo.GetItemById(PortalUserId);
        } 
        public Entities.Models.PortalUser GetItemByName(string Email)
        {
            return base.PortalUserRepo.FindItem(new {Email = Email });
        }
        public Entities.Models.PortalUser SaveItem(Entities.Models.PortalUser model)
        {
            var portalUser = base.PortalUserRepo.SaveItem(model);
            Logic.UOW.PortalUserOrganizationLogic.SaveItem(new Entities.Models.PortalUserOrganization { PortalUserId = portalUser.Id });
            return portalUser;
        }  
    
    }
}
