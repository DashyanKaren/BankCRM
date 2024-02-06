using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.UIModels
{
    public class DocumentsUI
    {
        public int ClientId { get; set; }
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string DocumentType { get; set; }
        public bool IsValid { get; set; }
    }
}
