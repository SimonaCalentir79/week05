using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface IOrderStatus
    {
        string Status { get; }

        DateTime DateOfStatus { get; }

        string Details { get; }

        void PrintStatus();
    }
}
