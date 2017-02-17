using Matrix.Domain.Interfaces;
using Matrix.Domain.Models.Database;
using ResMan.Domain.Repositories.EntityFramework;
using System.Data.Entity;

namespace Matrix.Domain.Repositories
{
    public class RoomRepository : EntityFrameworkRepository<Room>, IRoomRepository
    {
        public RoomRepository(DbContext context) : base(context)
        {
        }
    }
}
