using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBankAccount
{
    public class Tranzactie
    {
        public DateTime data;
        public decimal suma;

        public Tranzactie(decimal suma)
        {
            data = DateTime.UtcNow;
            this.suma = suma;
        }
    }
}
