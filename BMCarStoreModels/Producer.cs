using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public abstract class Producer:IProducer
    {
        public string ProducerName { get; set; }
    }
}
