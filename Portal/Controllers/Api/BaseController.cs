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

        public BaseController()
        {
            Result();
        }

        public async void Result() 
        {
            while (true)
            {
                await Task.Delay(2500);
                var PortalDeviceList = LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemList();
                foreach (var item in PortalDeviceList.Where(x => x.Active))
                {
                    TimeSpan ts = DateTime.Now - item.LastActiveTime;
                    if (ts.TotalSeconds > 10)
                    {
                        item.Active = false;
                        item.ErrorMail = false;
                        LogicLayer.Logic.UOW.PortalDeviceLogic.SaveDeviceStatus(item);
                    }

                }
                
            } 
            
           
        }  
 

    }
}
