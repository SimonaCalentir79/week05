using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    interface IStatusOfOrder
    {
        string StatusOfOrder { get; set; }
        DateTime DateOfStatus { get; set; }
        string Details { get; set; }
    }
}
