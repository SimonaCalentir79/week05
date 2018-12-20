using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    interface IOrder
    {
        int NumberOfOrder { get; }
        DateTime DateOfOrder { get; }
    }
}
