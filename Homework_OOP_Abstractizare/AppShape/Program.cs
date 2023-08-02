using System;
using System.Collections.Generic;

namespace AppShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cerc1 = new Circle(3.5);
            var cerc2 = new Circle(5.7);
            
            cerc1.CalculateArea();
            cerc1.CalculatePerimeter();

            Console.WriteLine();
            
            cerc2.CalculateArea();
            cerc2.CalculatePerimeter();
            
            var rect1 = new Rectangle(7.2, 5.5);
            var rect2 = new Rectangle(10.0, 8.3);

            var shapes = new List<Shape>()
            {
                cerc1, cerc2, rect1, rect2
            };
            
            Console.WriteLine();

            rect1.CalculateArea();
            rect1.CalculatePerimeter();

            Console.WriteLine();

            rect2.CalculateArea();
            rect2.CalculatePerimeter();
        }
    }
}
