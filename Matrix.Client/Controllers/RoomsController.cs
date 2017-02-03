using Matrix.Client.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Matrix.Client.Controllers
{
    [RoutePrefix(ApiRouteConfig.RoutePrefix)]
    public class RoomsController : BaseController
    {
        [HttpPost]
        [Route("createRoom")]
        public IHttpActionResult CreateRoom()
        {
            return Ok();
        }
    }
}
