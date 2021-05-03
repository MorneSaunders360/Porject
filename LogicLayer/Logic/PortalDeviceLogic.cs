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
        public List<Entities.Models.PortalDevice> GetItemListByParentId(int ParentPortalDeviceId)
        {
            return base.PortalDeviceRepo.GetItemFiltered(new { ParentPortalDeviceId = ParentPortalDeviceId }).ToList();
        }
        public Entities.Models.PortalDevice GetItemById(int PortalDeviceId)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.GetItemById(PortalDeviceId);
            if (portalDevice == null)
            {
                portalDevice = new Entities.Models.PortalDevice();

            }
            else
            {
                portalDevice.PortalDeviceChildern = GetItemListByParentId(portalDevice.Id);
            }
            return portalDevice;
        }
        public Entities.Models.PortalDevice GetItemBydeviceGIUD(string deviceGIUD)
        {
            Entities.Models.PortalDevice portalDevice = base.PortalDeviceRepo.GetItemFiltered(new { DeviceGIUD = deviceGIUD }).FirstOrDefault();
            return portalDevice;
        }
        public void RestartPortalDevice(int PortalDeviceId)
        {
            var model = GetItemById(PortalDeviceId);
            model.Restart = true;
            base.PortalDeviceRepo.SaveItem(model);
        } 
        public void ShutdownPortalDevice(int PortalDeviceId)
        {
            var model = GetItemById(PortalDeviceId);
            model.Shutdown = true;
            base.PortalDeviceRepo.SaveItem(model);
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
                var saveResult=  base.PortalDeviceRepo.SaveItem(model);
                if (model.PortalDeviceChildern.Count>0)
                {
                    foreach (var item in model.PortalDeviceChildern)
                    {
                        item.ParentPortalDeviceId = saveResult.Id;
                        SaveItem(item);
                    }
                }
                return saveResult;
            }
            else if (model.Id==0 && string.IsNullOrEmpty(model.DeviceGIUD)==false)
            {
                model.Active=true;
                return base.PortalDeviceRepo.SaveItem(model);
            }
            else
            {
                if (string.IsNullOrEmpty(model.Name) == false)
                {
                    result.Name = model.Name;
                }
                if (string.IsNullOrEmpty(model.Description) == false)
                {
                    result.Description = model.Description;
                }
                else
                {
                    result.Description = string.Empty;
                }
                result.EmailNotification = model.EmailNotification;
                result.Shutdown = model.Shutdown;
                result.Restart = model.Restart;
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
                result.Temp = model.Temp;
                base.PortalDeviceRepo.SaveItem(result);
                if (model.PortalDeviceChildern.Count>0)
                {
                    foreach (var item in model.PortalDeviceChildern)
                    {
                       var Device = base.PortalDeviceRepo.GetItemFiltered(new { DeviceGIUD=model.DeviceGIUD, Name= item.Name }).FirstOrDefault();
                       Device.Temp = item.Temp;
                       base.PortalDeviceRepo.SaveItem(Device);
                    }
                }
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

                if (model.PortalDevice.Active == false && model.PortalDevice.ErrorMail == false && model.PortalDevice.EmailNotification)
                {
                    try
                    {
                        var User = base.PortalUserRepo.GetItemById(model.PortalUserId);
                        var body = $"{model.PortalDevice.Name}-Offline"+Environment.NewLine;
                        foreach (var item in GetItemListByParentId(model.PortalDeviceId))
                        {
                            body += item.Name + Environment.NewLine;
                        }
                        await EmailService.SendEmail($"{model.PortalDevice.Name } - Offline", body,  User.Email);
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
