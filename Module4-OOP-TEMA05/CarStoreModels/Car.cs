using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class Car : ICar
    {
        public string Model { get; }

        public int YearOfModel { get; }

        public decimal PriceOfCar { get; }

        public DateTime DeliveryDate { get; }

        public IProducer Producer { get; }

        public Car(string model, int yearOfModel, decimal priceOfCar, DateTime deliveryDate, IProducer producer)
        {
            this.Model = model;
            this.YearOfModel = yearOfModel;
            this.PriceOfCar = priceOfCar;
            this.DeliveryDate = deliveryDate;
            this.Producer = producer;
        }

        public void PrintCar()
        {
            Console.WriteLine($"\t {this.Producer.Name.ToUpper()} {this.Model.ToUpper()}, model {this.YearOfModel}");
            Console.WriteLine($"\t\t Price: {this.PriceOfCar} EUR \t Delivery date: {this.DeliveryDate}");
        }
    }
}
