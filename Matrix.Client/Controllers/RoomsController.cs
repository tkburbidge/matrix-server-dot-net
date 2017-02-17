using Matrix.Client.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Matrix.Services.DependencyInjection;
using Matrix.Common;
using Matrix.Client.Models.Rooms;

namespace Matrix.Client.Controllers
{
    [RoutePrefix(ApiRouteConfig.RoutePrefix)]
    public class RoomsController : BaseController
    {
        public RoomsController(ServiceFactory serviceFactory, IUnitOfWork unitOfWork) : base(serviceFactory, unitOfWork)
        {
        }

        [HttpPost]
        [Route("createRoom")]
        public CreateRoomResponse CreateRoom(CreateRoomRequest model)
        {
            var userId = this.serviceFactory.UserService.GetUserIdFromAccessToken(model.AccessToken);
            var roomId = this.serviceFactory.RoomService.CreateRoom(userId, model.RoomAliasName);

            return new CreateRoomResponse()
            {
                RoomId = roomId
            };
        }

        public SendMessageResponse SendMessage(SendMessageRequest model)
        {
            var userId = this.serviceFactory.UserService.GetUserIdFromAccessToken(model.AccessToken);
            var eventId = this.serviceFactory.RoomService.SendMessage(userId, model.Body, model.RoomId);

            return new SendMessageResponse()
            {
                EventId = eventId
            };
        }

        public GetMessagesResponse GetMessages(GetMessagesRequest model)
        {
            var userId = this.serviceFactory.UserService.GetUserIdFromAccessToken(model.AccessToken);
            var messages = this.serviceFactory.RoomService.GetMessages(model.RoomId, model.Limit);

            return null;
        }

    }
}
