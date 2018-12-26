using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesModels
{
    public interface IShape
    {
        decimal Width { get; }
        decimal Height { get; }

        decimal CalculateArea();
    }
}
