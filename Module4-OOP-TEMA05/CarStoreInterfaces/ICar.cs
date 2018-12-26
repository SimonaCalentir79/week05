using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface ICar
    {
        string Model { get; }

        int YearOfModel { get; }

        decimal PriceOfCar { get; }

        DateTime DeliveryDate { get; }

        IProducer Producer { get; }

        void PrintCar();
    }
}
