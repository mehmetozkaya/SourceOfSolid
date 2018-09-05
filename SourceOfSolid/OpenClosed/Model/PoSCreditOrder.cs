using System.Collections.Generic;

namespace SourceOfSolid.OpenClosed.Model
{
    internal class PoSCreditOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IEnumerable<string> _paymentTypeList;

        public PoSCreditOrder(Cart cart, PaymentDetails paymentDetails)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
            _paymentTypeList = new LinkedList<string>();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);            
            base.Checkout();
        }
    }
}
