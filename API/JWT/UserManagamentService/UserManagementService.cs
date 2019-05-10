using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.JWT.UserManagamentService
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsValidUser(string userName, string password)
        {
            //ubaci konekciju ka bazi
            return true;
        }
    }
}
