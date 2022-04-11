using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface IAccountView
    {
        string AccountNumber { get; set; }
        string RoutingNumber { get; set; }
        string CashBalance { get; set; }
        DateTime OpenedDate { get; set; }
    }
}
