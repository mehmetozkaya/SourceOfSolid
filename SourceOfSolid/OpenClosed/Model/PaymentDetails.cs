using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceOfSolid.OpenClosed.Model
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }

    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpiresMonth { get; set; }

        public string ExpiresYear { get; set; }

        public string CardholderName { get; set; }
    }
}
