using System;

namespace SourceOfSolid.OpenClosed.Model
{
    internal interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }

    internal class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
