using Matrix.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Client.Models.Rooms
{
    public class GetMessagesRequest
    {
        public Guid RoomId { get; set; }
        public string AccessToken { get; set; }
        public int? Limit { get; set; }
    }

    public class GetMessagesResponse
    {
        public Guid EventId { get; set; }
    }
}