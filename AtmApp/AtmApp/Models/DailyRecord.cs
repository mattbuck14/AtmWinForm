using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Models
{
    public class DailyRecord
    {
        public long AccountNumber { get; set; }
        public DateTime DateToday { get; set; }
        public int NumberOfWithdrawls { get; set; }
    }
}
