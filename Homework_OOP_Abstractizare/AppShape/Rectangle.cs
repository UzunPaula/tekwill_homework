using System;

namespace AppShape
{
    public class Rectangle : Shape
    {
        public double Lungime { get; set; }
        public double Latime { get; set; }
        public Rectangle(double lungime, double latime)
        {
            Name = "Rectangle";
            Lungime = lungime;
            Latime = latime;
        }

        public override double CalculateArea() => Lungime* Latime;

        public override double CalculatePerimeter() => 2 * Lungime + 2 * Latime;

    }
}
