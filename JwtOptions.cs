namespace JFA.Utils.Jwt;

public static class JwtOptions
{
    public static string SecretKey { get; set; } = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзфывапролдячсмитьбюжэх123456789";
    public static string Issuer { get; set; } = "Issuer";
    public static string Audience { get; set; } = "Audience";
    public static int ExpirationInMinutes { get; set; } = 20;
}
