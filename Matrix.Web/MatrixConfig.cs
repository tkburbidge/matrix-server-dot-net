using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Matrix.Web
{
    public static class MatrixConfig
    {
        public static readonly bool AllowGuestAccounts = bool.Parse(ConfigurationManager.AppSettings["AllowGuestAccounts"] ?? "false");
    }
}