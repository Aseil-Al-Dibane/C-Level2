using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.New_Order_Event
{
    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;

        public void Create(int OrderID, float Price, string ClientEmail)
        {
            if(OnOrderCreated != null)
                OnOrderCreated(this, new OrderEventArgs(OrderID, Price, ClientEmail));
        }
    }
}
