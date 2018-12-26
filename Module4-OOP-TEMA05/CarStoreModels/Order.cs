using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class Order : IOrder
    {
        public int NumberOfOrder { get; }

        public DateTime DateOfOrder { get; }

        public ICustomer Customer { get; }

        public ICar Car { get; }

        public List<IOrderStatus> OrderStatus { get; }

        public Order(int numberOfOrder, DateTime dateOfOrder, ICustomer customer, ICar car/*, List<OrderStatus> orderStatus*/)
        {
            this.NumberOfOrder = numberOfOrder;
            this.DateOfOrder = dateOfOrder;
            this.Customer = customer;
            this.Car = car;
            this.OrderStatus = new List<IOrderStatus>();
        }

        public void AddStatus(IOrderStatus orderStatus)
        {
            this.OrderStatus.Add(orderStatus) ;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"\t ORDER no.{this.NumberOfOrder}/{this.DateOfOrder}");
            this.Customer.PrintCustomer();
            this.Car.PrintCar();
            foreach (var status in this.OrderStatus)
            {
                status.PrintStatus();
            }
        }
    }
}
