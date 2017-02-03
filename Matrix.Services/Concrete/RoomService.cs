using Matrix.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Domain.DependencyInjection;
using Matrix.Services.DependencyInjection;
using Matrix.Domain.Models.Database;

namespace Matrix.Services.Concrete
{
    public class RoomService : Service, IRoomService
    {
        public RoomService(ServiceFactory serviceFactory, RepositoryFactory repositoryFactory) : base(serviceFactory, repositoryFactory)
        {
        }

        public void CreateRoom(Guid creatorUserId, string roomAlias)
        {
            Room room = new Room()
            {
                CreatorUserId = creatorUserId,
                
            };

            throw new NotImplementedException();
        }
    }
}
