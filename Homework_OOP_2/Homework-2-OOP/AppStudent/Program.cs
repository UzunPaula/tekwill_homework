using System;

namespace AppStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Luna", 22, "Marketing");
            Student copyStud = new Student(stud);

            stud.Nume = "Paula";
            stud.Varsta = 20;
            stud.Specializare = "IT";

            Console.WriteLine("Detaliile obiectului original:");
            stud.AfisareDetalii();

            Console.WriteLine("\nDetaliile obiectului clona:");
            copyStud.AfisareDetalii();
        }
    }
}
