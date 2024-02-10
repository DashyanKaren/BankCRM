using BankCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Interfaces.IService
{
    public interface IClientService
    {
        Task<int> CreateClientAsync(ClientsDto customer, List<DocumentsDto> documents, List<AdressesDto> addresses, List<BalancesDto> balances);

        Task<bool> EditClientAsync(int ClientId, ClientsDto updateClient);

        List<object> GetClient(RequestDto entity);
        Task<bool> DeleteEntity(int clientId);

    }
}
