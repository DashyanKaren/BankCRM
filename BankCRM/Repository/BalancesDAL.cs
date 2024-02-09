using BankCRM.Interfaces.ForDAL;
using BankCRM.Models;
using BankCRM.UIModels;
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
    public class BalancesDAL:IBalances,IGetTableName
    {
        private readonly DbManager dbManager;

        public BalancesDAL(DbManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public async Task<int> AddEntity<T>(T entity)
        {
            string tableName = GetTableName(typeof(T).Name);
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

        public async Task<bool> UpdateEntity<T>(T entity)
        {
            string tableName = GetTableName(typeof(T).Name);
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    Type entityType = typeof(T);
                    PropertyInfo[] properties = entityType.GetProperties();

                    string setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

                    string query = $"UPDATE {tableName} SET {setClause} WHERE ClientID = @ClientID AND CurrencyCode = @CurrencyCode ";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        foreach (PropertyInfo property in properties)
                        {
                            object value = property.GetValue(entity);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }

                        await command.ExecuteNonQueryAsync();
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

        public async Task<bool> DeleteEntity(int clientId)
        {

            string[] tableNames = new string[1] { "Balances" };
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (var item in tableNames)
                    {
                        string query = $"DELETE FROM {item} WHERE ClientId = @ClientId";

                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ClientId", clientId);

                            await command.ExecuteNonQueryAsync();
                        }
                    }
                    transaction.Commit();
                    return true;

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<BalancesUI> GetEntity(RequestDto entity)
        {
            List<BalancesUI> result = new List<BalancesUI>();

            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = "SELECT * FROM Balances WHERE 1 = 1";

                    foreach (var item in entity.GetType().GetProperties())
                    {
                        if (item.GetValue(entity) != null && !string.IsNullOrEmpty(item.GetValue(entity).ToString()))
                        {
                            query += $" AND {item.Name} LIKE '%' + @{item.Name} + '%'";
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        foreach (var item in entity.GetType().GetProperties())
                        {
                            if (item.GetValue(entity) != null && !string.IsNullOrEmpty(item.GetValue(entity).ToString()))
                            {
                                command.Parameters.AddWithValue($"@{item.Name}", item.GetValue(entity));
                            }
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BalancesUI balance = new BalancesUI
                                {
                                    ClientId = reader.GetInt32(reader.GetOrdinal("ClientId")),
                                    BalanceAmount = reader.GetInt32(reader.GetOrdinal("BalanceAmount")),
                                    CurrencyCode = reader["CurrencyCode"].ToString(),

                                };

                                result.Add(balance);
                            }
                        }

                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return result;
        }



        public string GetTableName(string tableName)
        {
            int length = tableName.Length - 3;
            return tableName.Substring(0, length);
        }
    }
}
