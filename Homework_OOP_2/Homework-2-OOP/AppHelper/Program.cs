using System;

namespace AppHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prefix1 = "cod";
            string cod1 = Helper.GenerareCodUnic(prefix1);
            Console.WriteLine($"Cod generat este: {cod1}");

            Console.WriteLine();

            string prefix2 = "dpn";
            string cod2 = Helper.GenerareCodUnic(prefix2);
            Console.WriteLine($"Cod generat este: {cod2}");

            Console.WriteLine();

            string prefix3 = "psm";
            string cod3 = Helper.GenerareCodUnic(prefix3);
            Console.WriteLine($"Cod generat este: {cod3}");
        }
    }
}
