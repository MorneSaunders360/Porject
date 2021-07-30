using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers.Api
{
    public class PortalUserWalletDetailsController : BaseController
    {
        [HttpGet("GetPortalUserWalletDetailsByPortalUserId/{PortalUserId}")]
        public List<Entities.Models.PortalUserWalletDetails> GetPortalUserWalletDetailsByPortalUserId(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserWalletDetailsLogic.GetPortalUserWalletDetailsByPortalUserId(PortalUserId);
        }
    }
}
