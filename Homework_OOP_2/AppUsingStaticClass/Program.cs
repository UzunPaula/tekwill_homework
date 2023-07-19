using System;

namespace AppUsingStaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generareCodUnic = Helper.GenerareCodUnic("cod");
            Console.WriteLine($"Codul generat este: {generareCodUnic}");
            Console.WriteLine();

            var generareCodUnic2 = Helper.GenerareCodUnic("gwen");
            Console.WriteLine($"Codul generat este: {generareCodUnic2}");
            Console.WriteLine();

            var generareCodUnic3 = Helper.GenerareCodUnic("kqsp");
            Console.WriteLine($"Codul generat este: {generareCodUnic3}");
        }
    }
}
