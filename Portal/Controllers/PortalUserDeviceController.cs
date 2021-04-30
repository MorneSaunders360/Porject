using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;
using Microsoft.AspNetCore.Identity;
namespace Portal.Controllers
{
    [Authorize]
    public class PortalUserDeviceController : BaseController
    {
        [Breadcrumb("Device")]
        [HttpGet]
        public ActionResult Index()
        {
            Portal.Controllers.Api.PortalUserController PortalUserController = new Api.PortalUserController();
            var CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
            Portal.Controllers.Api.PortalUserDeviceController PortalUserDeviceController = new Api.PortalUserDeviceController();
            var result = PortalUserDeviceController.GetItemList(CurrentUser.Id);
            return View("Index", result);

        } 
        
        [HttpGet]
        public PartialViewResult PortalDeviceListPartial()
        {
            return PartialView("~/Views/Home/PortalDeviceListPartial.cshtml");

        }


        [Breadcrumb("Edit", FromAction = "Index")]
        [HttpGet]
        public ActionResult Edit(int PortalUserDeviceId)
        {
            Portal.Controllers.Api.PortalUserDeviceController PortalUserDeviceController = new Api.PortalUserDeviceController();
            var result = PortalUserDeviceController.GetItemById(PortalUserDeviceId);
            return View("Edit", result);
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalUserDevice model)
        {
            Portal.Controllers.Api.PortalUserDeviceController PortalUserDeviceController = new Api.PortalUserDeviceController();
            var result = PortalUserDeviceController.SaveItem(model);
            if (model.Id > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (model.Id == 0)
                {
                    return RedirectToAction("Edit", "PortalUserDevice", new { Id = result.Id });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
