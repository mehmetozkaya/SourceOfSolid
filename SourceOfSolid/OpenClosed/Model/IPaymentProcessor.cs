using System;

namespace SourceOfSolid.OpenClosed.Model
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }

    internal class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
