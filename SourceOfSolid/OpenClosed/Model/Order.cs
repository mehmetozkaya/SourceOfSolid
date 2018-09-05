using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceOfSolid.OpenClosed.Model
{
    public abstract class Order : IOrder
    {
        protected readonly Cart _cart;

        protected Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // log the order in the database
        }

        public OrderItem GetItem(int id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IOrder
    {
        void Checkout();
        OrderItem GetItem(int id);
    }
}
