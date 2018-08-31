namespace SourceOfSolid.OpenClosed.Model
{
    public class PoSCreditOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;

        public PoSCreditOrder(Cart cart, PaymentDetails paymentDetails)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);

            base.Checkout();
        }
    }
}
