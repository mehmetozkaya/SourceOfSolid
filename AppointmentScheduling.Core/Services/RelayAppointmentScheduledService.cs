using AppointmentScheduling.Core.Interfaces;
using AppointmentScheduling.Core.Model;
using AppointmentScheduling.Core.Model.ApplicationEvents;
using FrontDesk.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Services
{
    public class RelayAppointmentScheduledService : IHandle<AppointmentScheduledEvent>
    {
        private readonly IAppointmentDTORepository _apptRepository;

        private readonly IMessagePublisher _messagePublisher;

        public RelayAppointmentScheduledService(IAppointmentDTORepository apptRepository, IMessagePublisher messagePublisher)
        {
            this._apptRepository = apptRepository;
            this._messagePublisher = messagePublisher;
        }

        public void Handle(AppointmentScheduledEvent appointmentScheduledEvent)
        {
            AppointmentDTO appointment = _apptRepository.GetFromAppointment(appointmentScheduledEvent.AppointmentScheduled);

            // we are translating from a domain event to an application event here
            var newEvent = new AppointmentScheduling.Core.Model.ApplicationEvents.AppointmentScheduledEvent(appointment);

            _messagePublisher.Publish(newEvent);
        }
    }
}
