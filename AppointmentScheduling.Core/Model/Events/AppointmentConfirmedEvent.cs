using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Model.Events
{
    public class AppointmentConfirmedEvent : IDomainEvent
    {
        public AppointmentConfirmedEvent(Appointment appointment) : this()
        {
            AppointmentUpdated = appointment;
        }

        public AppointmentConfirmedEvent()
        {
            this.Id = Guid.NewGuid();
            DateTimeEventOccurred = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime DateTimeEventOccurred { get; private set; }

        public Appointment AppointmentUpdated { get; private set; }
    }
}
