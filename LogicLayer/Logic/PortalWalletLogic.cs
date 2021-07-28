using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalWalletLogic : Baselogic<Entities.Models.PortalWallet>
    {
        public PortalWalletLogic()
        {
        }
        public List<Entities.Models.PortalWallet> GetPortalWallets()
        {
            var PortalWallet = base.PortalWalletRepo.GetItems().ToList();
            return PortalWallet;
        }
        public Entities.Models.PortalWallet GetItemById(int PortalWalletId)
        {
            var PortalWallet = base.PortalWalletRepo.GetItemById(PortalWalletId);
            return PortalWallet;
        }
        public Entities.Models.PortalWallet SaveItem(Entities.Models.PortalWallet model)
        {
            var PortalWallet = base.PortalWalletRepo.SaveItem(model);
            return PortalWallet;
        }
    }
}
