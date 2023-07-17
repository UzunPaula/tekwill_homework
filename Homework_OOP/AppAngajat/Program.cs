using System;


namespace AppAngajat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angajat ang1 = new Angajat("Uzun Paula", 20200.50, Departament.IT);
            ang1.AfisareDetalii();
            Console.WriteLine("--------------------------------------------------");

            //var angajatImplicit = new Angajat();
            //angajatImplicit.AfisareDetalii();
            //Console.WriteLine("--------------------------------------------------");

            Angajat ang2 = new Angajat("Linga Vasile", 22000, Departament.Management);
            ang2.AfisareDetalii();
            Console.WriteLine("--------------------------------------------------");
                
            Angajat ang3 = new Angajat("Chendighelean Diana", 18000, Departament.Contabilitate);
            ang3.AfisareDetalii();
            Console.WriteLine("--------------------------------------------------");

            Angajat ang4 = new Angajat("Leu Pantelimon", 15000, Departament.Marketing);
            ang4.AfisareDetalii();
            Console.WriteLine("--------------------------------------------------");

            Angajat ang5 = new Angajat("Pinzaru Viorel", 10000, Departament.Marketing);
            ang5.AfisareDetalii();
        }
    }
}
