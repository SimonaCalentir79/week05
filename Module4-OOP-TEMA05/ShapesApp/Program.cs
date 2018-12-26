using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesModels;

namespace ShapesApp
{
    class Program
    {
        static void Main()
        {
            IShape triunghi = new Triangle(10,5);
            IShape dreptunghi = new Rectangle(12,6);
            IShape patrat = new Square(20);

            IShape[] arrShapes = new IShape[] {triunghi,dreptunghi,patrat};

            for (int i = 0; i < arrShapes.Length; i++)
            {
                Console.WriteLine($"\n\t Area of {arrShapes[i].GetType().Name} is {arrShapes[i].CalculateArea().ToString()} (height: {arrShapes[i].Height}, width: {arrShapes[i].Width}).");
            }

            Console.ReadLine();
        }
    }
}
