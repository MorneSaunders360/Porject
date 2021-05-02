using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Portal.Controllers.Api
{
    [Authorize]
    public class PortalUserDeviceController : BaseController
    {
        [HttpPost("SaveItem/")]
        public Entities.Models.PortalUserDevice SaveItem(Entities.Models.PortalUserDevice model)
        {
            return LogicLayer.Logic.UOW.PortalUserDeviceLogic.SaveItem(model);
        }
        [HttpPost("DeletePortalUserDevice/")]
        public void DeletePortalUserDevice(int PortalUserDeviceId)
        {
             LogicLayer.Logic.UOW.PortalUserDeviceLogic.DeletePortalUserDevice(PortalUserDeviceId);
        }
        [HttpPost("SaveDeviceStatus/")]
        public Entities.Models.PortalUserDevice SaveDeviceStatus([FromBody] Entities.Models.PortalUserDevice model)
        {
            return LogicLayer.Logic.UOW.PortalUserDeviceLogic.SaveDeviceStatus(model);
        }
        [HttpGet]
        public Entities.Models.PortalUserDevice GetItemById(int PortalUserDeviceId)
        {
            return LogicLayer.Logic.UOW.PortalUserDeviceLogic.GetItemById(PortalUserDeviceId);
        }
        [HttpGet("GetItemList/{PortalUserId}")]
        public List<Entities.Models.PortalUserDevice> GetItemList(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserDeviceLogic.GetItemList(PortalUserId);
        }

      

    }
}
