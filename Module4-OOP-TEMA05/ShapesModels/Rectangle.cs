using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesModels
{
    public class Rectangle:Shape
    {
        public Rectangle(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override decimal CalculateArea()
        {
            return this.Width * this.Height;
        }
    }
}
