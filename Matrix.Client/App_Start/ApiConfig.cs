using Matrix.Client.App_Start;
using Matrix.Client.Attributes;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Matrix.Client
{
    public static class ApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ApiFormattersConfig.ConfigureFormatters(config.Formatters);
            ApiRouteConfig.RegisterRoutes(config);
            ApiFilterConfig.RegisterGlobalFilters(config.Filters);
        }
    }
}
