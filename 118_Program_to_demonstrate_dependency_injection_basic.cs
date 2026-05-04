using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 118. Program to demonstrate dependency injection (basic)
// Generated as a standalone sample file.
public class Problem118
{
    public static async Task Main()
    {
        IMessageService service = new EmailService();
        NotificationManager manager = new(service);
        manager.Notify("Dependency Injection made simple.");

        await Task.CompletedTask;
    }
}

interface IMessageService { void Send(string message); }
class EmailService : IMessageService { public void Send(string message) => Console.WriteLine($"Email: {message}"); }
class NotificationManager(IMessageService service)
{
    public void Notify(string message) => service.Send(message);
}