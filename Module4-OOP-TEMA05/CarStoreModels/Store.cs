using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class Store : IStore
    {
        public string Name { get; }

        public List<ICar> ListOfCars { get; }

        public List<IOrder> ListOfOrders { get; }

        public Store(string name)
        {
            this.Name = name;
            this.ListOfCars = new List<ICar>();
            this.ListOfOrders = new List<IOrder>();
        }

        public void AddCar(ICar car)
        {
            this.ListOfCars.Add(car);
        }

        public void AddOrder(IOrder order)
        {
            this.ListOfOrders.Add(order);
        }
        
        public void VisitStore()
        {
            Console.WriteLine($"\n**{this.Name.ToUpper()} employees present the offer: ");
            foreach (var car in ListOfCars)
            {
                car.PrintCar();
            }
        }

        public void PrintOrdersOfStore()
        {
            Console.WriteLine($"{this.Name.ToUpper()}");
            foreach (var order in ListOfOrders)
            {
                order.PrintOrder();
            }
        }
    }
}
