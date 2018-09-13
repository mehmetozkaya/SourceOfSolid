using AppointmentScheduling.Core.Model.ScheduleAggregate;
using FrontDesk.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Model.Events
{
    public class AppointmentScheduledEvent : IDomainEvent
    {
        public AppointmentScheduledEvent(Appointment appointment) : this()
        {
            AppointmentScheduled = appointment;
        }

        public AppointmentScheduledEvent()
        {
            this.Id = Guid.NewGuid();
            DateTimeEventOccurred = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime DateTimeEventOccurred { get; private set; }

        public Appointment AppointmentScheduled { get; private set; }
    }
}
