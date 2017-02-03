using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.Interfaces
{
    public interface ICryptographyService
    {
        string HashPassword(string password);
        bool CheckPassword(string hashedPassword, string password);
    }
}
