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
        public int CurrencyCode { get; set; }

        // Foreign key to associate with the client
        public int ClientId { get; set; }
        //public ClientDAL Client { get; set; }
    }
}
