using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalDeviceLogic : Baselogic<Entities.Models.PortalDevice>
    {
        public PortalDeviceLogic()
        {

        }
        public List<Entities.Models.PortalDevice> GetItemList()
        {
            return base.PortalDeviceRepo.FindItems<Entities.Models.PortalDevice>().ToList();
        }   
        public Entities.Models.PortalDevice GetItemById(int PortalDeviceId)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.GetItemById<Entities.Models.PortalDevice>(PortalDeviceId);
            if (portalDevice == null)
            {
                portalDevice = new Entities.Models.PortalDevice();

            }
            return portalDevice;
        }
        public Entities.Models.PortalDevice GetItemBydeviceGIUD(string deviceGIUD)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.FindItem<Entities.Models.PortalDevice>(new { DeviceGIUD= deviceGIUD });
            return portalDevice;
        }
        public Entities.Models.PortalDevice SaveItem(Entities.Models.PortalDevice model)
        {
            
            if (model.DeviceGIUD == null || model.DeviceGIUD == "" || model.PortalDeviceId == 0)
            {
                model.DeviceGIUD = Guid.NewGuid().ToString();
            }
            return base.PortalDeviceRepo.SaveItem(model);
        }   
        public Entities.Models.PortalDevice SaveDeviceStatus(Entities.Models.PortalDevice model)
        {
            var result = GetItemBydeviceGIUD(model.DeviceGIUD);
            if (result!=null)
            {
                result.Active = true;
                result.LastActiveTime = model.LastActiveTime;
                return base.PortalDeviceRepo.SaveItem(result);
            }
            else
            {
                return new Entities.Models.PortalDevice();
            }
            
           
        }
    }
}
