using System;

namespace AppAngajat
{
    internal class Angajat
    {
        public string nume { get; set; }
        public double salariu { get; set; }
        public Departament departament { get; set; }

        public Angajat()
        {

        }
        public Angajat(string nume, double salariu, Departament departament)
        {
            this.nume = nume;
            this.salariu = salariu;
            this.departament = departament;
        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Numele: {nume}");
            Console.WriteLine($"Salariul: {salariu}");
            Console.WriteLine($"Departamentul: {departament}");
        }
    }
}
