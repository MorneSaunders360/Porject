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
            return base.PortalUserRepo.FindItems<Entities.Models.PortalUser>().ToList();
        } 
        public Entities.Models.PortalUser GetItemById(int PortalUserId)
        {
            return base.PortalUserRepo.GetItemById<Entities.Models.PortalUser>(PortalUserId);
        } 
        public Entities.Models.PortalUser GetItemByName(string Email)
        {
            return base.PortalUserRepo.FindItem<Entities.Models.PortalUser>(new {Email = Email });
        }
        public Entities.Models.PortalUser SaveItem(Entities.Models.PortalUser model)
        {
            return base.PortalUserRepo.SaveItem(model);
        }  
    
    }
}
