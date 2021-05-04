using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers.Api
{
    public class PortalUserOrganizationController : BaseController
    {
        [HttpGet]
        public Entities.Models.PortalUserOrganization GetItemByPortalUserId(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserOrganizationLogic.GetItemByPortalUserId(PortalUserId);
        }
    }
}
