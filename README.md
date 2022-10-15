Extension for using JWT.

Add following line to Program.cs file

      builder.Services.AddJwt();

Get token anywhere:

      var claims = new[]
      {
         new Claim(ClaimTypes.Name, userName)
      };
      
      return JFA.Utils.Jwt.JwtToken.GenerateToken(claims);
