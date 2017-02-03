using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Matrix.Common.Errors
{
    public class MatrixException : Exception
    {
        public MatrixError Error { get; set; }

        public MatrixException(string errcode, string error, HttpStatusCode statusCode)
        {
            this.Error = new MatrixError()
            {
                Errcode = errcode,
                Error = error,
                StatusCode = statusCode
            };
        }


        //Errors
        public static MatrixException InvalidUsername = new MatrixException("M_INVALID_USERNAME", "The requested username is not valid", HttpStatusCode.BadRequest);
        public static MatrixException Forbidden = new MatrixException("M_FORBIDDEN", "The username or password is incorrect", HttpStatusCode.Forbidden);
        public static MatrixException GuestAccountsNotAllowed = new MatrixException("GUEST_ACCOUNTS_NOT_ALLOWED", "Guest accounts are not allowed by this server", HttpStatusCode.BadRequest);
        public static MatrixException UserInUse = new MatrixException("M_USER_IN_USE", "The requested username has already been taken", HttpStatusCode.BadRequest);
    }

        public class MatrixError
        {
            public string Errcode { get; set; }
            public string Error { get; set; }
            public HttpStatusCode StatusCode { get; set; }
        }

}