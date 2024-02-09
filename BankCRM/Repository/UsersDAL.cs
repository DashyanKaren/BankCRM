using BankCRM.Interfaces;
using BankCRM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Repository
{
    public class UsersDAL:IUsersDAL
    {
        private readonly DbManager dbManager;
        public UsersDAL(DbManager dbManager)
        {
            this.dbManager = dbManager;
        }
        public async Task<int> AddUser(UserDto userDto)
        {
            using (SqlConnection connection = dbManager.OpenConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    Type entityType = typeof(UserDto);
                    PropertyInfo[] properties = entityType.GetProperties();

                    string columns = string.Join(", ", properties.Select(p => p.Name));
                    string values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                    string query = $"SET IDENTITY_INSERT Users OFF; " +
                                   $"INSERT INTO Users ({columns}) VALUES ({values}) " +
                                   "SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.Clear();
                        foreach (PropertyInfo property in properties)
                        {
                            object value = property.GetValue(userDto);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }


                        
                        var userId = Convert.ToInt32(await command.ExecuteScalarAsync());

                        transaction.Commit();
                        return userId;
                    }

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }
        }
    }
}
