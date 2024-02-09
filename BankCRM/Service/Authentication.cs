using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankCRM.Service
{
    public class Authentication
    {
        private PasswordHasher PasswordHasher;
        private const string ConnectionString = "Server=localhost\\MSSQLSERVER01;Database=BankCRM;Trusted_Connection=True;";
        public Authentication()
        {
            PasswordHasher =PasswordHasher.Instance;
        }
        public bool AuthenticateUser(string username, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);

            bool isValidUser = ValidateUserCredentials(username, hashedPassword);

            return isValidUser;
        }

        private bool ValidateUserCredentials(string username, string hashedPassword)
        {
            username = username.Trim();
            hashedPassword = hashedPassword.Trim();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

    }
}
