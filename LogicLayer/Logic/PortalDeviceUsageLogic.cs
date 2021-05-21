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
            string qurrey = @$"
                          Select Id,PortalDeviceId,Temps,ROUND(REPLACE([Power], ',', '.'), 0)'Power',dateadd(hour, datediff(hour, 0, [WhenCreated]), 0) 'WhenCreated' from [PortalDeviceUsage]
                                        Where Id in
                                        (
                                        SELECT Top 10
                                        MAX(Id) as Id
                                        FROM [PortalDeviceUsage]
                                        Where[PortalDeviceId] ={PortalDeviceId}
                                        GROUP BY dateadd(hour, datediff(hour, 0, [WhenCreated]), 0)
                                        ORDER BY MAX(Id) DESC
                                        )
                                        ORDER BY Id DESC

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
