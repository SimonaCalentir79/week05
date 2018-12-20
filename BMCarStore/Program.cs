using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMCarStoreModels;

namespace BMCarStore
{
    class Program
    {
        static void Main()
        {
            var car1 = new Car("Ford", "Focus", 2015, 15000, 4);
            var car2 = new Car("Skoda", "Fabia", 2015, 14000, 3);

            var customer = new Customer("Customer1", "email@email", "0744111111");

            var order1 = new Order(201501, new DateTime(2018, 11, 10), customer);
            order1.SetStatus(new OrderStatus("pending confirmation", new DateTime(2018, 11, 10), ""));
            order1.AddCar(car1);
            var store1 = new Store("Ford Dealer");
            store1.AddOrder(order1);

            Console.WriteLine("\n ***Order for Ford Focus is registered: ");
            store1.PrintStore();

            Console.WriteLine("\n ***Customer is informed about the delivery time and decides to seek other options.");
            var order2 = new Order(201502, new DateTime(2018, 11, 15), customer);
            order2.SetStatus(new OrderStatus ("confirmed", new DateTime(2018, 11, 15), ""));
            order2.AddCar(car2);
            var store2 = new Store("Skoda Dealer");
            store2.AddOrder(order2);

            Console.WriteLine("\n ***Order for Skoda Fabia is registered: ");
            store2.PrintStore();

            Console.WriteLine("\n ***Order for Ford Focus is cancelled:");
            order1.SetStatus(new OrderStatus("cancelled", new DateTime(2018, 11, 16), "Client cancelled due to large delivery time."));
            store1.PrintStore();

            Console.WriteLine("\n ***The car is received in store:");
            order2.SetStatus(new OrderStatus("received", new DateTime(2018, 12, 06), "Car received with minor issues to its front spoiler."));
            store2.PrintStore();

            Console.WriteLine("\n ***The car's problem is solved and is delivered to customer:");
            order2.SetStatus(new OrderStatus("delivered", new DateTime(2018, 12, 08), "Problem to the front spoiler SOLVED!"));
            store2.PrintStore();

            Console.ReadLine();
        }
    }
}
