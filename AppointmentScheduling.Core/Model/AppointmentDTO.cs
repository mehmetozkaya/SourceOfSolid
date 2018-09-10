using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Model
{
    public class AppointmentDTO
    {
        public Guid AppointmentId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmailAddress { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string AppointmentType { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
