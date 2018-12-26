using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface IStore
    {
        string Name { get; }

        List<ICar> ListOfCars { get; }

        List<IOrder> ListOfOrders { get; }

        

        void AddCar(ICar car);

        void AddOrder(IOrder order);

        void VisitStore();

        void PrintOrdersOfStore();
    }
}
