using BankCRM.Models;
using BankCRM.Repository;
using BankCRM.UIModels;

namespace BankCRM
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            DbManager dbManager = new DbManager("Server=localhost\\MSSQLSERVER01;Database=BankCRM;Trusted_Connection=True;");

            GenericDAL genericDAL = new GenericDAL(dbManager);
            ClientDto client = new ClientDto()
            {
                DateOfBirth = DateTime.Now,
                FirstName = "Emil",
                LastName = "Voskanyan",
                // ClientId = 1

            };
            //genericDAL.AddEntity(client);
            var x = genericDAL.AddEntity(client).GetAwaiter();
              client.FirstName = "Ashot";


              genericDAL.UpdateEntity(client, x.GetResult());
            BalancesDto clientBalance = new BalancesDto()
            {

                ClientId = x.GetResult(),
                BalanceAmount = 10,
                CurrencyCode = 8,
            };
            genericDAL.AddEntity(clientBalance);
            //DocumentsDto documents = new DocumentsDto()
            //{
            //    ClientId = x.GetResult(),
            //    DocumentType = "Passport",
            //    FileName = "Passport",
            //    IsValid = true
            //};
            //genericDAL.AddEntity(documents);
            Console.ReadLine();

        }
       
    }
}