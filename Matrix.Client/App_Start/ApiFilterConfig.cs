using Matrix.Client.Attributes;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace Matrix.Client
{
    public class ApiFilterConfig
    {
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new MatrixExceptionFilterAttribute());
        }
    }
}
