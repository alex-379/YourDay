using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;
using YourDay.Components.Pages.Manager;

namespace YourDay
{
    public class GetClaims
    {
        public IEnumerable<Claim> claims;

        public string returnRole;

        [CascadingParameter]
        public Task<AuthenticationState> State { get; set; }

        public GetClaims()
        {
            claims = Enumerable.Empty<Claim>();
        }


        public async Task GetRole()
        {
            var authState = await State;
            var user = authState.User;

            if (user.Identity is not null && user.Identity.IsAuthenticated)
            {
                claims = user.Claims;
                returnRole = claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).Single();
            }
        }
    }
}