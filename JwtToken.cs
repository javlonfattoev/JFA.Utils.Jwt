using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace JFA.Utils.Jwt;

public static class JwtToken
{
    public static string GenerateToken(Claim[] claims)
    {
        var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtOptions.SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            JwtOptions.Issuer,
            JwtOptions.Audience,
            claims,
            expires: DateTime.Now.AddMinutes(JwtOptions.ExpirationInMinutes),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
