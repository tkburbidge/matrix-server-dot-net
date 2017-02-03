using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Matrix.Client.Models.Access
{
    public class TokenRefreshRequest
    {
        /// <summary>
        /// Required. The refresh token which was issued by the server.
        /// </summary>
        [Required]
        public string RefreshToken { get; set; }
    }

    public class TokenRefreshResponse
    {
        /// <summary>
        /// An access token for the account. This access token can then be used to authorize other requests. The access token may expire at some point, and if so, it SHOULD come with a refresh_token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// (optional) A refresh_token may be exchanged for a new access_token using the TODO Linkify /tokenrefresh API endpoint.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}