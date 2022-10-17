# JFA.Utils.Jwt
Extension for using JWT.

[![latest version](https://img.shields.io/nuget/v/JFA.Utils.Jwt)](https://www.nuget.org/packages/JFA.Utils.Jwt) 
[![downloads](https://img.shields.io/nuget/dt/JFA.Utils.Jwt)](https://www.nuget.org/packages/JFA.Utils.Jwt)

# Steps

> Install package from [nuget.org](https://www.nuget.org/packages/JFA.Utils.Jwt)
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
