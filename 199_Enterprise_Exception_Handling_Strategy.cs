using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 199. Enterprise Exception Handling Strategy
// Generated as a standalone sample file.
public class Problem199
{
    public static async Task Main()
    {
        try
        {
            throw new BusinessException("A recoverable business rule failed.");
        }
        catch (BusinessException ex)
        {
            Console.WriteLine($"Business error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        await Task.CompletedTask;
    }
}

class BusinessException(string message) : Exception(message);