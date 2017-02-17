using Matrix.Domain.Interfaces;
using Matrix.Domain.Models.Database;
using ResMan.Domain.Repositories.EntityFramework;
using System.Data.Entity;

namespace Matrix.Domain.Repositories
{
    public class EventRepository : EntityFrameworkRepository<Event>, IEventRepository
    {
        public EventRepository(DbContext context) : base(context)
        {
        }
    }
}
