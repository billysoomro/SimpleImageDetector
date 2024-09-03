using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SimpleImageDetector.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);

            var clientId = Environment.GetEnvironmentVariable("CLIENT_ID");
            var cognitoDomain = Environment.GetEnvironmentVariable("COGNITO_DOMAIN");

            var logoutUrl = $"{cognitoDomain}/logout?client_id={clientId}&logout_uri={Url.Action("Index", "Home", null, Request.Scheme)}";

            return Redirect(logoutUrl);            
        }
    }
}
