using System.Security.Cryptography;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Security;

public static class PasswordHasher
{
    public static string Hash(string value)
    {
        var salt = RandomNumberGenerator.GetBytes(16);
        var hash = Rfc2898DeriveBytes.Pbkdf2(value, salt, 120_000, HashAlgorithmName.SHA256, 32);
        return $"120000.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
    }

    public static bool Verify(string value, string encoded)
    {
        try
        {
            var parts = encoded.Split('.');
            if (parts.Length != 3) return false;
            var salt = Convert.FromBase64String(parts[1]);
            var expected = Convert.FromBase64String(parts[2]);
            var actual = Rfc2898DeriveBytes.Pbkdf2(value, salt, int.Parse(parts[0]), HashAlgorithmName.SHA256, expected.Length);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }
        catch { return false; }
    }
}

public sealed class UserSession
{
    public int UserId { get; }
    public string Username { get; }
    public UserSession(int userId, string username) { UserId = userId; Username = username; }
}
