using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 136. Program to demonstrate events
// Generated as a standalone sample file.
public class Problem136
{
    public static async Task Main()
    {
        OrderService service = new();
        service.OrderPlaced += (_, orderId) => Console.WriteLine($"Order placed: {orderId}");
        service.PlaceOrder(101);

        await Task.CompletedTask;
    }
}

class OrderService
{
    public event EventHandler<int>? OrderPlaced;
    public void PlaceOrder(int orderId) => OrderPlaced?.Invoke(this, orderId);
}