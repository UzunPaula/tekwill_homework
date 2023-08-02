using System;

namespace AppShape
{
    public class Circle : Shape
    {
        public double Raza { get; private set; }
        public Circle(double raza)
        {
            Name = "Circle";
            Raza = raza;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Raza,2);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Raza;
        }
    }
}
