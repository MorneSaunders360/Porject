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
        public List<Entities.Models.PortalDeviceUsage> GetItemByPortalDeviceId(int PortalDeviceId,int Time=1)
        {         	//EXEC [PortalDeviceUsageProc] {Time},{PortalDeviceId}
            string qurrey = @$"
              
                        SELECT top 10 [Id]
                              ,[PortalDeviceId]
                              ,[Temps]
                              ,[WhenCreated]
                          FROM [dbo].[PortalDeviceUsage]
                          where [PortalDeviceId] = {PortalDeviceId}
                          order by [Id] desc
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
