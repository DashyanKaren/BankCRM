using BankCRM.Models;
using BankCRM.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM
{
    internal interface IAdressesDAL
    {
        public Task<int> AddEntity<T>(T entity);
        public Task<bool> UpdateEntity<T>(T entity, int clientId);
        public Task<bool> DeleteEntity(int clientId);
        public List<AdressUI> GetEntity(RequestDto entity);
    }
}
