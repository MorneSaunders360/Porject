using Service.Email;
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
            return base.PortalDeviceRepo.GetItems().ToList();
        } 
        public List<Entities.Models.PortalDevice> GetItemListInActive()
        {
            return base.PortalDeviceRepo.GetItemFiltered(new { Active=false }).ToList();
        }
        public Entities.Models.PortalDevice GetItemById(int PortalDeviceId)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.GetItemById(PortalDeviceId);
            if (portalDevice == null)
            {
                portalDevice = new Entities.Models.PortalDevice();

            }
            return portalDevice;
        }
        public Entities.Models.PortalDevice GetItemBydeviceGIUD(string deviceGIUD)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.GetItemFiltered(new { DeviceGIUD = deviceGIUD }).FirstOrDefault();
            return portalDevice;
        }
        public Entities.Models.PortalDevice SaveItem(Entities.Models.PortalDevice model)
        {
            var result = GetItemBydeviceGIUD(model.DeviceGIUD);
            if (result == null)
            {
                return base.PortalDeviceRepo.SaveItem(model);
            }
            return result;
        }
        public Entities.Models.PortalDevice SaveDeviceStatus(Entities.Models.PortalDevice model)
        {
            var result = GetItemBydeviceGIUD(model.DeviceGIUD);
            if (result != null)
            {

                result.Active = model.Active;
                result.ErrorMail = model.ErrorMail;
                result.LastActiveTime = model.LastActiveTime;
                result = base.PortalDeviceRepo.SaveItem(result);
                return result;
            }
            else
            {
                return new Entities.Models.PortalDevice();
            }


        }
        public async Task SendEmailsForOfflineDevices() 
        {
            foreach (var model in GetItemListInActive())
            {
                if (model.Active == false && model.ErrorMail == false)
                {
                    try
                    {
                        await EmailService.SendEmail($"{model.Name } - Offline", $"{model.Name } - Offline");
                        model.ErrorMail = true;
                    }
                    catch (Exception ex)
                    {
                    }

                }
                base.PortalDeviceRepo.SaveItem(model);
            }
            
        }
    }
}
