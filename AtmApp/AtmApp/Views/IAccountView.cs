using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface IAccountView
    {
        long AccountNumber { get; set; }
        long RoutingNumber { get; set; }
        double CashBalance { get; set; }
        DateTime OpenedDate { get; set; }
        int UserId { get; set; }
    }
}
