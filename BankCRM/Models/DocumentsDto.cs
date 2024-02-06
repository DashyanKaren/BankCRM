using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Models
{
    public class DocumentsDto
    {
        public string FileName { get; set; }
        //  public byte[] FileContent { get; set; }
        public string FilePath { get; set; }
        // Foreign key to associate with the client
        public int ClientId { get; set; } 
      //  public Client Client { get; set; }

        public string DocumentType { get; set; }  // e.g., Passport, ID Card, etc.
        public bool IsValid { get; set; }  // Indicates whether the document is valid or not
    }

}
