﻿using Matrix.Domain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.Interfaces
{
    public interface IUserService
    {
        User RegisterUser(string username, string password);
        AccessToken Login(string usernameOrId, string password);
        Guid GetUserIdFromAccessToken(string token);
    }
}
