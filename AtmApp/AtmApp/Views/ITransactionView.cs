using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface ITransactionView
    {
        int TransactionNumber { get; set; }
        double Withdrawl { get; set; }
        double CashAmount { get; set; }
        DateTime DateCompleted { get; set; }
        long AccountNumber { get; set; }
    }
}
