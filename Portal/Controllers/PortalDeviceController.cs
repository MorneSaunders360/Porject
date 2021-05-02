using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SmartBreadcrumbs.Attributes;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portal.Controllers
{
    [Authorize]
    public class PortalDeviceController : Controller
    {
        // GET: /<controller>/
        [Breadcrumb("Device")]
        [HttpGet]
        public ActionResult Index()
        {
            Portal.Controllers.Api.PortalDeviceController portalDeviceController = new Api.PortalDeviceController();
            var result = portalDeviceController.GetItemList();
            return View("Index", result);
        }
        [Breadcrumb("Edit", FromAction = "Index")]
        [HttpGet]
        public ActionResult Edit(int PortalDeviceId = 0)
        {
            Portal.Controllers.Api.PortalDeviceController portalDeviceController = new Api.PortalDeviceController();
            var result = portalDeviceController.GetItemById(PortalDeviceId);
            return View("Edit", result);
        } 
        [HttpGet]
        public JsonResult ShutdownPortalDevice(int PortalDeviceId = 0)
        {
            Portal.Controllers.Api.PortalDeviceController portalDeviceController = new Api.PortalDeviceController();
             portalDeviceController.ShutdownPortalDevice(PortalDeviceId);
            return Json("");
        }
        [HttpGet]
        public JsonResult RestartPortalDevice(int PortalDeviceId = 0)
        {
            Portal.Controllers.Api.PortalDeviceController portalDeviceController = new Api.PortalDeviceController();
            portalDeviceController.RestartPortalDevice(PortalDeviceId);
            return Json("");
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalDevice model)
        {
            Portal.Controllers.Api.PortalDeviceController portalDeviceController = new Api.PortalDeviceController();

            var result = portalDeviceController.SaveItem(model);
            if (model.Id > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (model.Id == 0)
                {
                    return RedirectToAction("Edit", "PortalDevice", new { PortalDeviceId = result.Id });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

        }
    }
}
