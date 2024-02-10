using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankCRM.Interfaces;
using BankCRM.Interfaces.ForDAL;
using BankCRM.Interfaces.IService;
using BankCRM.Models;
using BankCRM.Repository;
using BankCRM.Service;
using BankCRM.UIModels;

namespace BankCRM
{
    public class ClientsService:ServiceBase, IClientService
    {
        private readonly IGenericDAL _genericDAL;
        private readonly IBalances _balancesDal;
        private readonly IDocumentsDAL _documentsDal;
        private readonly IAdressesDAL _adressesDAL;
        private readonly string connectionString = "Server=localhost\\MSSQLSERVER01;Database=BankCRM;Trusted_Connection=True;";
        public ClientsService(IGenericDAL genericDAL, IDocumentsDAL documentsDAL, IAdressesDAL adressesDAL, IBalances balances)
        {
            _adressesDAL = adressesDAL;
            _genericDAL = genericDAL;
            _balancesDal = balances;
            _documentsDal = documentsDAL;
        }

        public async Task<int> CreateClientAsync(ClientsDto client, List<DocumentsDto> documents, List<AdressesDto> addresses, List<BalancesDto> balances)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                       int ClientId= _genericDAL.AddEntity(client).Result;
                        foreach (var document in documents)
                        {
                            document.ClientId = ClientId;
                             _documentsDal.AddEntity(document);
                        }

                        foreach (var address in addresses)
                        {
                            address.ClientId = ClientId;
                            _documentsDal.AddEntity(address);
                        }

                        foreach (var balance in balances)
                        {
                            balance.ClientId = ClientId;
                            _documentsDal.AddEntity(balance);
                        }
                        transaction.Commit();
                        return ClientId ;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public Task<bool> DeleteEntity(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditClientAsync(int ClientId, ClientsDto updateClient)
        {
            throw new NotImplementedException();
        }

        public List<object> GetClient(RequestDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
