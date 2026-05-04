using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

// 189. Secure Password Hashing
// Generated as a standalone sample file.
public class Problem189
{
    public static async Task Main()
    {
        string password = "P@ssw0rd123";
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);
        Console.WriteLine(Convert.ToBase64String(salt));
        Console.WriteLine(Convert.ToBase64String(hash));

        await Task.CompletedTask;
    }
}
