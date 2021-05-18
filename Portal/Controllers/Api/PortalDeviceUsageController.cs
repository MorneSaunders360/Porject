using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers.Api
{
    public class PortalDeviceUsageController : BaseController
    {
        [HttpGet]
        public List<Entities.Models.PortalDeviceUsage> GetItemByPortalDeviceId(int PortalDeviceId)
        {
            return LogicLayer.Logic.UOW.PortalDeviceUsageLogic.GetItemByPortalDeviceId(PortalDeviceId);
        }
    }
}
