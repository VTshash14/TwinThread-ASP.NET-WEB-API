using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security.OAuth;

namespace webApiTokenAuthentication
{
    public class MyAuthorizationServerProvider : Microsoft.Owin.Security.OAuth.OAuthAuthorizationServerProvider
    {
        //override Client authentication
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); //Validate client
        }

        //validate user credentials, then generate token
        //token is used to grant access
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new System.Security.Claims.ClaimsIdentity(context.Options.AuthenticationType);
            //validate client credentials here
            if (context.UserName == "admin" && context.Password == "admin")
            {
                identity.AddClaim(new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Role, "admin"));
                identity.AddClaim(new System.Security.Claims.Claim("username", "admin"));
                identity.AddClaim(new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, "Shashank Shinde"));
                context.Validated(identity);
            }
            else if (context.UserName == "user" && context.Password == "user")
            {
                identity.AddClaim(new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Role, "user"));
                identity.AddClaim(new System.Security.Claims.Claim("username", "user"));
                identity.AddClaim(new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, "Shinde Shashank"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Given username and password is invalid");
                return;
            }
        }
    }
}