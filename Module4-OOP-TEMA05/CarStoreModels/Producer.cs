﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class Producer : IProducer
    {
        public string Name { get ; }
        
        public string Location { get ; }

        public Producer(string name)
        {
            this.Name = name;
            this.Location = "Some location";
        }
    }
}
