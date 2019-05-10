using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.JWT.UserManagamentService
{
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}
