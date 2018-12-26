using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface IProducer
    {
        string Name { get; }

        string Location { get; }
    }
}
