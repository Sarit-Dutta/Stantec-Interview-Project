using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TeleHealth_API.Services;
using TeleHealth_API.Models;

namespace TeleHealth_API.Helpers
{
    /*
    Authentication Handler

    Description: Helper class that sets up the Authentication to the API by 
                decoding the authentication token passed in. This data is then
                compared against the list of available users in order to determine
                if the data provided is valid before the authentication ticket is 
                provided.

                This Helper class is actively used by the API on startup as declared
                in the AddAuthentication function within Startup.cs
    */
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserService _userService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IUserService userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // Confirm if the request contains the header containing the auth token.
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            User user = null;
            // Parse the header to extract username and password and compare against list of users
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                var username = credentials[0];
                var password = credentials[1];
                user = await _userService.Authenticate(username, password);
            }
            catch
            {
                // If Header formatting is incorrect.
                return AuthenticateResult.Fail("Invalid Header");
            }

            // Failure is returned in the scenario that the user data parsed does not exist.
            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            // Generates the Authentication Pass once all the previous conditions have been satisfied.
            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
                new Claim(ClaimTypes.Name, user.userName),
            };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}