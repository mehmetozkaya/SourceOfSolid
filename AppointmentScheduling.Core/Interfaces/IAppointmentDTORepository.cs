using AppointmentScheduling.Core.Model;
using AppointmentScheduling.Core.Model.ScheduleAggregate;

namespace AppointmentScheduling.Core.Interfaces
{
    public interface IAppointmentDTORepository
    {
        AppointmentDTO GetFromAppointment(Appointment appointment);
    }
}
