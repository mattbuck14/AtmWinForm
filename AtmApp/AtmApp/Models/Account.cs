using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Models
{
    public  class Account
    {
        public int AccountNumber { get; set; }
        public int RoutingNumber { get; set; }
        public double CashBalance { get; set; }
        public DateTime OpenedDate { get; set; }
        public int UserId { get; set; }
    }
}
