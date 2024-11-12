using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.New_Order_Event
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public float TotalPrice { get; }
        public string ClientEmail { get; }

        public OrderEventArgs(int orderID, float totalPrice, string clientEmail)
        {
            OrderID = orderID;
            TotalPrice = totalPrice;
            ClientEmail = clientEmail;
        }
    }
}
