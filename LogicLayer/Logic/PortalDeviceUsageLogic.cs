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
            string qurrey = @$"SELECT TOP 10
							    MAX([Id]) as 'Id',
								MAX([PortalDeviceId]) as 'PortalDeviceId' ,
								MAX([Power]) as 'Power',
								MAX([Temps]) as 'Temps',
								MAX([WhenCreated]) as 'WhenCreated'
					FROM [PortalDeviceUsage]
							Where[PortalDeviceId] = {PortalDeviceId}
				GROUP BY CAST([WhenCreated] as DATE), DATEPART(Hour, [WhenCreated])
				ORDER BY MAX([Id]) DESC
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
