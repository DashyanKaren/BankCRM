using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Models
{
    public class RequestDto
    {
        public int? ClientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? PassportNumber { get; set; }
        public string? IDPassport { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public bool? IsMaried { get; set; }
        public string? EmployerName { get; set; }
        public string? JobTitle { get; set; }
        public string? WorkPhoneNumber { get; set; }
        public Currency? CurrencyCode { get; set; }
        public bool? IsValid { get; set; }
    }
}
