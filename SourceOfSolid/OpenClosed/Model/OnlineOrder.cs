namespace SourceOfSolid.OpenClosed.Model
{
    public class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;

        protected OnlineOrder(Cart cart, PaymentDetails paymentDetails) 
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
            _reservationService = new ReservationService();
            _notificationService = new NotificationService();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);
            _reservationService.ReserveInventory(_cart.Items);
            _notificationService.NotifyCustomerOrderCreated(_cart);
            base.Checkout();
        }
    }
}
