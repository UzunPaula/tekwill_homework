using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_Carte
{
    public class Carte
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public DateTime AnPublicare { get; set; }
        public int NumarPagini { get; set; }

        public Carte(string titlu, string autor, DateTime anPublicare, int nrPagini)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicare = anPublicare;
            NumarPagini = nrPagini;
        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Titlul: {Titlu}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Anul publicarii: {AnPublicare:dd.MM.yyyy}");
            Console.WriteLine($"Numarul de pagini: {NumarPagini}");
        }
    }
}
