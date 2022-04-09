using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Models
{
    public class Transaction
    {
        public int TransactionNumber { get; set; }
        public double Withdrawl { get; set; }
        public double CashAmount { get; set; }
        public DateTime DateCompleted { get; set; }
        public long AccountNumber { get; set; }
    }
}
