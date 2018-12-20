using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public class Store:IStore
    {
        public string StoreName { get; }
        public List<Order> Orders { get; }

        public Store(string storeName)
        {
            this.StoreName = storeName;
            this.Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            if (!this.Orders.Contains(order))
            {
                this.Orders.Add(order);
            }
        }

        public void PrintStore()
        {
            Console.WriteLine($"\n\t Store name: {this.StoreName.ToUpper()}");
            foreach (var order in this.Orders)
            {
                order.PrintOrder();
            }
        }
    }
}
