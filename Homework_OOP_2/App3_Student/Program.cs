using System;

namespace App3_Student
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

            Console.WriteLine("Detaliile obiectului original: ");
            stud.AfisareDetalii();

            Console.WriteLine();

            Console.WriteLine("Detaliile obiectului clona");
            copyStud.AfisareDetalii();
        }
    }
}
