using Microsoft.AspNetCore.Identity;

namespace Services
{
    public interface IAccountService
    {
        AccessTokenResponse BuildAccessToken(IdentityUser user);
    }

    public class AccessTokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresIn { get; set; }
    }
}
