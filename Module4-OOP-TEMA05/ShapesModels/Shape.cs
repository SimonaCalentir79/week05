using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesModels
{
    public abstract class Shape : IShape
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public abstract decimal CalculateArea();
    }
}
