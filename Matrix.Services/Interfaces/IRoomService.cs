using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.Interfaces
{
    public interface IRoomService
    {
        void CreateRoom(Guid creatorUserId, string roomAlias);
    }
}
