using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.UIModels
{
    public class AdressUI
    {
        public int ClientId { get; set; }
        public int AdressId { get; set; }
        public string Title { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
