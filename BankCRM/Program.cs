using BankCRM.Models;
using BankCRM.Repository;
using BankCRM.UIModels;

namespace BankCRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbManager dbManager = new DbManager("Server=localhost\\MSSQLSERVER01;Database=BankCRM;Trusted_Connection=True;");

            GenericDAL genericDAL = new GenericDAL(dbManager);
            //ClientDto client = new ClientDto()
            //{
            //    DateOfBirth = DateTime.Now,
            //    FirstName = "Nikol",
            //    LastName = "Pashinyan",
            //   // ClientId = 1

            //};
            //var x= genericDAL.AddEntity(client, "Clients");
            
            BalancesDto clientBalance = new BalancesDto()
            {

                BalanceAmount = 1000200,
                CurrencyCode = 4,
                ClientId =  38
            };
            genericDAL.AddEntity(clientBalance,"Balances");
            //DocumentsDto documents = new DocumentsDto()
            //{
            //    ClientId = x.Result,
            //    DocumentType = "Passport",
            //    FileName = "Passport",
            //    IsValid = true
            //};
          //genericDAL.AddEntity(documents, "Documents");
            Console.ReadLine();

        }
       
    }
}