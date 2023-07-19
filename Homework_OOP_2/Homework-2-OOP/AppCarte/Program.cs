using System;

namespace AppCarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte carte = new Carte("Unfuck Yourself", "John Bishop",new DateTime(2020, 4, 15), 240);
            carte.AfisareDetalii();
        }
    }
}
