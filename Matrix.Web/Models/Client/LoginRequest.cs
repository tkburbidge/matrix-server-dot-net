using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Matrix.Web.Models.Client
{
    public class LoginRequest
    {
        /// <summary>
        /// The user's password.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// When logging in using a third party identifier, the medium of the identifier. Must be 'email'.
        /// </summary>
        public string Medium { get; set; }

        /// <summary>
        /// The login type being used. Currently only "m.login.password" is supported.
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// The fully qualified user ID or just local part of the user ID, to log in.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Third party identifier for the user.
        /// </summary>
        public string Address { get; set; }
    }

    public class LoginResponse
    {
        /// <summary>
        /// An access token for the account. This access token can then be used to authorize other requests. The access token may expire at some point, and if so, it SHOULD come with a refresh_token. There is no specific error message to indicate that a request has failed because an access token has expired; instead, if a client has reason to believe its access token is valid, and it receives an auth error, they should attempt to refresh for a new token on failure, and retry the request with the new token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// The hostname of the homeserver on which the account has been registered.
        /// </summary>
        public string HomeServer { get; set; }

        /// <summary>
        /// The fully-qualified Matrix ID that has been registered.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// (optional) A refresh_token may be exchanged for a new access_token using the /tokenrefresh API endpoint.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}