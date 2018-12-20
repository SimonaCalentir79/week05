using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public class Car:Producer, ICar
    {
        public string CarModel { get; }
        public int YearOfModel { get; }
        public decimal PriceOfCar { get; }
        public int WeeksForDelivery { get; }

        public Car(string producerName, string carModel, int yearOfModel, decimal priceOfCar, int weeksForDelivery)
        {
            this.ProducerName = producerName;
            this.CarModel = carModel;
            this.YearOfModel = yearOfModel;
            this.PriceOfCar = priceOfCar;
            this.WeeksForDelivery = weeksForDelivery;
        }

        public void PrintCar()
        {
            Console.WriteLine($"\t\t {this.ProducerName} {this.CarModel}, year: {this.YearOfModel} -- price: ($ {this.PriceOfCar}), delivery: {this.WeeksForDelivery} weeks.");
        }
    }
}
