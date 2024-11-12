using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.New_Order_Event
{
    public class EmailService
    {
        public void Subscribe(Order order) 
        {
            order.OnOrderCreated += HandleOrederCreated;
        }

        public void Unsubscribe(Order order)
        {
            order.OnOrderCreated -= HandleOrederCreated;
        }

        public void HandleOrederCreated(object sender, OrderEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine($"---Email Service recieved a New order---");
            Console.WriteLine($"Order ID is : {e.OrderID}");
            Console.WriteLine($"Total Price : {e.TotalPrice}");
            Console.WriteLine($"Client email : {e.ClientEmail}");
            Console.WriteLine();
        }
    }
}
