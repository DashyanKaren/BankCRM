using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.UIModels
{
    public class BalancesUI
    {
        public int ClientId { get; set; }
        public int BalanceId { get; set; }
        public decimal BalanceAmount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
