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

        public async Task<int> AddEntity<T>(T entity)
        {
            string tableName = entity.ToString();
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
                    throw; 
                }
            }
        }

        public async Task<bool> UpdateEntity<T>(T entity, int clientId)
        {
            string tableName = entity.ToString();
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    Type entityType = typeof(T);
                    PropertyInfo[] properties = entityType.GetProperties();

                    // Create the SET part of the UPDATE statement
                    string setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

                    // Construct the full UPDATE statement
                    string query = $"UPDATE {tableName} SET {setClause} WHERE ClientId = ${clientId}";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        foreach (PropertyInfo property in properties)
                        {
                            object value = property.GetValue(entity);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }

                        // Add the parameter for the WHERE clause
                   //     command.Parameters.AddWithValue("@ClientId", clientId);

                    await   command.ExecuteNonQueryAsync();
                        transaction.Commit();
                        return true;
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
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
