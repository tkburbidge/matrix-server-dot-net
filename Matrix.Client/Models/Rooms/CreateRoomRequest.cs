using Matrix.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Client.Models.Rooms
{
    public class CreateRoomRequest
    {
        public List<string> Invite { get; set; }
        public string Name { get; set; }
        public RoomVisibility Visibility { get; set; }
        //public List<ThirdPartyIdInvite> Invite3pid { get; set; }
        public string Topic { get; set; }
        public RoomPreset Preset { get; set; }
        //public RoomCreationContent CreationContent { get; set; }
        //public List<RoomStateEvent> InitialState { get; set; }
        public string RoomAliasName { get; set; }
    }

    public class CreateRoomResponse
    {
        public string RoomId { get; set; }
    }
}