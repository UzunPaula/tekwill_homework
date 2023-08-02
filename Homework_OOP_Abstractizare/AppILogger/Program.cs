using System;

namespace AppILogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = new FileLogger();
            var paymentManager = new PaymentManager(fileLogger);
            paymentManager.ProcessPayment(0.05, "3764743687314351");
        }
    }
}
