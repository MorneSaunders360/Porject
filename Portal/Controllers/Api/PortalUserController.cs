using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers.Api
{
    [Authorize]
    public class PortalUserController : BaseController
    {
        [HttpGet]
        public List<Entities.Models.PortalUser> GetItemList()
        {
            return LogicLayer.Logic.UOW.PortalUserLogic.GetItemList();
        }
        [HttpGet("GetItemByName/{Email}")]
        public Entities.Models.PortalUser GetItemByName(string Email)
        {
            return LogicLayer.Logic.UOW.PortalUserLogic.GetItemByName(Email);
        } 
        [HttpPost]
        public Entities.Models.PortalUser SaveItem(Entities.Models.PortalUser model)
        {
            return LogicLayer.Logic.UOW.PortalUserLogic.SaveItem(model);
        }
    }
}
