﻿using Matrix.Client.App_Start;
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
            this.serviceFactory.RoomService.CreateRoom()
        }
    }
}
