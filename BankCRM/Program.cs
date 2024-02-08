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
            RequestDto requestDto = new RequestDto() { FirstName="Nik", LastName="Pas"};
            var x=genericDAL.GetEntity(requestDto);
            foreach (var item in x)
            {
                Console.WriteLine(item.ClientId);
                Console.Write(item.FirstName+" ");
                Console.WriteLine(item.LastName);
            }
            //ClientsDto client = new ClientsDto()
            //{
            //    DateOfBirth = DateTime.Now,
            //    FirstName = "Sarik",
            //    LastName = "Voskanyan",
            //    // ClientId = 1

            //};
            //genericDAL.AddEntity(client);
            //var x = genericDAL.AddEntity(client).GetAwaiter();
            //client.FirstName = "Ashot";


            //genericDAL.UpdateEntity(client, x.GetResult());
            //BalancesDto clientBalance = new BalancesDto()
            //{

            //    ClientId = x.GetResult(),
            //    BalanceAmount = 10,
            //    CurrencyCode = Currency.AMD 
            //};
            //genericDAL.AddEntity(clientBalance);
            //DocumentsDto documents = new DocumentsDto()
            //{
            //    ClientId = x.GetResult(),
            //    DocumentType = "Passport",
            //    FileName = "Passport",
            //    IsValid = true
            //};
            //genericDAL.AddEntity(documents);
            //genericDAL.DeleteEntity(16);


            Console.ReadLine();

        }
       
    }
}