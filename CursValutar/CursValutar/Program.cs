using System;

namespace CursValutar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euro = 19.20;
            double dollar = 18.95;

            Console.WriteLine("Bine ați venit la cursul valutar!");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Introduceți suma în lei:");
            double leiAmount = Convert.ToDouble(Console.ReadLine());

            double euroAmount = leiAmount / euro;
            double dollarAmount = leiAmount / dollar;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Suma în Euro este: {euroAmount:F2}");
            Console.WriteLine($"Suma în Dolari este: {dollarAmount:F2}");

            Console.ReadLine();
        }
    }
}
