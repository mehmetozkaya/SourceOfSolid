using System;
using System.Collections.Generic;

namespace SourceOfSolid.OpenClosed.Model
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }

    public class ReservationService : IReservationService
    {
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
