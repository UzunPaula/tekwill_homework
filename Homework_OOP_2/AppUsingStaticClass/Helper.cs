using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsingStaticClass
{
    public static class Helper
    {
        public static string GenerareCodUnic(string prefix)
        {
            Random random = new Random();
            int nrAleator = random.Next(1000, 10000);

            string codUnic = $"{prefix}{nrAleator}";
            return codUnic;
        }
    }
}
