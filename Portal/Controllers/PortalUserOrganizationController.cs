using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers
{
    public class PortalUserOrganizationController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");

        }
        [HttpGet]
        public ActionResult Edit(int PortalUserOrganizationId)
        {
            Portal.Controllers.Api.PortalUserOrganizationController PortalUserOrganizationController = new Api.PortalUserOrganizationController();
            var result = PortalUserOrganizationController.GetItemById(PortalUserOrganizationId);
            if (result.Id==0)
            {
                Portal.Controllers.Api.PortalUserController portalUserController = new Portal.Controllers.Api.PortalUserController();
                var CurrentUser = portalUserController.GetItemByName(User.Identity.Name);
                result.PortalUserId = CurrentUser.Id;
            }
            return View("Edit", result);
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalUserOrganization model)
        {
            Portal.Controllers.Api.PortalUserOrganizationController PortalUserOrganizationController = new Api.PortalUserOrganizationController();
            var result = PortalUserOrganizationController.SaveItem(model);
            return RedirectToAction("Index");
        }
    }
}
