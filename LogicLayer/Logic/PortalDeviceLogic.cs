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
            return base.PortalDeviceRepo.GetItemFiltered(new { Active = false }).ToList();
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
                if (string.IsNullOrEmpty(model.Name))
                {
                    model.Name = Guid.NewGuid().ToString();
                }
                return base.PortalDeviceRepo.SaveItem(model);
            }
            else
            {
                if (string.IsNullOrEmpty(model.Name)==false)
                {
                    result.Name = model.Name;
                }

                return base.PortalDeviceRepo.SaveItem(result);
            }

        }
        public Entities.Models.PortalDevice SaveDeviceStatus(Entities.Models.PortalDevice model)
        {
            var result = GetItemBydeviceGIUD(model.DeviceGIUD);
            if (result != null)
            {

                result.Active = model.Active;
                result.ErrorMail = model.ErrorMail;
                result.LastActiveTime = model.LastActiveTime;
                base.PortalDeviceRepo.SaveItem(result);
                return result;
            }
            else
            {
                return null;
            }


        }
        public async Task SendEmailsForOfflineDevices()
        {

            foreach (var model in LogicLayer.Logic.UOW.PortalUserDeviceLogic.GetItemListInActive())
            {

                if (model.PortalDevice.Active == false && model.PortalDevice.ErrorMail == false)
                {
                    try
                    {
                        var User = base.PortalUserRepo.GetItemById(model.PortalUserId);
                        await EmailService.SendEmail($"{model.PortalDevice.Name } - Offline", $"{model.PortalDevice.Name } - Offline", User.Email);
                        model.PortalDevice.ErrorMail = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                base.PortalDeviceRepo.SaveItem(model.PortalDevice);
            }

        }
    }
}
