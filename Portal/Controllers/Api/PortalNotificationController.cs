using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers.Api
{
    public class PortalNotificationController : BaseController
    {
        [HttpGet]
        public List<Entities.Models.PortalNotification> GetItemListActivePortal()
        {
            return LogicLayer.Logic.UOW.PortalNotificationLogic.GetItemListActivePortal();
        }
        [HttpPost]
        public Entities.Models.PortalNotification SaveItem(Entities.Models.PortalNotification model)
        {
            return LogicLayer.Logic.UOW.PortalNotificationLogic.SaveItem(model);
        }
    }
}
