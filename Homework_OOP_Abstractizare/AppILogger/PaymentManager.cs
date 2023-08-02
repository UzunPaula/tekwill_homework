using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppILogger
{
    internal class PaymentManager : IPaymentManager
    {
        private readonly ILogger _logger;
        private double minTax = 0.15;
        public PaymentManager(ILogger logger) 
        {
            _logger = logger; 
        }
        public void ProcessPayment(double amount, string creditCardNumber)
        {
            _logger.LogInformation("Started to process payment");
            if (amount <= 0)
            {
                _logger.LogWarning("Amount must be positive");
            }
            if (amount <= minTax)
            {
                _logger.LogWarning($"Amount must be greater than the min tax value: {minTax}");
            }
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occured: {ex.Message}");
            }
        }

        public void ProcessRefund(double amount, string transactionId)
        {
            throw new NotImplementedException();
        }

        public void RefundPayment(double amount, string transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
