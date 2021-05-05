using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;

namespace Portal.Controllers
{
    [Authorize]
    public class PortalUserController : BaseController
    {

        [HttpGet]
        public ActionResult Edit(int PortalUserId)
        {
            Portal.Controllers.Api.PortalUserController PortalUserController = new Api.PortalUserController();
            var result = PortalUserController.GetItemById(PortalUserId);
            return View("Edit", result);
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalUser model)
        {
            Portal.Controllers.Api.PortalUserController PortalUserController = new Api.PortalUserController();
            var result = PortalUserController.SaveItem(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
