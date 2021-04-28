using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers.Api
{
    public class PortalDeviceController : BaseController
    {

        [HttpPost("SaveItem/")]
        public Entities.Models.PortalDevice SaveItem([FromBody]Entities.Models.PortalDevice model)
        {
            return LogicLayer.Logic.UOW.PortalDeviceLogic.SaveItem(model);
        }
        [HttpPost("SaveDeviceStatus/")]
        public Entities.Models.PortalDevice SaveDeviceStatus([FromBody] Entities.Models.PortalDevice model)
        {
            return LogicLayer.Logic.UOW.PortalDeviceLogic.SaveDeviceStatus(model);
        }
        [HttpGet("GetItemById/{PortalDeviceId:int}")]
        public Entities.Models.PortalDevice GetItemById(int PortalDeviceId)
        {
            return LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemById(PortalDeviceId);
        } 
        [HttpGet("GetItemById/{deviceGIUD}")]
        public Entities.Models.PortalDevice GetItemBydeviceGIUD(string deviceGIUD)
        {
            return LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemBydeviceGIUD(deviceGIUD);
        }
        [HttpGet("GetItemList/")]
        public List<Entities.Models.PortalDevice> GetItemList()
        {
            return LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemList();
        }
    }
}
