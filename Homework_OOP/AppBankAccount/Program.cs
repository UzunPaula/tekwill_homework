using System;
using System.Collections.Generic;

namespace AppBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var persoana = new Persoana()
            {
                identificator = "200857657657676",
                tip = TipPersoana.Fizica,
            };

            var contBancar = new ContBancar(persoana, "20084543756", Moneda.MDL, "1000");
           
            contBancar.Alimentare(3000);
            contBancar.Extragere(1000);

            contBancar.Alimentare(5000);
            contBancar.Extragere(4500);

            Console.WriteLine($"Soldul curent este: {contBancar.DeterminaSold()}" );

        }
    }
}
