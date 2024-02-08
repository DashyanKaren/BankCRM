using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Models
{
    public class BalancesDto
    {
        
        public decimal BalanceAmount { get; set; }
        public Currency CurrencyCode { get; set; }

        public int ClientId { get; set; }
    
    }
    public enum Currency
    { 
     AMD=1,
     USD=2,
     EUR=3,
     RUR=4,
     CRYPTO=5
    }
}
