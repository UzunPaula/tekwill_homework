using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionareAngajati
{
    internal class Programator : Angajat
    {
        public List<string> LimbajeDeProgramareCunoscute { get; set; }
        public override double CalculeazaSalariu()
        {
            var result = Salariu_Minim;
            //result = LimbajeDeProgramareCunoscute.Count * 0.5 * Salariu_Minim;
            var nrLimbajeNonCs = LimbajeDeProgramareCunoscute.Where(limbaj => limbaj != "C#").Count();

            result = nrLimbajeNonCs * 0.5 * Salariu_Minim;

            if (nrLimbajeNonCs > 0)
            {
                result += result + nrLimbajeNonCs * 0.5 * Salariu_Minim;
            }

            if (LimbajeDeProgramareCunoscute.Any(limbaj => limbaj == "C#"))
            {
                result += result + 4 * Salariu_Minim;
            }
            return result;
        }
    }
}
