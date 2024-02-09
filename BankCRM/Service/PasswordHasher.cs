using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace BankCRM.Service
{

        public  class PasswordHasher
        {
            private static PasswordHasher instance;

            private PasswordHasher() { }

            public static PasswordHasher Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new PasswordHasher();
                    }
                    return instance;
                }
            }

        public static string HashPassword(string password)
        {

            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }


}
