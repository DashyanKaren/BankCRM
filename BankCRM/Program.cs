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
            BalancesDAL balancesDAL = new BalancesDAL(dbManager);
            DocumentsDAL documentsDAL= new DocumentsDAL(dbManager);
            AdressesDAL adressesDAL= new AdressesDAL(dbManager);

            //RequestDto requestDto = new RequestDto() { FirstName="Nik", LastName="Pas"};
            //var x=genericDAL.GetEntity(requestDto);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item.ClientId);
            //    Console.Write(item.FirstName+" ");
            //    Console.WriteLine(item.LastName);
            //}
            //ClientsDto client = new ClientsDto()
            //{
            //    DateOfBirth = DateTime.Now,
            //    FirstName = "Saribek",
            //    LastName = "Voskanyan13",
            //    // ClientId = 1

            //};
            ////genericDAL.AddEntity(client);
            //var x = genericDAL.AddEntity(client).GetAwaiter();
            ////client.FirstName = "Ashot";


            ////genericDAL.UpdateEntity(client, x.GetResult());
            ////BalancesDto clientBalance = new BalancesDto()
            ////{

            ////    ClientId = 82,
            ////    BalanceAmount = 3,
            ////    CurrencyCode = Currency.USD
            ////};
            ////balancesDAL.UpdateEntity(clientBalance);
            //DocumentsDto documents = new DocumentsDto()
            //{
            //    ClientId = 82,
            //    DocumentType = "Passport",
            //    FileName = "ID",
            //    IsValid = true
            //};

            //genericDAL.AddEntity(documents);
            //genericDAL.DeleteEntity(16);

           // documentsDAL.UpdateEntity(documents,82);

            Console.ReadLine();

        }
       
    }
}