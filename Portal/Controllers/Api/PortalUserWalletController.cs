using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Controllers.Api
{
    public class PortalUserWalletController : BaseController
    {
        [HttpGet("GetItemListByPortalUserId/{PortalUserId}")]
        public List<Entities.Models.PortalUserWallet> GetItemListByPortalUserId(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserWalletLogic.GetItemListByPortalUserId(PortalUserId);
        }      
        [HttpGet("GetItemListByPortalUserId/{PortalUserId}")]
        public Task<List<Entities.Models.Temp.PortalWalletDisplay>> GetPortalUserUserWallet(int PortalUserId)
        {
            return LogicLayer.Logic.UOW.PortalUserWalletLogic.GetPortalUserUserWallet(PortalUserId);
        }
        [HttpGet("GetItemById/{PortalUserWalletId}")]
        public Entities.Models.PortalUserWallet GetItemById(int PortalUserWalletId)
        {
            return LogicLayer.Logic.UOW.PortalUserWalletLogic.GetItemById(PortalUserWalletId);
        }
        [HttpPost]
        public Entities.Models.PortalUserWallet SaveItem(Entities.Models.PortalUserWallet model)
        {
            return LogicLayer.Logic.UOW.PortalUserWalletLogic.SaveItem(model);
        }
    }
}
