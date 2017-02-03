using Matrix.Domain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
