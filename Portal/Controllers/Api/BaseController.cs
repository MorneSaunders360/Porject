using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers.Api
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        private System.Timers.Timer timer;
        public BaseController()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 60000;

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            foreach (var item in LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemList().Where(x => x.Active))
            {
                TimeSpan ts = DateTime.Now - item.LastActiveTime;
                if (ts.TotalMinutes > 5)
                {
                    item.Active = false;
                    LogicLayer.Logic.UOW.PortalDeviceLogic.SaveItem(item);
                }

            }

        }
    }
}
