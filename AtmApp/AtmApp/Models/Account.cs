using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Models
{
    public  class Account
    {
        public long AccountNumber { get; set; }
        public long RoutingNumber { get; set; }
        public double CashBalance { get; set; }
        public DateTime OpenedDate { get; set; }
        public int UserId { get; set; }
    }
}
