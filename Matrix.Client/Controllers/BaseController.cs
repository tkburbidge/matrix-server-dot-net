using Matrix.Client.App_Start;
using Matrix.Common;
using Matrix.Services.DependencyInjection;
using System.Web.Http;

namespace Matrix.Client.Controllers
{
    [RoutePrefix(ApiRouteConfig.RoutePrefix)]
    public class BaseController : ApiController
    {
        protected ServiceFactory serviceFactory;
        protected IUnitOfWork unitOfWork;

        public BaseController(ServiceFactory serviceFactory, IUnitOfWork unitOfWork)
        {
            this.serviceFactory = serviceFactory;
            this.unitOfWork = unitOfWork;
        }
    }
}
