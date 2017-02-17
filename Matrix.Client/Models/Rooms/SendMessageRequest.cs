using Matrix.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Client.Models.Rooms
{
    public class SendMessageRequest
    {
        public string Body { get; set; }
        public Guid RoomId { get; set; }
        public string AccessToken { get; set; }
    }

    public class SendMessageResponse
    {
        public Guid EventId { get; set; }
    }
}