using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class PortalSettingsController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int PortalSettingId)
        {
            Portal.Controllers.Api.PortalSettingsController PortalSettingsController = new Api.PortalSettingsController();
            var result = PortalSettingsController.GetItemById(PortalSettingId);
            return View("Edit", result);
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalSettings model)
        {
            Portal.Controllers.Api.PortalSettingsController PortalSettingsController = new Api.PortalSettingsController();
            var result = PortalSettingsController.SaveItem(model);
            return RedirectToAction("Index", "PortalSettings");
        }
    }
}
