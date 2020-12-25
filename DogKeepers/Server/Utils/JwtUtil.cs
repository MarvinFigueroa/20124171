using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DogKeepers.Server.Utils
{
    public class JwtUtil : IJwtUtil
    {
        private readonly IConfiguration configuration;

        public JwtUtil(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Jwt Generate(dynamic data)
        {
            if (configuration["Authentication:SecretKey"] == null)
                return null;

            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:SecretKey"]));
            var signingCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtHeader = new JwtHeader(signingCredentials);

            int userId = (int)data.GetType().GetProperty("Id").GetValue(data, null);
            string userName = (string)data.GetType().GetProperty("Name").GetValue(data, null);

            var claims = new[] {
                new Claim("Id", userId.ToString()),
                new Claim(ClaimTypes.Name, userName),
                new Claim("Creation", DateTime.Now.Ticks.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            TimeSpan timeUntilMidnight = DateTime.Now.AddMinutes(6) - DateTime.Now;
            double secondsUntilMidnight = timeUntilMidnight.TotalSeconds;
            var expires = DateTime.Now.AddSeconds(secondsUntilMidnight);

            var jwtPayload = new JwtPayload(
                issuer: null,
                audience: null,
                claims,
                DateTime.Now,
                expires
            );

            var token = new JwtSecurityToken(jwtHeader, jwtPayload);

            return new Jwt()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ExpirationDate = expires
            };
        }
    }
}