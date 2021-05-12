using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalSettingsLogic : Baselogic<Entities.Models.PortalSettings>
    {
        public PortalSettingsLogic()
        {
                
        }
        public List<Entities.Models.PortalSettings> GetItemList()
        {
            return base.PortalSettingsRepo.GetItems().ToList();
        }
        public Entities.Models.PortalSettings GetItemByName(string Name)
        {
            return base.PortalSettingsRepo.FindItem(new { Name = Name });
        }
        public Entities.Models.PortalSettings GetItemById(int PortalSettingId)
        {
            Entities.Models.PortalSettings PortalSettings = base.PortalSettingsRepo.GetItemById(PortalSettingId);
            if (PortalSettings == null)
            {
                PortalSettings = new Entities.Models.PortalSettings();

            }
            return PortalSettings;
        }
        public Entities.Models.PortalSettings SaveItem(Entities.Models.PortalSettings model)
        {
            return base.PortalSettingsRepo.SaveItem(model);
        }
    }
}
