using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudent
{
    public class Student
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Specializare { get; set; }

        public Student(string nume, int varsta, string specializare) 
        {
            Nume = nume;
            Varsta = varsta;
            Specializare = specializare;
        }
        public Student(Student copyStudent) 
        {
            Nume = copyStudent.Nume;
            Varsta = copyStudent.Varsta;
            Specializare = copyStudent.Specializare;
        }
        public void AfisareDetalii()
        {
            Console.WriteLine($"Numele: {Nume}");
            Console.WriteLine($"Varsta: {Varsta}");
            Console.WriteLine($"Specializarea: {Specializare}");
        }
    }
}
