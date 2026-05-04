using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 192. Multi-tenant Application (Basic)
// Generated as a standalone sample file.
public class Problem192
{
    public static async Task Main()
    {
        TenantResolver resolver = new(["alpha.example.com", "beta.example.com"]);
        Console.WriteLine(resolver.Resolve("beta.example.com"));

        await Task.CompletedTask;
    }
}

class TenantResolver(IEnumerable<string> knownTenants)
{
    private readonly HashSet<string> _tenants = new(knownTenants, StringComparer.OrdinalIgnoreCase);
    public string Resolve(string host) => _tenants.Contains(host) ? host : "default";
}