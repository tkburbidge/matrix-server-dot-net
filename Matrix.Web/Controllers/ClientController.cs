using Matrix.Web.Models.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Matrix.Web.Controllers
{
    public class ClientController : ApiController
    {
        [HttpPost]
        public LoginResponse Login(LoginRequest model)
        {
            var response = new LoginResponse();

            return response;
        }

        public RegisterResponse Register(RegisterRequest model, AccountKind kind = AccountKind.User)
        {
            MatrixConfig config;
            using (StreamReader sr = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/matrix.json")))
            {
                config = JsonConvert.DeserializeObject<MatrixConfig>(sr.ReadToEnd());
            }

            var response = new RegisterResponse();

            return response;
        }

        [HttpGet]
        public VersionsResponse Versions()
        {
            return new VersionsResponse();
        }


    }
}
