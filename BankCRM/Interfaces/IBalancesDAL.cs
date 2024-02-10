using BankCRM.Models;
using BankCRM.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM
{
    public interface IBalances
    {
        public Task<int> AddEntity<T>(T entity);
        public Task<bool> UpdateEntity<T>(T entity);
        public Task<bool> DeleteEntity(int clientId);
        public List<BalancesUI> GetEntity(RequestDto entity);
    }
}
