using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers
{
    public class PortalDeviceUsageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
