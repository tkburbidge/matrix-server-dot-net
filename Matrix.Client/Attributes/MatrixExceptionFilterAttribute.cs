using Matrix.Client.Errors;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Matrix.Client.Attributes
{
    public class MatrixExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is MatrixException)
            {
                MatrixException exception = (MatrixException)actionExecutedContext.Exception;
                actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.BadRequest, exception.Error);
            }
        }
    }
}