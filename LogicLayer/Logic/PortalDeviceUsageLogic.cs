using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalDeviceUsageLogic : Baselogic<Entities.Models.PortalDeviceUsage>
    {
        public PortalDeviceUsageLogic()
        {

        }
        public List<Entities.Models.PortalDeviceUsage> GetItemByPortalDeviceId(int PortalDeviceId)
        {
            string qurrey = @$"SELECT TOP (10)
                              [PortalDeviceId]
                              ,[Temps]
                              ,[Power]
                              ,[WhenCreated]
                          FROM[dbo].[PortalDeviceUsage]
                          Where[PortalDeviceId] = {PortalDeviceId}
                          Order By Id desc
                          ";
            var PortalDeviceUsage = base.PortalDeviceUsageRepo.GetSql(qurrey).ToList();
            return PortalDeviceUsage;
        }
        public Entities.Models.PortalDeviceUsage SaveItem(Entities.Models.PortalDeviceUsage model)
        {
            var PortalDeviceUsage = base.PortalDeviceUsageRepo.SaveItem(model);
            return PortalDeviceUsage;
        }
    }
}
