using Matrix.Client.App_Start;
using Matrix.Client.Models.Base;
using System.Web.Http;

namespace Matrix.Client.Controllers
{
    [RoutePrefix(ApiRouteConfig.RoutePrefix)]
    public class BaseController : ApiController
    {
    }
}
