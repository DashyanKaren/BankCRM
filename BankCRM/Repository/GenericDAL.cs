using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BankCRM.Interfaces;

namespace BankCRM.Repository
{
    public class GenericDAL
    {
        private readonly DbManager dbManager;

        public GenericDAL(DbManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public async Task<int> AddEntity<T>(T entity, string tableName)
        {
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    Type entityType = typeof(T);
                    PropertyInfo[] properties = entityType.GetProperties();

                    string columns = string.Join(", ", properties.Select(p => p.Name));
                    string values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                    string query = $"SET IDENTITY_INSERT {tableName} OFF; " +
                                   $"INSERT INTO {tableName} ({columns}) VALUES ({values}); " +
                                   "SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.Clear();
                        foreach (PropertyInfo property in properties)
                        {
                            object value = property.GetValue(entity);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }


                        var clientId = Convert.ToInt32(await command.ExecuteScalarAsync());

                        transaction.Commit();
                        return clientId;
                    }

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw; // Re-throw the exception to propagate it up the call stack
                }
            }
        }

        public void UpdateEntity<T>(T entity, string tableName, string[] propertyNames, object[] propertyValues, string idPropertyName, object idPropertyValue)
        {
            // Similar to AddEntity but with an UPDATE query
        }

        public void DeleteEntity<T>(string tableName, string idPropertyName, object idPropertyValue)
        {
            // Similar to AddEntity but with a DELETE query
        }

        public T GetEntity<T>(string tableName, string idPropertyName, object idPropertyValue)
        {
            // Similar to AddEntity but with a SELECT query and returning the result
            return default;
        }
    }
}
