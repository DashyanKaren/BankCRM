using BankCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Interfaces
{
    public interface IUsersDAL
    {
        public Task<int> AddUser(UserDto userDto);
    }
}
