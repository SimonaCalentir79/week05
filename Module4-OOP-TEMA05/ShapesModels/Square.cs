using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesModels
{
    public class Square:Shape 
    {
        public Square(decimal width)
        {
            this.Width = width;
            this.Height = width;
        }

        public override decimal CalculateArea()
        {
            return this.Width * this.Height;
        }
    }
}
