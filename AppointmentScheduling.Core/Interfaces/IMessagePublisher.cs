using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Interfaces
{
    public interface IMessagePublisher
    {
        void Publish(IApplicationEvent applicationEvent);
    }
}
