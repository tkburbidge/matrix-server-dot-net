using Matrix.Domain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.Interfaces
{
    public interface IRoomService
    {
        Guid CreateRoom(Guid creatorUserId, string roomAlias);
        Guid SendMessage(Guid userId, string body, Guid roomId);
        List<Event> GetMessages(Guid roomId, int? limit);
    }
}
