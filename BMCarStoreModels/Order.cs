using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public class Order:IOrder
    {
        public int NumberOfOrder { get; }
        public DateTime DateOfOrder { get; }
        public List<OrderStatus> StatusOfOrder { get; }
        public Customer Customer { get; }
        public List<Car> Cars { get; }

        private List<string> _listStatus = new List<string> { "pending confirmation", "confirmed", "cancelled", "delivered", "received" };

        public Order(int numberOfOrder, DateTime dateOfOrder, Customer customer)
        {
                this.NumberOfOrder = numberOfOrder;
                this.DateOfOrder = dateOfOrder;
                this.StatusOfOrder = new List<OrderStatus>();
                this.Customer = customer;
                this.Cars = new List<Car>();
        }
        public void SetStatus(OrderStatus status)
        {
            this.StatusOfOrder.Add(status);
        }
        public void AddCar(Car car)
        {
            if (!this.Cars.Contains(car))
            {
                this.Cars.Add(car);
            }
        }

        public void PrintOrder()
        {
            Console.WriteLine($"\t Order no.{this.NumberOfOrder}/{this.DateOfOrder}");
            Console.WriteLine($"\t\t Customer: {this.Customer.CustomerName} / {this.Customer.TelephoneNumber} / {this.Customer.Email}");
            foreach (var car in this.Cars)
            {
                car.PrintCar();
                foreach (var status in this.StatusOfOrder)
                {
                    status.PrintStatus();
                }
            }
        }
    }
}
