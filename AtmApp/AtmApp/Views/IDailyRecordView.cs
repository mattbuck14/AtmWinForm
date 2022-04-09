using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface IDailyRecordView
    {
        long AccountNumber { get; set; }
        DateTime DateToday { get; set; }
        int NumberOfWithdrawls { get; set; }
    }
}
