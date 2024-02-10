using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankCRM.Interfaces.IService;

namespace BankCRM.Service
{
    public class ServiceBase : IServiceBase
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
