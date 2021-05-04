using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalNotificationLogic : Baselogic<Entities.Models.PortalNotification>
    {
        public PortalNotificationLogic()
        {

        }
        public List<Entities.Models.PortalNotification> GetItemList(int PortalUserId,int PortalDeviceId)
        {
            var result = base.PortalNotificationRepo.GetItemFiltered(new { PortalDeviceId= PortalDeviceId, PortalUserId = PortalUserId, SoftDelete = false }).ToList();
            return result;
        } 
        public List<Entities.Models.PortalNotification> GetItemListActiveEmail()
        {
            var result = base.PortalNotificationRepo.GetItemFiltered(new {SoftDelete = false, NotificationTypeId=2 }).ToList();
            return result;
        } 
        public List<Entities.Models.PortalNotification> GetItemListActivePortal()
        {
            var result = base.PortalNotificationRepo.GetItemFiltered(new {SoftDelete = false, NotificationTypeId=1 }).ToList();
            return result;
        }
        public Entities.Models.PortalNotification SaveItem(Entities.Models.PortalNotification model)
        {
            var PortalNotification = base.PortalNotificationRepo.SaveItem(model);
            return PortalNotification;
        }
        public async Task SendEmailsForOfflineDevices() 
        {
            foreach (var item in GetItemListActiveEmail())
            {
                var User = base.PortalUserRepo.GetItemById(item.PortalUserId);
                await Service.Email.EmailService.SendEmail(item.Name, item.Description, User.Email);
                item.SoftDelete = true;
                SaveItem(item);
            }
        }
    }
}
