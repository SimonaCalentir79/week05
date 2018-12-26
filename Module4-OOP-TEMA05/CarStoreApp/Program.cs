using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;
using CarStoreModels;

namespace CarStoreApp
{
    class Program
    {
        static void Main()
        {
            ICustomer customer = new Customer("Alexandru Ciobanu", "alex.ciobanu@gmail.com", "0745 123 456");

            ICar car1 = new Car("Focus",2015,15000,DateTime.Now.AddDays(-14),new Producer ("Ford"));
            ICar car2 = new Car("Mondeo", 2015, 18000, DateTime.Now.AddDays(-7), new Producer("Ford"));
            ICar car3 = new Car("Escort", 2015, 16000, DateTime.Now, new Producer("Ford"));
            IStore storeFord = new Store("Ford Dealer");
            storeFord.AddCar(car1);
            storeFord.AddCar(car2);
            storeFord.AddCar(car3);

            storeFord.VisitStore();

            Console.WriteLine("\n");
            Console.WriteLine("**Client 'Alex' intends to buy a Ford Focus, so an order is beeing registered.");

            IOrder orderFord = new Order(156,DateTime.Now.AddDays(-35),customer,car1);
            IOrderStatus newOrderOfFord = new OrderStatus("pending",DateTime.Now.AddDays(-35), "...");
            orderFord.AddStatus(newOrderOfFord);
            storeFord.AddOrder(orderFord);

            storeFord.PrintOrdersOfStore();

            Console.WriteLine("\n");
            Console.WriteLine("**Client 'Alex' is informed about the delivery date and he decides to search other options.");
            Console.WriteLine("**He visits Skoda Dealer");

            ICar car4 = new Car("Fabia", 2015, 14000, DateTime.Now.AddDays(-21), new Producer("Skoda"));
            ICar car5 = new Car("Octavia", 2015, 19000, DateTime.Now.AddDays(-14), new Producer("Skoda"));
            ICar car6 = new Car("Superb", 2015, 22000, DateTime.Now.AddDays(-7), new Producer("Skoda"));
            IStore storeSkoda = new Store("Skoda Dealer");
            storeSkoda.AddCar(car4);
            storeSkoda.AddCar(car5);
            storeSkoda.AddCar(car6);

            storeSkoda.VisitStore();

            Console.WriteLine("\n");
            Console.WriteLine("**Client 'Alex' decides to buy a Skoda Fabia, so another order is registered.");

            IOrder orderSkoda = new Order(182, DateTime.Now.AddDays(-33), customer, car4);
            IOrderStatus newOrderOfSkoda = new OrderStatus("confirmed", DateTime.Now.AddDays(-33), "...");
            orderSkoda.AddStatus(newOrderOfSkoda);
            storeSkoda.AddOrder(orderSkoda);

            storeSkoda.PrintOrdersOfStore();

            Console.WriteLine("\n");
            Console.WriteLine("**Client 'Alex' cancels the order for the Ford Focus.");

            IOrderStatus cancelOrderOfFord = new OrderStatus("cancelled", DateTime.Now.AddDays(-33), "Cancelled due to large delivery time.");
            orderFord.AddStatus(cancelOrderOfFord);
            storeFord.PrintOrdersOfStore();

            Console.WriteLine("\n");
            Console.WriteLine("**The Skoda Fabia client 'Alex' ordered is being received in the store.");

            IOrderStatus updateStatusOfSkoda = new OrderStatus("received", DateTime.Now.AddDays(-21), "The car has a minor problem to its front spoiler.");
            orderSkoda.AddStatus(updateStatusOfSkoda);
            storeSkoda.PrintOrdersOfStore();

            Console.WriteLine("\n");
            Console.WriteLine("**Two days later, the car is delivered to client 'Alex'.");

            IOrderStatus deliverSkoda = new OrderStatus("delivered", DateTime.Now.AddDays(-19), "The issue of the car has been resolved.");
            orderSkoda.AddStatus(deliverSkoda);
            storeSkoda.PrintOrdersOfStore();

            Console.ReadLine();
        }
    }
}
