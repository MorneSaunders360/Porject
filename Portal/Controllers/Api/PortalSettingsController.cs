using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers.Api
{
    public class PortalSettingsController : BaseController
    {
        [HttpGet]
        public List<Entities.Models.PortalSettings> GetItemList()
        {
            return LogicLayer.Logic.UOW.PortalSettingsLogic.GetItemList();
        }
        [HttpGet("GetItemByName/{Name}")]
        public Entities.Models.PortalSettings GetItemByName(string Name)
        {
            return LogicLayer.Logic.UOW.PortalSettingsLogic.GetItemByName(Name);
        }
        [HttpGet("GetItemById/{PortalSettingId}")]
        public Entities.Models.PortalSettings GetItemById(int PortalSettingId)
        {
            return LogicLayer.Logic.UOW.PortalSettingsLogic.GetItemById(PortalSettingId);
        }
        [HttpPost]
        public Entities.Models.PortalSettings SaveItem(Entities.Models.PortalSettings model)
        {
            return LogicLayer.Logic.UOW.PortalSettingsLogic.SaveItem(model);
        }
    }
}
