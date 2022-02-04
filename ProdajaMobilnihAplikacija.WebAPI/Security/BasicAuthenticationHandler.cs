using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProdajaMobilnihAplikacija.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKlijentService _userService;
        private readonly IZaposlenikService _zaposlenikService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKlijentService userService,
            IZaposlenikService zaposlenikService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _zaposlenikService = zaposlenikService;
        }


        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return await Task.FromResult(AuthenticateResult.NoResult());
            }

            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Klijent klijent = null;
            Model.Zaposlenik zaposlenik = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                klijent = _userService.Authenticiraj(username, password);
                zaposlenik = _zaposlenikService.Authenticiraj(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }


            if (zaposlenik == null && klijent == null)
                return AuthenticateResult.Fail("Invalid Username or Password");
            if (zaposlenik != null && zaposlenik.Aktivan == true)
            {
                var claimsZaposlenik = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, zaposlenik.KorisnickoIme),
                new Claim(ClaimTypes.Name, zaposlenik.Ime),
                };

                claimsZaposlenik.Add(new Claim(ClaimTypes.Role, zaposlenik.KorisnickiNalog.TipKorisnickogNaloga));

                var identity = new ClaimsIdentity(claimsZaposlenik, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else if (klijent != null)
            {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, klijent.KorisnickoIme),
                new Claim(ClaimTypes.Name, klijent.Ime),
                };

                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else
            {
                return AuthenticateResult.Fail("Invalid Username or Password");
            }

        }
    }
}
