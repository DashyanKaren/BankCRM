using BankCRM.Models;
using BankCRM.Repository;

namespace CRMUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SIgnedIn());
            string conn = "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
            DbManager dbManager = new DbManager(conn);
            GenericDAL genericDAL = new GenericDAL(dbManager);
            ClientsDto clientsDto = new ClientsDto();



        }
    }
}