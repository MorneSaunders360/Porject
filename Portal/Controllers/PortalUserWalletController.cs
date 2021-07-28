using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers
{
    public class PortalUserWalletController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");

        }
        [HttpGet]
        public ActionResult Edit(int PortalUserWalletId)
        {
            Portal.Controllers.Api.PortalUserWalletController PortalUserWalletController = new Api.PortalUserWalletController();
            var result = PortalUserWalletController.GetItemById(PortalUserWalletId);
            return View("Edit", result);
        }
        [HttpPost]
        public ActionResult Edit(Entities.Models.PortalUserWallet model)
        {
            Portal.Controllers.Api.PortalUserWalletController PortalUserWalletController = new Api.PortalUserWalletController();
            var result = PortalUserWalletController.SaveItem(model);
            if (result.Id > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (result.Id == 0)
                {
                    return RedirectToAction("Edit", "PortalUserWallet", new { Id = result.Id });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
