using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppILogger
{
    internal interface IPaymentManager
    {
        void ProcessPayment(double amount, string creditCardNumber);
        void RefundPayment(double amount, string transactionId);
        void ProcessRefund(double amount, string transactionId);
    }
}
