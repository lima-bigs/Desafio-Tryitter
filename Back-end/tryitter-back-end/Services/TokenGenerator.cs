using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using tryitter_back_end.Constants;
using tryitter_back_end.Models;

namespace tryitter_back_end.Services
{
    public class TokenGenerator
    {
        public string Generate(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = AddClaims(user),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(TokenConstant.Secret)),
                    SecurityAlgorithms.HmacSha256Signature
                ),
                Expires = DateTime.Now.AddYears(1)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private ClaimsIdentity AddClaims (User user)
        {
            var claims = new ClaimsIdentity();

            claims.AddClaim(new Claim("UserId", user.UserId.ToString()));

            return claims;
        }
    }
}