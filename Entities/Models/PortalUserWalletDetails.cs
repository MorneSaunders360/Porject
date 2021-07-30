using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PortalUserWalletDetails
    {
        public int Id { get; set; }
        public int PortalUserId { get; set; }
        public string Currency { get; set; }
        public double CurrencyValue { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
