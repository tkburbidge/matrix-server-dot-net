using Matrix.Client.Models.Base;
using System.Web.Http;

namespace Matrix.Client.Controllers
{
    [RoutePrefix("_matrix/client")]
    public class BaseController : ApiController
    {
        [HttpGet]
        [Route("versions")]
        public VersionsResponse Versions()
        {
            return new VersionsResponse();
        }
    }
}
