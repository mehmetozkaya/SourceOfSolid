namespace AppointmentScheduling.Core.Interfaces
{
    public interface IAppointmentDTORepository
    {
        AppointmentDTO GetFromAppointment(Appointment appointment);
    }
}
