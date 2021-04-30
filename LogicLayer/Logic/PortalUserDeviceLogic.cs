using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicLayer.Logic
{
    public class PortalUserDeviceLogic : Baselogic<Entities.Models.PortalUserDevice>
    {
        public PortalUserDeviceLogic()
        {
        }
        public List<Entities.Models.PortalUserDevice> GetItemList(int PortalUserId)
        {
            var result = base.PortalUserDeviceRepo.GetItemFiltered(new { PortalUserId = PortalUserId }).ToList();
            if (result!=null)
            {
                foreach (var item in result)
                {
                    item.PortalDevice = Logic.UOW.PortalDeviceLogic.GetItemById(item.PortalDeviceId);
                }
            }
           
            return result;
        }
        public Entities.Models.PortalUserDevice GetItemById(int PortalUserDeviceId)
        {
            var result = base.PortalUserDeviceRepo.GetItemById(PortalUserDeviceId);
            if (result == null)
            {
                result = new Entities.Models.PortalUserDevice();
                result.PortalDevice = new Entities.Models.PortalDevice();
            }
            else
            {
                result.PortalDevice = LogicLayer.Logic.UOW.PortalDeviceLogic.GetItemById(result.PortalDeviceId);
            }
            return result;
        } 
        public Entities.Models.PortalUserDevice GetItemByPortalDeviceId(int PortalDeviceId)
        {
            var result = base.PortalUserDeviceRepo.FindItem(new { PortalDeviceId = PortalDeviceId });
            return result;
        }
        public Entities.Models.PortalUserDevice SaveItem(Entities.Models.PortalUserDevice model)
        {
            Entities.Models.PortalUserDevice result = new Entities.Models.PortalUserDevice();
            var Device = LogicLayer.Logic.UOW.PortalDeviceLogic.SaveItem(model.PortalDevice);
            model.PortalDeviceId = Device.Id;
            if (GetItemByPortalDeviceId(model.PortalDeviceId)==null)
            {
                result = base.PortalUserDeviceRepo.SaveItem(model);
            }
            else
            {
                result = GetItemByPortalDeviceId(model.PortalDeviceId);
            }
            result.PortalDevice = Device;

            return result;
        }

       
    }
}
