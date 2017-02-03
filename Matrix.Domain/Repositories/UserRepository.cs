using Matrix.Domain.Interfaces;
using Matrix.Domain.Models.Database;
using ResMan.Domain.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Matrix.Domain.Repositories
{
    public class UserRepository : EntityFrameworkRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
