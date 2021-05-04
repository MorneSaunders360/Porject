using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers.Api
{
    [Authorize]
    public class PortalUserOrganizationController : BaseController
    {
        [HttpGet]
        public Entities.Models.PortalUserOrganization GetItemByPortalUserId(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserOrganizationLogic.GetItemByPortalUserId(PortalUserId);
        }
        [HttpGet("GetItemByOrganizationName/{Name}")]
        public Entities.Models.PortalUserOrganization GetItemByOrganizationName(string Name)
        {
            return LogicLayer.Logic.UOW.PortalUserOrganizationLogic.GetItemByOrganizationName(Name);
        }
    }
}
