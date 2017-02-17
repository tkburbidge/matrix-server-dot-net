using Matrix.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Domain.DependencyInjection;
using Matrix.Services.DependencyInjection;
using Matrix.Domain.Models.Database;
using Matrix.Common.Constants;

namespace Matrix.Services.Concrete
{
    public class RoomService : Service, IRoomService
    {
        public RoomService(ServiceFactory serviceFactory, RepositoryFactory repositoryFactory) : base(serviceFactory, repositoryFactory)
        {
        }

        public Guid CreateRoom(Guid creatorUserId, string roomAlias)
        {
            Room room = new Room()
            {
                CreatorUserId = creatorUserId,
            };

            this.repositoryFactory.RoomRepository.Add(room);

            var newRoomAlias = new RoomAlias()
            {
                RoomAliasName = roomAlias,
                RoomId = room.RoomId
            };

            this.repositoryFactory.RoomAliasRepository.Add(newRoomAlias);

            return room.RoomId;
        }

        public Guid SendMessage(Guid userId, string body, Guid roomId)
        {
            var newEvent = new Event()
            {
                Content = body,
                RoomId = roomId,
                Type = EventTypes.Text
            };

            this.repositoryFactory.EventRepository.Add(newEvent);

            return newEvent.EventId;
        }

        public List<Event> GetMessages(Guid roomId, int? limit)
        {
            var messages = (from e in this.repositoryFactory.EventRepository.FindAll()
                            where e.RoomId == roomId
                                && e.Type == EventTypes.Text
                            select e).ToList();

            return messages;
        }

    }
}
