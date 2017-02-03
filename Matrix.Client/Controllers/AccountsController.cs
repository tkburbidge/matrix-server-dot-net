using Matrix.Client.App_Start;
using Matrix.Client.Models.Access;
using System.Web.Http;
using Matrix.Services.DependencyInjection;
using Matrix.Common.Errors;
using Matrix.Common;

namespace Matrix.Client.Controllers
{
    [RoutePrefix(ApiRouteConfig.RoutePrefix)]
    public class AccountsController : BaseController
    {
        public AccountsController(ServiceFactory serviceFactory, IUnitOfWork unitOfWork) : base(serviceFactory, unitOfWork)
        {
        }

        [HttpPost]
        [Route("register")]
        public RegisterResponse Register(RegisterRequest model, AccountKind kind = AccountKind.User)
        {
            if (kind == AccountKind.Guest && !MatrixConfig.AllowGuestAccounts)
            {
                throw MatrixException.GuestAccountsNotAllowed;
            }

            var user = this.serviceFactory.UserService.RegisterUser(model.Username, model.Password);
            this.unitOfWork.Commit();

            var response = new RegisterResponse();

            return response;
        }

        [HttpPost]
        [Route("login")]
        public LoginResponse Login(LoginRequest model)
        {
            var response = new LoginResponse();

            return response;
        }

        [HttpPost]
        [Route("tokenrefresh")]
        public TokenRefreshResponse TokenRefresh(TokenRefreshRequest model)
        {
            var response = new TokenRefreshResponse();

            return response;
        }
        
    }
}
