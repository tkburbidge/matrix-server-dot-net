using Matrix.Domain.Interfaces;
using Matrix.Domain.Models.Database;
using ResMan.Domain.Repositories.EntityFramework;
using System.Data.Entity;

namespace Matrix.Domain.Repositories
{
    public class AccessTokenRepository : EntityFrameworkRepository<AccessToken>, IAccessTokenRepository
    {
        public AccessTokenRepository(DbContext context) : base(context)
        {
        }
    }
}
