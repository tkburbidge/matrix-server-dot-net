﻿using Matrix.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Domain.DependencyInjection;
using Sodium;

namespace Matrix.Services.Concrete
{
    public class CryptographyService : ICryptographyService
    {
        public string HashPassword(string password)
        {
            return PasswordHash.ArgonHashString(password);
        }

        public bool CheckPassword(string hashedPassword, string password)
        {
            return PasswordHash.ArgonHashStringVerify(hashedPassword, password);
        }
    }
}
