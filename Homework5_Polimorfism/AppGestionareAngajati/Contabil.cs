using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionareAngajati
{
    internal class Contabil : Angajat
    {
        public override double CalculeazaSalariu()
        {
            return Vechime > 0 ? Salariu_Minim + Salariu_Minim * 0.2 * Vechime : Salariu_Minim;
        }
    }
}
