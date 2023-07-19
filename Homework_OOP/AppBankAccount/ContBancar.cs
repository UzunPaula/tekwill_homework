using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBankAccount
{
    public class ContBancar
    {
        public readonly DateTime dataCrearii;
        public Persoana detinator;
        public readonly string nrCont;
        public Moneda moneda;
        private string pin;
        private List<Tranzactie> istoricTranzactii;

        public ContBancar(Persoana detinator, string nrCond, Moneda moneda, string pin)
        {
            this.detinator = detinator;
            this.nrCont = nrCond;
            this.moneda = moneda;
            this.pin = pin;

            istoricTranzactii = new List<Tranzactie>();
            dataCrearii = DateTime.UtcNow;
        }
        public void Alimentare(decimal suma)
        {
            var tranzactie = new Tranzactie(suma);

            istoricTranzactii.Add(tranzactie);

            Console.WriteLine();
            Console.WriteLine($"Alimentarea soldului cu: {suma}{moneda}. ");
            Console.WriteLine($"Soldul curent: {DeterminaSold()}. ");
        }

        public void Extragere(decimal suma)
        {
            if (suma > DeterminaSold())
            {
                Console.WriteLine();
                Console.WriteLine($"Tranzactie nereusita de {suma}{moneda}. Fonduri insuficiente !");
                Console.WriteLine($"Soldul curent: {DeterminaSold()}");

                return;
            }

            var tranzactie = new Tranzactie(-suma);

            istoricTranzactii.Add(tranzactie);

            Console.WriteLine($"Din cont au fost extrasi: {suma}{moneda}. ");
            Console.WriteLine($"Soldul curent: {DeterminaSold()}. ");
        }
        public decimal DeterminaSold()
        {
            decimal sold = 0;
            //foreach (decimal tranzactie in istoricTranzactii)
            //{
            //    sold += tranzactie;
            //}

            for (int i = 0; i < istoricTranzactii.Count; i++)
            {
                sold += istoricTranzactii[i].suma;
            }

            //return istoricTranzactii.Sum(t => t.suma);
            return sold;
        }
    }
}
