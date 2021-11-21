using Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Services
{
    public class AccountService : IAccountService
    {
        private ReadLaterDataContext _ReadLaterDataContext;
        private readonly string _jwtIssuer;
        public AccountService(ReadLaterDataContext readLaterDataContext, string jwtIssuer)
        {
            _ReadLaterDataContext = readLaterDataContext;
            _jwtIssuer = jwtIssuer;
    }

        public AccessTokenResponse BuildAccessToken(IdentityUser user)
        {
            var claims = new List<Claim>
                {
                    new Claim("id", user.Id.ToString()),
                    new Claim("username", user.Email ?? ""),
                    new Claim("email", user.Email ?? "")
                };

            // create access token
            var expiresInSeconds = (int)TimeSpan.FromMinutes(20).TotalSeconds;
            var token = new JwtSecurityToken(
                _jwtIssuer,
                _jwtIssuer,
                expires: DateTime.UtcNow.AddSeconds(expiresInSeconds),
                signingCredentials: null,
                claims: claims);

            // create refresh token
            var refreshExpiresInSeconds = (int)TimeSpan.FromDays(15).TotalSeconds;
            var jwtRefreshToken = new JwtSecurityToken(
                _jwtIssuer,
                _jwtIssuer,
                expires: DateTime.UtcNow.AddSeconds(refreshExpiresInSeconds),
                signingCredentials: null,
                claims: claims);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            var refreshToken = new JwtSecurityTokenHandler().WriteToken(jwtRefreshToken);

            return new AccessTokenResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiresIn = expiresInSeconds.ToString(),
            };
        }

    }
}
