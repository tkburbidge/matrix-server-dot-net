using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Matrix.Client.Models.Access
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string BindEmail { get; set; }
        public string Password { get; set; }
        public AuthenticationData Auth { get; set; }
    }

    public class AuthenticationData
    {
        public string Session { get; set; }
        public string Type { get; set; }
    }

    public class RegisterResponse : LoginResponse
    {

    }
}