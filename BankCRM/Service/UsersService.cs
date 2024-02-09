using BankCRM.Interfaces;
using BankCRM.Models;
using BankCRM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Service
{
    public class UserService
    {

        private readonly PasswordHasher passwordHasher;
        private readonly IUsersDAL userRepository;
        public UserService(UsersDAL usersDAL)
        {
            this.passwordHasher = PasswordHasher.Instance;
            this.userRepository = usersDAL; 
        }

        public void CreateUser(string usernamein, string emailin, string passwordin)
        {
            string hashedPassword = PasswordHasher.HashPassword(passwordin);

            UserDto newUser = new UserDto
            {
               
                username = usernamein,
                email = emailin,
                password = hashedPassword 
            };

            userRepository.AddUser(newUser);
        }
    }

}
