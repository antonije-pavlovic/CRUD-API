﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.JWT.AuthService
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}
