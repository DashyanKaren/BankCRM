using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BankCRM.Models;

namespace BankCRM.UIModels
{
    public class ClientUI : ClientDto
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PassportNumber { get; set; }
        public string IDPassport { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsMaried { get; set; }
        public string EmployerName { get; set; }
        public string JobTitle { get; set; }
        public string WorkAddress { get; set; }
        public string WorkPhoneNumber { get; set; }
        public decimal Income { get; set; }

        // Balances in different currencies

        public virtual List<BalancesDto> Balances { get; set; }
        public AddressUI AddressUI { get; set; }
        // Navigation property for attached documents
        public virtual List<DocumentsDto> AttachedDocuments { get; set; }
    }
}
