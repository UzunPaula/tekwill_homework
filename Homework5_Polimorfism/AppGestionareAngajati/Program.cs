using System;
using System.Collections.Generic;

namespace AppGestionareAngajati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var angajati = new List<Angajat>
            {
                new Manager
                {
                    Nume = "Fazli Luna",
                    Vechime = 7
                },
                new Programator
                {
                    LimbajeDeProgramareCunoscute = new List<string>
                    {
                        "JavaScript",
                        "Java",
                        "Python",
                        "C#"
                    },
                    Nume = "Uzun Paula",
                    Vechime = 3
                },
                new Contabil
                {
                    Nume = "Armanu Gloria",
                    Vechime = 5
                }
            };
            foreach (var ang in angajati)
            {
                Console.WriteLine(ang.Nume);
                Console.WriteLine(ang.CalculeazaSalariu());
                Console.WriteLine();
            }
        }
    }
}
