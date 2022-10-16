# JFA.Utils.Jwt
Extension for using JWT.

# Steps

> Install package
```PM
NuGet\Install-Package JFA.Utils.Jwt -Version <VERSION>
```
#
> Add following line to Program.cs file
```C#
builder.Services.AddJwt();
```
#
> Get token anywhere:
```C#
var claims = new[]
{
   new Claim(ClaimTypes.Name, userName)
};

return JFA.Utils.Jwt.JwtToken.GenerateToken(claims);
```
