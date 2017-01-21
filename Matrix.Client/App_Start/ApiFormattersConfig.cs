using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;

namespace Matrix.Client.App_Start
{
    public class ApiFormattersConfig
    {
        public static void ConfigureFormatters(MediaTypeFormatterCollection formatters)
        {
            formatters.JsonFormatter.SerializerSettings.ContractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
        }
    }
}