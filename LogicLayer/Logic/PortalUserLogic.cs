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
            var user = base.PortalUserRepo.GetItemById(PortalUserId);
            if (user!=null)
            {
                user.PortalUserOrganization = Logic.UOW.PortalUserOrganizationLogic.GetItemByPortalUserId(PortalUserId);
            }
            return user;
        } 
        public Entities.Models.PortalUser GetItemByName(string Email)
        {
            return base.PortalUserRepo.FindItem(new {Email = Email });
        }
        public Entities.Models.PortalUser SaveItem(Entities.Models.PortalUser model)
        {
            var portalUser = base.PortalUserRepo.SaveItem(model);
            if (model.PortalUserOrganization == null)
            {
                model.PortalUserOrganization = new Entities.Models.PortalUserOrganization {PortalUserId = portalUser.Id };
            }
            else
            {
                model.PortalUserOrganization.PortalUserId = portalUser.Id;
            }

            Logic.UOW.PortalUserOrganizationLogic.SaveItem(model.PortalUserOrganization);
            return portalUser;
        }  
    
    }
}
