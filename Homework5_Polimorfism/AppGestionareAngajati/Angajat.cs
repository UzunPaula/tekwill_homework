using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionareAngajati
{
    internal abstract class Angajat
    {
        protected const double Salariu_Minim = 10000;
        public string Nume { get; set; }
        public int Vechime { get; set; }  
        
        public virtual double CalculeazaSalariu()
        {
            return Salariu_Minim;
        }
    } 
}
