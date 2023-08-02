using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionareAngajati
{
    internal class Manager : Angajat
    {
        public override double CalculeazaSalariu()
        {
            return Vechime > 0 ? Salariu_Minim + Salariu_Minim * 0.3 * Vechime : Salariu_Minim;
        }
    }
}
