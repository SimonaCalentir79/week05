using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface IOrder
    {
        int NumberOfOrder { get; }

        DateTime DateOfOrder { get; }

        ICustomer Customer { get; }

        ICar Car { get; }

        List<IOrderStatus> OrderStatus { get; }

        void AddStatus(IOrderStatus orderStatus);

        void PrintOrder();
    }
}
