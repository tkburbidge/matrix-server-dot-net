using Matrix.Client.Models.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Matrix.Web.Controllers
{
    public class ServerController : ApiController
    {
        [HttpGet]
        [Route("_matrix/client/versions")]
        public VersionsResponse Versions()
        {
            return new VersionsResponse();
        }
    }
}
