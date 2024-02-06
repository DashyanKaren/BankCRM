using BankCRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Repository
{
    public class BalancesDAL
    {
        private readonly DbManager dbManager;

        public BalancesDAL(DbManager dbManager)
        {
            this.dbManager = dbManager;
        }

       
        public async Task AddEntity<T>(T entity )
        {
            string tableName = "Balances";
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    Type entityType = typeof(T);
                    PropertyInfo[] properties = entityType.GetProperties();
                   
                    string columns = string.Join(", ", properties.Select(p => p.Name));
                    string values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                    string query = $"SET IDENTITY_INSERT {tableName} ON; " +
                                   $"INSERT INTO {tableName} ({columns}) VALUES ({values}); " +
                                   $"SET IDENTITY_INSERT {tableName} OFF; " +
                                   "SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                       // command.Parameters.Clear();
                        foreach (PropertyInfo property in properties)
                        {
                            object value = property.GetValue(entity);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }

                        // Execute the query asynchronously and retrieve the identity value
                        //var identityValue = await command.ExecuteScalarAsync();
                        //  var customerId = Convert.ToInt32(identityValue);
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction if all steps succeed
                    transaction.Commit();

                    //dbManager.CloseConnection(connection);

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw; // Re-throw the exception to propagate it up the call stack
                }
            }
        }
    }
}
