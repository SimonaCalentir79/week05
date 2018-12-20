using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    interface ICar
    {
        string CarModel { get; }
        int YearOfModel { get; }
        decimal PriceOfCar { get; }
        int WeeksForDelivery { get; }
    }
}
