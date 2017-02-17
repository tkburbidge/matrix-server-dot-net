using Matrix.Domain.Interfaces;
using Matrix.Domain.Models.Database;
using ResMan.Domain.Repositories.EntityFramework;
using System.Data.Entity;

namespace Matrix.Domain.Repositories
{
    public class RoomAliasRepository : EntityFrameworkRepository<RoomAlias>, IRoomAliasRepository
    {
        public RoomAliasRepository(DbContext context) : base(context)
        {
        }
    }
}
