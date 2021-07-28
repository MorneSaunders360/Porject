using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalUserWallet
    {
        public int Id { get; set; }
        public int PortalUserId { get; set; }
        public int PortalWalletId { get; set; }
        public PortalWallet PortalWallet { get; set; }
    }
}
