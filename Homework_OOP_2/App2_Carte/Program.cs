using System;

namespace App2_Carte
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carte = new Carte("Unfuck yourself", "John Bishop", new DateTime(2020, 06, 09), 280);
           
            carte.AfisareDetalii();
        }
    }
}
